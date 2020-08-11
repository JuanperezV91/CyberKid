using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class QuizManagerT2 : MonoBehaviour
{
    [SerializeField] private QuizUIT2 quizUIT2;
    [SerializeField] private List<QuizDataScriptableT2> quizData;
    [SerializeField] private float timeLimit = 80f; //80 segundos

    private List<QuestionT2> questions;
    private QuestionT2 selectedQuestion;
    private int scoreCount = 0;
    private float currentTimer;
    private int lifeRemaining = 3; // 3 Intentos

    private GameStatus gameStatus = GameStatus.Next;

    public GameStatus GameStatus { get { return gameStatus; } }
    // Start is called before the first frame update
    public void StartGame(int index)
    {
        scoreCount = 0;
        currentTimer = timeLimit;
        lifeRemaining = 3;
        questions = new List<QuestionT2>();

        for (int i = 0; i < quizData[index].questions.Count; i++)
        {
            questions.Add(quizData[index].questions[i]);
        }

        SelectQuestion();
        gameStatus = GameStatus.Playing;
    }

    // Update is called once per frame
    void SelectQuestion()
    {
        int val = UnityEngine.Random.Range(0, questions.Count);
        selectedQuestion = questions[val];

        quizUIT2.SetQuestionT2(selectedQuestion);

        questions.RemoveAt(val);
    }

    void Update()
    {
        if (gameStatus == GameStatus.Playing)
        {
            currentTimer -= Time.deltaTime;
            SetTimer(currentTimer);
        }
    }

    //Set Timer
    private void SetTimer(float value)
    {
        TimeSpan time = TimeSpan.FromSeconds(value);
        quizUIT2.TimerTextT2.text = "Tiempo: " + time.ToString("mm':'ss"); //Minutos y Segundos

        if (currentTimer <= 0)
        {
            gameStatus = GameStatus.Next;
            quizUIT2.GameOverPanelT2.SetActive(true);
        }
    }

    public bool Answer(string answered)
    {
        bool correctAns = false;

        if (answered == selectedQuestion.correctAns)
        {
            correctAns = true;
            scoreCount += 50; //Puntaje Local
            //Suma Puntaje General
            ScoreScript.scoreValue += 50;
            quizUIT2.ScoreTextT2.text = "Puntaje: " + scoreCount;
        }
        else
        {
            lifeRemaining--;
            quizUIT2.ReduceLife(lifeRemaining);

            if (lifeRemaining <= 0)
            {
                //Una vez que se nos acaben los intentos, el panel game over se activará para dar cierre, reintentar o compartir jugada.
                gameStatus = GameStatus.Next;
                quizUIT2.GameOverPanelT2.SetActive(true);
            }
        }


        if (gameStatus == GameStatus.Playing)
        {
            if (questions.Count > 0)
            {
                Invoke("SelectQuestion", 0.4f);
            }
            else
            {
                gameStatus = GameStatus.Next;
                quizUIT2.GameOverPanelT2.SetActive(true);
            }
        }

        return correctAns;
    }
}
[System.Serializable]
public class QuestionT2
{
    public string questionInfo;
    public QuestionTypeT2 questionTypeT2;
    public Sprite questionImg;
    public AudioClip questionClip;
    public UnityEngine.Video.VideoClip questionVideo;
    public List<string> options;
    public string correctAns;

}

[System.Serializable]

public enum QuestionTypeT2
{
    TEXT,
    IMAGE,
    VIDEO,
    AUDIO
}

[System.Serializable]

public enum GameStatusT2
{
    Next,
    Playing
}
