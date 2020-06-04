using UnityEngine;

///<summary>
/// Card input
///</summary>
public class TouchCard : InputBase
{
    [Header("Card ID")]
    public int cardId;
    [Header("Card is face up?")]
    public bool isFaceUp;
    [Header("Card effect particle")]
    public GameObject victoryParticle;
    [Header("Card mesh")]
    public GameObject mesh;
    public bool canFlipOver;

    void Start()
    {
        canFlipOver = true;
        //hide particle
        if (victoryParticle)
            victoryParticle.SetActive(false);
    }

    ///<summary>
    /// Inherited from TouchBase
    /// Reset click or touch input
    ///</summary>
    public override void SetFalse()
    {
        canDo = 0;
    }

    ///<summary>
    /// Inherited from TouchBase
    /// Get player click or touch input
    ///</summary>
    public override void OnMouseUp()
    {
        //proceed processing
        canDo = 1;
        //reset click or touch
        Invoke("SetFalse", 0.1f);
    }
}