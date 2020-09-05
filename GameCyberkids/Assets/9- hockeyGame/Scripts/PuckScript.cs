using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PuckScript : MonoBehaviour, IResetable
{

    public ScoreScriptHockey ScoreScriptInstance;
    public static bool WasGoal { get; private set; }
   // public float MaxSpeed;
   // public AudioManager audioManager;

    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        WasGoal = false;
        UiManager.Instance.ResetableGameObjects.Add(this);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!WasGoal)
        {
            if (other.tag == "AiGoal")
            {
                ScoreScriptInstance.Increment(ScoreScriptHockey.Score.PlayerScore);
                WasGoal = true;
               // audioManager.PlayGoal();
                StartCoroutine(ResetPuck(false));

                //Ganamos Puntaje
                ScoreScript.scoreValue += 100;


            }
            else if (other.tag == "PlayerGoal")
            {
                ScoreScriptInstance.Increment(ScoreScriptHockey.Score.AiScore);
                WasGoal = true;
               // audioManager.PlayGoal();
                StartCoroutine(ResetPuck(true));

                //Perdemos Puntaje
                ScoreScript.scoreValue -= 100;

            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       // audioManager.PlayPuckCollision();
    }

    private IEnumerator ResetPuck(bool didAiScore)
    {
        yield return new WaitForSecondsRealtime(1);
        WasGoal = false;
        rb.velocity = rb.position = new Vector2(0, 0);

        if (didAiScore)
            rb.position = new Vector2(0, -1);
        else
            rb.position = new Vector2(0, 1);
    }

    public void CenterPuck()
    {
        rb.position = new Vector2(0, 0);
    }

    public void ResetPosition()
    {
        rb.position = new Vector2(0, 0);
    }

    private void FixedUpdate()
    {
       // rb.velocity = Vector2.ClampMagnitude(rb.velocity, MaxSpeed);
    }
}