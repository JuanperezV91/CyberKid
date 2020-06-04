using UnityEngine;

public class FlipOver : MonoBehaviour
{
    [HeaderAttribute("Cards")]
    public TouchCard[] memoryCards;
    //"start time to flip down the cards")]
    private bool startTime;
    private float countTime;
    [HeaderAttribute("time to get back to play")]
    public float timeToGetBack;
    [HeaderAttribute("search cards in the scene automatically")]
    public bool searchCardsAutomatically;

    void Start()
    {
        if (searchCardsAutomatically)
            memoryCards = FindObjectsOfType<TouchCard>();

        Invoke("FlipCardOver", 0.2f);
    }

    void Update()
    {
        if (startTime)
            countTime += Time.deltaTime;

        if (countTime >= timeToGetBack)
        {
            startTime = false;
            FlipCardDown();
            countTime = 0;
        }
    }

    /// <summary>
    /// Flip the cards over.
    /// </summary>
    public void FlipCardOver()
    {
        GameController.GameControllerProperties.CurrentGameState = GameState.FLIP_OVER;
        var temp = FindObjectOfType<MemoryControllerBase>();
        StartCoroutine(temp.StartTime(timeToGetBack));

        for (int i = 0; i < memoryCards.Length; i++)
        {
            if (memoryCards[i].canFlipOver)
            {
                memoryCards[i].gameObject.GetComponent<Animator>().SetBool("CanFaceUp", true);
                memoryCards[i].isFaceUp = true;
                startTime = true;
            }
        }
    }

    /// <summary>
    /// Flip the cards down.
    /// </summary>
    public void FlipCardDown()
    {
        GameController.GameControllerProperties.CurrentGameState = GameState.MEMORY;

        for (int i = 0; i < memoryCards.Length; i++)
        {
            if (memoryCards[i].canFlipOver)
            {
                memoryCards[i].gameObject.GetComponent<Animator>().SetBool("CanFaceUp", false);
                memoryCards[i].isFaceUp = false;
            }
        }
    }
}
