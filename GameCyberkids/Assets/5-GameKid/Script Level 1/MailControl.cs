using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MailControl : MonoBehaviour
{
    public static int contMails;
    Text mails;

    void Start()
    {
        mails = GetComponent<Text>();
    }

    void Update()
    {
        mails.text = "" + contMails;
    }
}
