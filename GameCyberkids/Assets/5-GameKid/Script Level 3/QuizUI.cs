using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizUI : MonoBehaviour
{
    [SerializeField] public QuizManager quizManager;
    [SerializeField] private Text questionText, scoreText, timerText;
    [SerializeField] private List<Image> lifeImageList;
    [SerializeField] private GameObject gameOverPanel, mainMenuPanel, gameMenuPanel;
    [SerializeField] private Image questionImage;
    [SerializeField] private UnityEngine.Video.VideoPlayer questionVideo;
    [SerializeField] private AudioSource questionAudio;
    [SerializeField] private List<Button> options, uiButtons;
    [SerializeField] private Color correctCol, wrongCol, normalCol;
  
    private Question question;
    private bool answered;
    private float audioLength;

    public AudioSource CorrectAnswerSound;
    public AudioSource IncorrectAnswerSound;


    //Getters and Setters
    public Text ScoreText { get { return scoreText; } }
    public Text TimerText { get { return timerText; } }
    public GameObject GameOverPanel { get { return gameOverPanel; } }


    void Awake()
    {
        //Opciones
        for (int i = 0; i < options.Count; i++)
        {
            Button localBtn = options[i];
            localBtn.onClick.AddListener(() => OnClick(localBtn));
        }

        //UI Buttons
        for(int i = 0; i < uiButtons.Count; i++)
        {
            Button localBtn = uiButtons[i];
            localBtn.onClick.AddListener(() => OnClick(localBtn));
        }

       /* if (TargetsClicker.activePanel == true)
        {
            quizManager.StartGame(0);
            targetOne.SetActive(false);
        }*/


    }

      

    public void SetQuestion(Question question)
    {
        this.question = question;

        switch (question.questionType)
        {
            case QuestionType.TEXT:

                questionImage.transform.parent.gameObject.SetActive(false);

                break;
            case QuestionType.IMAGE:
                ImageHolder();
                questionImage.transform.gameObject.SetActive(true);

                questionImage.sprite = question.questionImg;
                break;
            case QuestionType.VIDEO:
                ImageHolder();
                questionVideo.transform.gameObject.SetActive(true);

                questionVideo.clip = question.questionVideo;
                questionVideo.Play();
                break;
            case QuestionType.AUDIO:
                ImageHolder();
                questionAudio.transform.gameObject.SetActive(true);

                audioLength = question.questionClip.length;
                StartCoroutine(PlayAudio());

                break;
        }

        questionText.text = question.questionInfo;

        List<string> answerList = ShuffleList.ShuffleListItems<string>(question.options);

        for (int i = 0; i < options.Count; i++)
        {
            options[i].GetComponentInChildren<Text>().text = answerList[i];
            options[i].name = answerList[i];
            options[i].image.color = normalCol;
        }

        answered = false;

    }

    IEnumerator PlayAudio()
    {
        if(question.questionType == QuestionType.AUDIO)
        {
            questionAudio.PlayOneShot(question.questionClip);

            yield return new WaitForSeconds(audioLength + 0.5f);

            StartCoroutine(PlayAudio());
        }
        else
        {
            StopCoroutine(PlayAudio());
            yield return null;

        }
    }

    void ImageHolder()
    {
        questionImage.transform.parent.gameObject.SetActive(true);
        questionImage.transform.gameObject.SetActive(false);
        questionAudio.transform.gameObject.SetActive(false);
        questionVideo.transform.gameObject.SetActive(false);
    }

    private void OnClick(Button btn)
    {
        if (quizManager.GameStatus == GameStatus.Playing)
        {
            if (!answered)
            {
                answered = true;
                bool val = quizManager.Answer(btn.name);

                if (val)
                {
                    btn.image.color = correctCol;
                    CorrectAnswerSound.Play();
                }
                else
                {
                    btn.image.color = wrongCol;
                    IncorrectAnswerSound.Play();
                }
            }
        }



        /*
        switch (btn.name)
        {
            case "TargetOne":
                quizManager.StartGame(0);
                targetOne.SetActive(false);
                break;
            case "TargetTwo":
                quizManager.StartGame(1);
                break;
            case "TargetThree":
                quizManager.StartGame(2);
                break;
            case "TargetFour":
                quizManager.StartGame(3);
                break;
            case "TargetFive":
                quizManager.StartGame(4);
                break;
           
        }*/

    }

    public void ReduceLife(int index)
    {
        lifeImageList[index].color = wrongCol;
    }


}
