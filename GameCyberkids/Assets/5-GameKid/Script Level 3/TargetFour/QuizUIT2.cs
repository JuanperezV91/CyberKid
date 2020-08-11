using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizUIT2 : MonoBehaviour
{
    [SerializeField] public QuizManagerT2 quizManagerT2;
    [SerializeField] private Text questionText, scoreTextT2, timerTextT2;
    [SerializeField] private List<Image> lifeImageList;
    [SerializeField] private GameObject gameOverPanelT2, mainMenuPanel, gameMenuPanel;
    [SerializeField] private Image questionImage;
    [SerializeField] private UnityEngine.Video.VideoPlayer questionVideo;
    [SerializeField] private AudioSource questionAudio;
    [SerializeField] private List<Button> options, uiButtons;
    [SerializeField] private Color correctCol, wrongCol, normalCol;

    private QuestionT2 question;
    private bool answered;
    private float audioLength;

    public AudioSource CorrectAnswerSoundT2;
    public AudioSource IncorrectAnswerSoundT2;

    //Getters and Setters
    public Text ScoreTextT2 { get { return scoreTextT2; } }
    public Text TimerTextT2 { get { return timerTextT2; } }
    public GameObject GameOverPanelT2 { get { return gameOverPanelT2; } }


    void Awake()
    {
        //Opciones
        for (int i = 0; i < options.Count; i++)
        {
            Button localBtn = options[i];
            localBtn.onClick.AddListener(() => OnClick(localBtn));
        }

        //UI Buttons
        for (int i = 0; i < uiButtons.Count; i++)
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



    public void SetQuestionT2(QuestionT2 question)
    {
        this.question = question;

        switch (question.questionTypeT2)
        {
            case QuestionTypeT2.TEXT:

                questionImage.transform.parent.gameObject.SetActive(false);

                break;
            case QuestionTypeT2.IMAGE:
                ImageHolder();
                questionImage.transform.gameObject.SetActive(true);

                questionImage.sprite = question.questionImg;
                break;
            case QuestionTypeT2.VIDEO:
                ImageHolder();
                questionVideo.transform.gameObject.SetActive(true);

                questionVideo.clip = question.questionVideo;
                questionVideo.Play();
                break;
            case QuestionTypeT2.AUDIO:
                ImageHolder();
                questionAudio.transform.gameObject.SetActive(true);

                audioLength = question.questionClip.length;
                StartCoroutine(PlayAudio());

                break;
        }

        questionText.text = question.questionInfo;

        List<string> answerList = ShuffleListT2.ShuffleListT2Items<string>(question.options);

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
        if (question.questionTypeT2 == QuestionTypeT2.AUDIO)
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
        if (quizManagerT2.GameStatus == GameStatus.Playing)
        {
            if (!answered)
            {
                answered = true;
                bool val = quizManagerT2.Answer(btn.name);

                if (val)
                {
                    btn.image.color = correctCol;
                    CorrectAnswerSoundT2.Play();
                }
                else
                {
                    btn.image.color = wrongCol;
                    IncorrectAnswerSoundT2.Play();
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