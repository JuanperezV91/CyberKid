using UnityEngine;
using System.Collections;
using System.Collections.Generic;

///<summary>
/// Gui of the game
///</summary>
[System.Serializable]
public class GUISkin
{
    [Tooltip("Show player scores")]
    public TextMesh showScore;
    [Tooltip("Show player combo")]
    public TextMesh showCombo;
    [Tooltip("Show minutes")]
    public TextMesh showMinuteTime;
    [Tooltip("Show seconds")]
    public TextMesh showSecondTime;
}

///<summary>
/// Abstract class that controls the memory match flow. You can simply inherit from this class to add as
/// many levels as you can.
///</summary>
public abstract class MemoryControllerBase : MonoBehaviour
{
    [Header("GUI of the game")]
    public GUISkin guiInstance;
    [Header("Cards, drop them here")]
    public TouchCard[] memoryCards;
    //search cards automatically
    public bool searchCardsAutomatically;

    [Header("Diamonds score level")]
    public GameObject[] diamondsLevel;

    #region ADJUSTABLE VARIABLES
    [Header("Time (in seconds) to player score level")]
    [Tooltip("Player got a excelent time to finish, 3 diamonds")]
    public float excelentTime;
    [Tooltip("Player got a good time to finish, 2 diamonds, greater than this, 1 diamond")]
    public float goodTime;
    [Header("Score per simple and combo match")]
    [Tooltip("Player got a simple match")]
    public int scorePerSimpleMatch;
    [Tooltip("Player got a combo match")]
    public int scorePerComboMatch;
    [Header("Time (in seconds) to face card down")]
    [Tooltip("Time to face card down")]
    public float timeToFaceCardDown;
    [Header("Time (in seconds) to start the game")]
    [Tooltip("Time to start the game")]
    public float timeToStartGame;
    [Header("is using FlipOver at the beginning?")]
    [Tooltip("if using flip over at the beginning, check this, otherwise, uncheck")]
    public bool isUsingFlipOver;
    #endregion

    #region HIDEININSPECTOR VARIABLES
    //player can play the game
    [HideInInspector]
    public bool canPlay = true;
    //count cards faced up
    [HideInInspector]
    public int countCardFaceUp;
    //player can combo
    [HideInInspector]
    public bool canCombo = true;
    //find cards faced up
    [HideInInspector]
    public TouchCard[] findCardsFacedUp;
    //scores
    [HideInInspector]
    public int scores;
    //count combo
    [HideInInspector]
    public int countCombo;
    //count player match
    [HideInInspector]
    public int countMatch;
    //start game time
    [HideInInspector]
    public bool canStartTime;
    //count seconds
    [HideInInspector]
    public float countSeconds;
    //count minutes
    [HideInInspector]
    public float countMinutes;
    #endregion

    protected void Start()
    {
        if (searchCardsAutomatically)
            memoryCards = FindObjectsOfType<TouchCard>();

        //wait to start game
        if (!isUsingFlipOver)
        {
            StartCoroutine(StartTime(timeToStartGame));
            StopCoroutine("StartTime");
        }

        //hide diamonds
        HideDiamonds();

    }

    #region INTERNAL METHODS

    ///<summary>
    /// Hide diamonds score level
    ///</summary>
    void HideDiamonds()
    {
        for (int i = 0; i < diamondsLevel.Length; i++)
        {
            if (diamondsLevel[i] != null)
            {
                diamondsLevel[i].SetActive(false);
            }
        }
    }

    ///<summary>
    /// start game time to ontinue game
    ///</summary>
    public IEnumerator StartTime(float time)
    {
        yield return new WaitForSeconds(time);
        //start game time
        canStartTime = true;
    }

    #endregion

    #region EXTERNAL METHODS

    ///<summary>
    /// Check whether a card is face up, if so, increment the player move 
    /// and check if got score
    ///</summary>
    public void CheckCardFaceUp()
    {
        for (int i = 0; i < memoryCards.Length; i++)
        {
            //if player has faced up some card
            if (memoryCards[i].canDo == 1)
            {
                if (canPlay && !memoryCards[i].isFaceUp)
                {
                    //count player move and play card face up animation
                    countCardFaceUp++;
                    memoryCards[i].gameObject.GetComponent<Animator>().SetBool("CanFaceUp", true);
                    //check isFaceUp bool of this current card
                    memoryCards[i].isFaceUp = true;
                    //reset card click to avoid wird behaviour
                    memoryCards[i].canDo = 0;

                    //if playe has faced up 2 cards
                    if (countCardFaceUp >= 2)
                    {
                        //check if got score
                        MemoryBehaviour();
                        //stop game momentarily
                        canPlay = false;
                        //break the loop
                        break;
                    }
                }
            }
        }
    }

    //Method overrided in MemoryControllerEasy
    public abstract void MemoryBehaviour();

    ///<summary>
    /// Add scores and update textmesh
    ///</summary>
    public void AddScore(int addScore)
    {
        //increment player match
        countMatch++;
        //add score
        scores += addScore;
        ScoreScript.scoreValue += addScore;
        //update the gui showing the scores, avoid showing it in Update
        guiInstance.showScore.text = scores.ToString();
    }

    ///<summary>
    /// Show score level according to player time
    /// There are 3 levels: normal, good, excelent
    ///</summary>
    public void ShowPlayerScoreLevel(float currentTime)
    {
        //got 3 diamonds, excelent
        if (currentTime < excelentTime)
        {
            if (diamondsLevel[0] != null)
            {
                diamondsLevel[0].SetActive(true);
            }

            if (diamondsLevel[1] != null)
            {
                diamondsLevel[1].SetActive(true);
            }

            if (diamondsLevel[2] != null)
            {
                diamondsLevel[2].SetActive(true);
            }
        }

        //got 2 diamonds, good
        else if (currentTime > excelentTime && currentTime < goodTime)
        {
            if (diamondsLevel[0] != null)
            {
                diamondsLevel[0].SetActive(true);
            }

            if (diamondsLevel[1] != null)
            {
                diamondsLevel[1].SetActive(true);
            }

            if (diamondsLevel[2] != null)
            {
                diamondsLevel[2].SetActive(false);
            }
        }

        //got 1 diamond, normal
        else
        {
            if (diamondsLevel[0] != null)
            {
                diamondsLevel[0].SetActive(true);
            }

            if (diamondsLevel[1] != null)
            {
                diamondsLevel[1].SetActive(false);
            }

            if (diamondsLevel[2] != null)
            {
                diamondsLevel[2].SetActive(false);
            }
        }
    }
    ///<summary>
    /// Face down the current face up card
    ///</summary>
    public IEnumerator FaceCardDown()
    {
        //wait some seconds to proceed
        yield return new WaitForSeconds(timeToFaceCardDown);

        //find cards faced up and face them down
        for (int i = 0; i < findCardsFacedUp.Length; i++)
        {
            if (findCardsFacedUp[i] != null && findCardsFacedUp[i].isFaceUp)
            {
                findCardsFacedUp[i].gameObject.GetComponent<Animator>().SetBool("CanFaceUp", false);
                findCardsFacedUp[i].isFaceUp = false;
                countCardFaceUp = 0;
                //play game again
                canPlay = true;
            }
        }
    }

    #endregion
}
