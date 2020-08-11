using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class QuizManager : MonoBehaviour
{
    [SerializeField] private QuizUI quizUI;
    [SerializeField] private List<QuizDataScriptable> quizData;
    [SerializeField] private float timeLimit = 80f; //80 segundos

    private List<Question> questions;
    private Question selectedQuestion;
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
        questions = new List<Question>();

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

        quizUI.SetQuestion(selectedQuestion);

        questions.RemoveAt(val);
    }

    void Update()
    {
        if(gameStatus == GameStatus.Playing)
        {
            currentTimer -= Time.deltaTime;
            SetTimer(currentTimer);
        }
    }

    //Set Timer
    private void SetTimer(float value)
    {
        TimeSpan time = TimeSpan.FromSeconds(value);
        quizUI.TimerText.text = "Tiempo: " + time.ToString("mm':'ss"); //Minutos y Segundos

        if(currentTimer <= 0)
        {
            gameStatus = GameStatus.Next;
            quizUI.GameOverPanel.SetActive(true);
        }
    }

    public bool Answer(string answered)
    {
        bool correctAns = false;

        if(answered == selectedQuestion.correctAns)
        {
            correctAns = true;
            scoreCount += 50; //Puntaje Local
            //Suma Puntaje General
            ScoreScript.scoreValue += 50;
            quizUI.ScoreText.text = "Puntaje: " + scoreCount;
        }
        else
        {
            lifeRemaining--;
            quizUI.ReduceLife(lifeRemaining);

            if(lifeRemaining <= 0)
            {
                //Una vez que se nos acaben los intentos, el panel game over se activará para dar cierre, reintentar o compartir jugada.
                gameStatus = GameStatus.Next;
                quizUI.GameOverPanel.SetActive(true);
            }
        }


        if(gameStatus == GameStatus.Playing)
        {
            if (questions.Count > 0)
            {
                Invoke("SelectQuestion", 0.4f);
            }
            else
            {
                gameStatus = GameStatus.Next;
                quizUI.GameOverPanel.SetActive(true);
            }
        }

        return correctAns;
    }
}
[System.Serializable]
public class Question
{
    public string questionInfo;   
    public QuestionType questionType;
    public Sprite questionImg;
    public AudioClip questionClip;
    public UnityEngine.Video.VideoClip questionVideo;
    public List<string> options;
    public string correctAns;

}

[System.Serializable]

public enum QuestionType
{
    TEXT,
    IMAGE,
    VIDEO,
    AUDIO        
}

[System.Serializable]

public enum GameStatus
{
    Next,
    Playing
}
