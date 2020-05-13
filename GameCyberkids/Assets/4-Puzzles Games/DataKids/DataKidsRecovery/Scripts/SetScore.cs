using UnityEngine;
using System.Collections;

public class SetScore : MonoBehaviour 
{
	public TextMesh bestScoreLabel;
	public TextMesh scoreLabel;

	void Start () 
	{
		scoreLabel.text = "Puntuación: " + GameManager.score.ToString();

		if (GameManager.score > 0)
		{
			if (PlayerPrefs.GetInt("Puntuación", 0) < GameManager.score)
			{
				PlayerPrefs.SetInt("Puntuación", GameManager.score);
				PlayerPrefs.Save();
			}
		}

		bestScoreLabel.text = "Mejor Puntuación: " + PlayerPrefs.GetInt("Puntuación", 0).ToString();
		GameManager.score = 0;
	}
}