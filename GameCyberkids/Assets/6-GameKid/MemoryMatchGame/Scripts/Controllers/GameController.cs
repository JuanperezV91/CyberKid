using UnityEngine;

///<summary>
/// enum for game stating
///</summary>
public enum GameState
{
    WAITING,
    MEMORY,
	FLIP_OVER,
	GAME_OVER
}

///<summary>
/// Controls the game flow
///</summary>
public class GameController 
{
	//current game state
    private GameState currentGameState = GameState.MEMORY;
	//singleton of this class
    private static GameController gameControllerInstance = null;

	//constructor
    private GameController()
    {
        
    }

	//propertie to get an instance of this object
    public static GameController GameControllerProperties
    {
        get
        {
            if(gameControllerInstance == null)
            {
                gameControllerInstance = new GameController();
            }

            return gameControllerInstance;
        }
    }
	
	//propertie to get and set game state
    public GameState CurrentGameState
    {
        get
        {
            return currentGameState;
			Debug.Log (currentGameState);
        }

        set
        {
			currentGameState = value;
			Debug.Log (currentGameState);
        }
    }
}
