using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChatBubble : MonoBehaviour
{
  


    public enum IconType
    {
        Happy,
        Neutral,
        Angry,
    }

    [SerializeField] private Sprite happyIconSprite;
    [SerializeField] private Sprite neutralIconSprite;
    [SerializeField] private Sprite angryIconSprite;

    private SpriteRenderer backgroundSpriteR;
    private SpriteRenderer iconSpriteRenderer;
    private TextMeshPro textMeshPro;

    private void Awake()
    {
        backgroundSpriteR = transform.Find("chatBackground").GetComponent<SpriteRenderer>();
        iconSpriteRenderer = transform.Find("iconFace").GetComponent<SpriteRenderer>();
        textMeshPro = transform.Find("TextChat").GetComponent<TextMeshPro>();

    }

    private void Start()
    {
        Setup(IconType.Angry ,"Hello World!");
    }

    private void Setup(IconType iconType, string text)
    {
        textMeshPro.SetText(text);
        textMeshPro.ForceMeshUpdate();
        Vector2 textSize = textMeshPro.GetRenderedValues(false);

        Vector2 padding = new Vector2(6f, 2f);
        backgroundSpriteR.size = textSize + padding;

        Vector2 offset = new Vector2(-2f, 0f);
        backgroundSpriteR.transform.localPosition = new Vector3(backgroundSpriteR.size.x / 2f, 0f);

        iconSpriteRenderer.sprite = GetIconSprite(iconType);
    }

    private Sprite GetIconSprite(IconType iconType)
    {
        switch (iconType)
        {
            default:
            case IconType.Happy: return happyIconSprite;
            case IconType.Neutral: return neutralIconSprite;
            case IconType.Angry: return angryIconSprite;

        }
    }
}
