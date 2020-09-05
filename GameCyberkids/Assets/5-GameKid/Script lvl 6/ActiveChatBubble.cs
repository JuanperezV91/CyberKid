using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ActiveChatBubble : MonoBehaviour
{
    public GameObject chatBubble;
    public TextMeshPro textMeshChat;
    string textChat;


    //Icon 

   /* public enum IconType
    {
        Happy,
        Neutral,
        Angry,
    }*/

  //  [SerializeField] private Sprite happyIconSprite;
  //  [SerializeField] private Sprite neutralIconSprite;
  //  [SerializeField] private Sprite angryIconSprite;

  //  private SpriteRenderer iconSpriteRenderer;


    void Start()
    {
        textChat = "";
    }

    public void desactivarTextBubble()
    {
        chatBubble.SetActive(false);
    }

    public void activarTextBubble1()
    {
        //Saludo
        textChat = "Hola!";
        chatBubble.SetActive(true);
        textMeshChat.SetText(textChat);

        Invoke("desactivarTextBubble", 8f);
    }

    public void activarTextBubble2()
    {
        //Saludo
        textChat = "Como estas?";
        chatBubble.SetActive(true);
        textMeshChat.SetText(textChat);

        Invoke("desactivarTextBubble", 8f);

    }

    public void activarTextBubble3()
    {
        //Saludo
        textChat = "Muy Bien!";
        chatBubble.SetActive(true);
        textMeshChat.SetText(textChat);

        Invoke("desactivarTextBubble", 8f);

    }

    public void activarTextBubble4()
    {
        //Saludo
        textChat = "Protege tus Datos";
        chatBubble.SetActive(true);
        textMeshChat.SetText(textChat);

        Invoke("desactivarTextBubble", 8f);

    }

    public void activarTextBubble5()
    {
        //Saludo
        textChat = "Sigue Así";
        chatBubble.SetActive(true);
        textMeshChat.SetText(textChat);

        Invoke("desactivarTextBubble", 8f);

    }

    public void activarTextBubble6()
    {
        //Saludo
        textChat = "Incorrecto";
        chatBubble.SetActive(true);
        textMeshChat.SetText(textChat);

        Invoke("desactivarTextBubble", 8f);

    }

    public void activarTextBubble7()
    {
        //Saludo
        textChat = "Buena Jugada";
        chatBubble.SetActive(true);
        textMeshChat.SetText(textChat);

        Invoke("desactivarTextBubble", 8f);

    }

    public void activarTextBubble8()
    {
        //Saludo
        textChat = "No des tu Información";
        chatBubble.SetActive(true);
        textMeshChat.SetText(textChat);

        Invoke("desactivarTextBubble", 8f);

    }

}
