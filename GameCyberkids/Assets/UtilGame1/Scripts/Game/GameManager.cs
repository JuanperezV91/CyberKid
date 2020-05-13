using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;
#if UNITY_ANALYTICS
using UnityEngine.Analytics;
#endif

public class GameManager : MonoBehaviour {

    public static GameManager Instance = null;

    public PlayerController Player;

    public GameObject GameOverHUD;

    public GameObject GameWonHUD;

    public float ShowGameOverTime = 1.5f;

    public float ShowGameWonTime = 1.0f;

    public event EventHandler GameOver;

    public event EventHandler GameWon;

    public GameWinCondition WinCondition;


    public GameObject[] objects;

    private float lastCreated;

    public TextMesh lostFoodLabel;
    private int lostFood;
    public int LostFood
    {
        set
        {
            lostFood = value;

            lostFoodLabel.text = lostFood.ToString();

            if (LostFood >= 8)
                Application.LoadLevel("MainMenu");
        }
        get
        {
            return lostFood;
        }
    }

    public TextMesh scoreLabel;
    public static int score;
    public int Score
    {
        set
        {
            score = value;

            scoreLabel.text = Score.ToString();
        }
        get
        {
            return score;
        }
    }

    private float speed;

    void Start()
    {
        score = 0;
        lastCreated = 0;

        lastCreated = Time.time;

        speed = 2.5f;

        Invoke("CreateObjects", 0.01f);
    }

    void CreateObjects()

    {
        Instantiate(objects[Random.Range(0, objects.Length)], new Vector3(Random.Range(-5.5f, 5.6f), 5.5f, 0), Quaternion.identity);

        if (Score % 5 == 0)
            speed -= 0.01f;

        Invoke("CreateObjects", speed);
    }



    void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
        }

        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        // Dont destroy on reloading the scene
        // DontDestroyOnLoad(gameObject);

        if (Player == null)
        {
            Debug.LogError("You need to assign a Player to the GameManager");
        }

        if (Player != null)
        {
            Player.PlayerDied += Player_PlayerDied;
        }
    }

    private void Player_PlayerDied(object sender, System.EventArgs e)
    {
        SetGameOver();
    }

    public void SetGameOver()
    {
        if (Player.Hud == null)
        {
            Debug.LogError("You need to assign a HUD to the PlayerController");
        }
        else
        {
            Player.Hud.gameObject.SetActive(false);

            if (GameOverHUD == null)
            {
                Debug.LogError("You need to assign a GameOverHUD to the GameManager");
            }
            else
            {
                GameOverNotify();

                Invoke("ShowGameOver", ShowGameOverTime);
            }
        }
    }

    public void SetGameWon()
    {
        if (Player.Hud == null)
        {
            Debug.LogError("You need to assign a HUD to the PlayerController");
        }
        else
        {
            Player.Hud.gameObject.SetActive(false);

            if (GameWonHUD == null)
            {
                Debug.LogError("You need to assign a GameWonHUD to the GameManager");
            }
            else
            {
                GameWonNotify();

                Invoke("ShowGameWon", ShowGameWonTime);
            }
        }
    }

    private void GameOverNotify()
    {
        if (GameOver != null)
            GameOver(this, EventArgs.Empty);
    }

    private void GameWonNotify()
    {
        if (GameWon != null)
            GameWon(this, EventArgs.Empty);
    }

    private void ShowGameOver()
    {
        GameOverHUD.SetActive(true);
    }

    private void ShowGameWon()
    {
        GameWonHUD.SetActive(true);
    }

    public void RetryGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }



    //KidRun
    static public GameManager instance { get { return s_Instance; } }
    static protected GameManager s_Instance;

    public AState[] states;
    public AState topState { get { if (m_StateStack.Count == 0) return null; return m_StateStack[m_StateStack.Count - 1]; } }

    public ConsumableDatabase m_ConsumableDatabase;

    protected List<AState> m_StateStack = new List<AState>();
    protected Dictionary<string, AState> m_StateDict = new Dictionary<string, AState>();

    protected void OnEnable()
    {
        PlayerData.Create();

        s_Instance = this;

        m_ConsumableDatabase.Load();

        // We build a dictionnary from state for easy switching using their name.
        m_StateDict.Clear();

        if (states.Length == 0)
            return;

        for (int i = 0; i < states.Length; ++i)
        {
            states[i].manager = this;
            m_StateDict.Add(states[i].GetName(), states[i]);
        }

        m_StateStack.Clear();
        PushState(states[0].GetName());
    }

    protected void Update()
    {
        if (m_StateStack.Count > 0)
        {
            m_StateStack[m_StateStack.Count - 1].Tick();
        }
    }

    protected void OnApplicationQuit()
    {
#if UNITY_ANALYTICS
        // We are exiting during game, so this make this invalid, send an event to log it
        // NOTE : this is only called on standalone build, as on mobile this function isn't called
        bool inGameExit = m_StateStack[m_StateStack.Count - 1].GetType() == typeof(GameState);

        Analytics.CustomEvent("user_end_session", new Dictionary<string, object>
        {
            { "force_exit", inGameExit },
            { "timer", Time.realtimeSinceStartup }
        });
#endif
    }

    // State management
    public void SwitchState(string newState)
    {
        AState state = FindState(newState);
        if (state == null)
        {
            Debug.LogError("Can't find the state named " + newState);
            return;
        }

        m_StateStack[m_StateStack.Count - 1].Exit(state);
        state.Enter(m_StateStack[m_StateStack.Count - 1]);
        m_StateStack.RemoveAt(m_StateStack.Count - 1);
        m_StateStack.Add(state);
    }

    public AState FindState(string stateName)
    {
        AState state;
        if (!m_StateDict.TryGetValue(stateName, out state))
        {
            return null;
        }

        return state;
    }

    public void PopState()
    {
        if (m_StateStack.Count < 2)
        {
            Debug.LogError("Can't pop states, only one in stack.");
            return;
        }

        m_StateStack[m_StateStack.Count - 1].Exit(m_StateStack[m_StateStack.Count - 2]);
        m_StateStack[m_StateStack.Count - 2].Enter(m_StateStack[m_StateStack.Count - 2]);
        m_StateStack.RemoveAt(m_StateStack.Count - 1);
    }

    public void PushState(string name)
    {
        AState state;
        if (!m_StateDict.TryGetValue(name, out state))
        {
            Debug.LogError("Can't find the state named " + name);
            return;
        }

        if (m_StateStack.Count > 0)
        {
            m_StateStack[m_StateStack.Count - 1].Exit(state);
            state.Enter(m_StateStack[m_StateStack.Count - 1]);
        }
        else
        {
            state.Enter(null);
        }
        m_StateStack.Add(state);
    }
}

public abstract class AState : MonoBehaviour
{
    [HideInInspector]
    public GameManager manager;

    public abstract void Enter(AState from);
    public abstract void Exit(AState to);
    public abstract void Tick();

    public abstract string GetName();
}
   

