using UnityEngine;
using System.Collections;
using System.Collections.Generic;

///<summary>
/// Inherits from MemoryControllerBase
///</summary>
public class MemoryControlllerEasy : MemoryControllerBase
{
	[Header("Continue counting time during flip over?")]
	public bool continueTime;
	public GameObject panelGameOver;

    new void Start()
    {
        base.Start();
    }

    void Update()
    {
		//if game state is MEMORY, continue playing
		if(GameController.GameControllerProperties.CurrentGameState == GameState.MEMORY)
		{
        	CheckCardFaceUp();
			HandleTime ();
		}

		//if game state is FLIP_OVER, continue counting time
		if(GameController.GameControllerProperties.CurrentGameState == GameState.FLIP_OVER)
		{
			if(continueTime)
				HandleTime ();
		}

		//restart game
		if (GameController.GameControllerProperties.CurrentGameState == GameState.GAME_OVER)
			panelGameOver.SetActive(true);
			//HandleRestartGame ();
	}

	#region EXTERNAL METHODS
	///<summary>
	/// Overrides from MemoryControllerBase
	/// Check wheter score or not
	///</summary>
	public override void MemoryBehaviour ()
    {  
        //find cards faced up
        findCardsFacedUp = FindObjectsOfType<TouchCard>();
		//list to store cards that playe has touched
		List<TouchCard> tempCards = new List<TouchCard>();

		//store touched cards in the list
		for(int i = 0; i < findCardsFacedUp.Length; i++)
		{
			if(findCardsFacedUp[i].isFaceUp)
			{
				tempCards.Add (findCardsFacedUp[i]);
			}
		}

		//if it has 2 cards touched
		if(tempCards.Count == 2)
		{
			//if they are equals, score
			if(tempCards[0].cardId == tempCards[1].cardId)
			{
				//if combo, apply combo score
				if (canCombo)
				{
					//add a combo score
					AddScore(scorePerComboMatch);
					//increment combo
					countCombo++;
					//update gui showing combo
					guiInstance.showCombo.text = countCombo.ToString();
				}
				
				//otherwise, simple score
				else
				{
					//add a simple score
					AddScore(scorePerSimpleMatch);
				}

				//reset player's move
				countCardFaceUp = 0;
				//uncheck cards faced up
				tempCards[0].isFaceUp = false;
				tempCards[1].isFaceUp = false;
				//hide current cards faced up that are equals
				StartCoroutine(HideCardAfterMatch(tempCards[0], tempCards[1]));
				StartCoroutine(HideCardAfterMatch(tempCards[0], tempCards[1]));

				StopCoroutine("HideCardAfterMatch");
			}

			//if they are not equals, get back to game
			else
			{
				//Desativa o combo
				canCombo = false;
				//Vira a peca
				StartCoroutine (FaceCardDown ());
				StopCoroutine("FaceCardDown");
			}
		}
	}

	#endregion

	#region INTERNAL METHODS

	///<summary>
	/// Handle restart game
	///</summary>
	void HandleRestartGame()
	{
		if(Input.GetKeyDown (KeyCode.R) || Input.GetMouseButtonDown (0))
		{
			GameController.GameControllerProperties.CurrentGameState = GameState.MEMORY;
			Application.LoadLevel (0);
		}
	}
	
	///<summary>
	/// Handle game time
	///</summary>
	void HandleTime()
	{
		if (canStartTime)
		{
			countSeconds += Time.deltaTime;
		}
		
		if (countSeconds >= 60)
		{
			countMinutes++;
			countSeconds = 0;
		}
		
		guiInstance.showMinuteTime.text = string.Format("{00:00}:", countMinutes);
		guiInstance.showSecondTime.text = countSeconds.ToString("F0");
		
		//game over
		if (countMatch >= memoryCards.Length / 2)
		{
			//end game, do something
			ShowPlayerScoreLevel((countMinutes * 60) + countSeconds);
			GameController.GameControllerProperties.CurrentGameState = GameState.GAME_OVER;
			countMatch = 0;
		}
	}

	///<summary>
	/// Hide card after playe match
	///</summary>
    IEnumerator HideCardAfterMatch(TouchCard card1, TouchCard card2)
    {
		//wait to proceed
        yield return new WaitForSeconds(0.6f);

		//reset card collider
        card1.gameObject.GetComponent<BoxCollider>().size = new Vector3(0, 0, 0);
        card2.gameObject.GetComponent<BoxCollider>().size = new Vector3(0, 0, 0);
        //show match effect
        card1.victoryParticle.SetActive(true);
        card2.victoryParticle.SetActive(true);
        //hide card
       // card1.mesh.SetActive(false);
		//card2.mesh.SetActive(false);
		card1.mesh.SetActive(true);
		card2.mesh.SetActive(true);
		//get back to game
		canPlay = true;
    }

	#endregion
}
