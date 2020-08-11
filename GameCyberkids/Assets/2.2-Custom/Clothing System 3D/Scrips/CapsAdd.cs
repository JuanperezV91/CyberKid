using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsAdd : MonoBehaviour
{
    public GameObject capBlack;
    public GameObject capOrange;
    public GameObject capPurple;
    public GameObject capWhite;
    public GameObject hatBlack;
    public GameObject hatRed;
    public GameObject hatNormal;

    public bool activeCap = true;
    public bool desactiveCap = false;

    static public bool acCapBlack;
    static public bool acCapOrange;
    static public bool acCapPurple;
    static public bool acCapWhite;
    static public bool acHatBlack;
    static public bool acHatRed;
    static public bool acHatNormal;

    public static int valueBlack;
    public static int valueOrange;
    public static int valuePurple;
    public static int valueWhite;
    public static int valueHatBlack;
    public static int valueHatRed;
    public static int valueNormal;


    void Start()
    {
        acCapBlack = (PlayerPrefs.GetInt("capblack") != 0);
        acCapOrange = (PlayerPrefs.GetInt("caporange") != 0);
        acCapPurple = (PlayerPrefs.GetInt("cappurple") != 0);
        acCapWhite = (PlayerPrefs.GetInt("capwhite") != 0);
        acHatBlack = (PlayerPrefs.GetInt("hatblack") != 0);
        acHatRed = (PlayerPrefs.GetInt("hatred") != 0);
        acHatNormal = (PlayerPrefs.GetInt("hatnormal") != 0);

        capBlack.SetActive(acCapBlack);
        capOrange.SetActive(acCapOrange);
        capPurple.SetActive(acCapPurple);
        capWhite.SetActive(acCapWhite);
        hatBlack.SetActive(acHatBlack);
        hatRed.SetActive(acHatRed);
        hatNormal.SetActive(acHatNormal);
    }

    void Update()
    {
    }

    public void activeCapBlack()
    {
        valueBlack = acCapBlack ? 1 : 0;
       

        acCapBlack = true;
        acCapOrange = false;
        acCapPurple = false;
        acCapWhite = false;
        acHatBlack = false;
        acHatRed = false;
        acHatNormal = false;


    capBlack.SetActive(acCapBlack);
        //Desactivadas
        capOrange.SetActive(acCapOrange);
        capPurple.SetActive(acCapPurple);
        capWhite.SetActive(acCapWhite);
        hatBlack.SetActive(acHatBlack);
        hatRed.SetActive(acHatRed);
        hatNormal.SetActive(acHatNormal);

        if (acCapBlack == true)
        {
            valueBlack = 1;
            PlayerPrefs.SetInt("capblack", valueBlack);
        }
        else
        {
            valueBlack = 0;
        }

        valueOrange = acCapOrange ? 1 : 0;
        valuePurple = acCapPurple ? 1 : 0;
        valueWhite = acCapWhite ? 1 : 0;
        valueHatBlack = acHatBlack ? 1 : 0;
        valueHatRed = acHatRed ? 1 : 0;
        valueNormal = acHatNormal ? 1 : 0;

        //Gorrito salmon
        if (acCapOrange == false && acCapPurple == false && acCapWhite == false && acHatBlack == false && acHatRed == false && acHatNormal == false)
        {
            valueOrange = 0;
            valuePurple = 0;
            valueWhite = 0;
            valueHatBlack = 0;
            valueHatRed = 0;
            valueNormal = 0;

            PlayerPrefs.SetInt("caporange", valueOrange);
            PlayerPrefs.SetInt("cappurple", valuePurple);
            PlayerPrefs.SetInt("capwhite", valueWhite);
            PlayerPrefs.SetInt("hatblack", valueHatBlack);
            PlayerPrefs.SetInt("hatred", valueHatRed);
            PlayerPrefs.SetInt("hatnormal", valueNormal);


        }


    }

    //Gorrito naranjo
    public void activeCapOrange()
    {
        valueOrange = acCapOrange ? 1 : 0;

        acCapBlack = desactiveCap;
        acCapOrange = activeCap;
        acCapPurple = desactiveCap;
        acCapWhite = desactiveCap;
        acHatBlack = desactiveCap;
        acHatRed = desactiveCap;
        acHatNormal = desactiveCap;

        capBlack.SetActive(acCapBlack);
        //Desactivadas
        capOrange.SetActive(acCapOrange);
        capPurple.SetActive(acCapPurple);
        capWhite.SetActive(acCapWhite);
        hatBlack.SetActive(acHatBlack);
        hatRed.SetActive(acHatRed);
        hatNormal.SetActive(acHatNormal);

        //PlayerPrefs Save

        if (acCapOrange == true)
        {
            valueOrange = 1;
            PlayerPrefs.SetInt("caporange", valueOrange);
        }
        else
        {
            valueOrange = 0;
        }

        valueBlack = acCapBlack ? 1 : 0;
        acCapBlack = false;

        if (acCapBlack == false && acCapPurple == false && acCapWhite == false && acHatBlack == false && acHatRed == false && acHatNormal == false)
        {
            valueBlack = 0;
            valuePurple = 0;
            valueWhite = 0;
            valueHatBlack = 0;
            valueHatRed = 0;
            valueNormal = 0;

            PlayerPrefs.SetInt("capblack", valueBlack);
            PlayerPrefs.SetInt("cappurple", valuePurple);
            PlayerPrefs.SetInt("capwhite", valueWhite);
            PlayerPrefs.SetInt("hatblack", valueHatBlack);
            PlayerPrefs.SetInt("hatred", valueHatRed);
            PlayerPrefs.SetInt("hatnormal", valueNormal);

        }

    }

    //Gorrito Morado
    public void activeCapPurple()
    {
        valuePurple = acCapPurple ? 1 : 0;

        acCapBlack = desactiveCap;
        acCapOrange = desactiveCap;
        acCapPurple = activeCap;
        acCapWhite = desactiveCap;
        acHatBlack = desactiveCap;
        acHatRed = desactiveCap;
        acHatNormal = desactiveCap;

        capBlack.SetActive(acCapBlack);
        //Desactivadas
        capOrange.SetActive(acCapOrange);
        capPurple.SetActive(acCapPurple);
        capWhite.SetActive(acCapWhite);
        hatBlack.SetActive(acHatBlack);
        hatRed.SetActive(acHatRed);
        hatNormal.SetActive(acHatNormal);

        //PlayerPrefs Save

        if (acCapPurple == true)
        {
            valuePurple = 1;
            PlayerPrefs.SetInt("cappurple", valuePurple);
        }
        else
        {
            valuePurple = 0;
        }

        valueBlack = acCapBlack ? 1 : 0;
        acCapBlack = false;

        if (acCapBlack == false && acCapOrange == false && acCapWhite == false && acHatBlack == false && acHatRed == false && acHatNormal == false)
        {
            valueBlack = 0;
            valueOrange = 0;
            valueWhite = 0;
            valueHatBlack = 0;
            valueHatRed = 0;
            valueNormal = 0;

            PlayerPrefs.SetInt("capblack", valueBlack);
            PlayerPrefs.SetInt("caporange", valueOrange);
            PlayerPrefs.SetInt("capwhite", valueWhite);
            PlayerPrefs.SetInt("hatblack", valueHatBlack);
            PlayerPrefs.SetInt("hatred", valueHatRed);
            PlayerPrefs.SetInt("hatnormal", valueNormal);

        }

    }

    //Gorrito Blanco
    public void activeCapWhite()
    {
        valueWhite = acCapWhite ? 1 : 0;

        acCapBlack = desactiveCap;
        acCapOrange = desactiveCap;
        acCapPurple = desactiveCap;
        acCapWhite = activeCap;
        acHatBlack = desactiveCap;
        acHatRed = desactiveCap;
        acHatNormal = desactiveCap;

        capBlack.SetActive(acCapBlack);
        //Desactivadas
        capOrange.SetActive(acCapOrange);
        capPurple.SetActive(acCapPurple);
        capWhite.SetActive(acCapWhite);
        hatBlack.SetActive(acHatBlack);
        hatRed.SetActive(acHatRed);
        hatNormal.SetActive(acHatNormal);

        //PlayerPrefs Save

        if (acCapWhite == true)
        {
            valueWhite = 1;
            PlayerPrefs.SetInt("capwhite", valueWhite);
        }
        else
        {
            valueWhite = 0;
        }
      
        if (acCapBlack == false && acCapOrange == false && acCapPurple == false && acHatBlack == false && acHatRed == false && acHatNormal == false)
        {
            valueBlack = 0;
            valueOrange = 0;
            valuePurple = 0;
            valueHatBlack = 0;
            valueHatRed = 0;
            valueNormal = 0;

            PlayerPrefs.SetInt("capblack", valueBlack);
            PlayerPrefs.SetInt("caporange", valueOrange);
            PlayerPrefs.SetInt("cappurple", valuePurple);
            PlayerPrefs.SetInt("hatblack", valueHatBlack);
            PlayerPrefs.SetInt("hatred", valueHatRed);
            PlayerPrefs.SetInt("hatnormal", valueNormal);
        }

    }

    //Gorrita Negra
    public void activeHatBlack()
    {
        valueHatBlack = acHatBlack ? 1 : 0;

        acCapBlack = desactiveCap;
        acCapOrange = desactiveCap;
        acCapPurple = desactiveCap;
        acCapWhite = desactiveCap;
        acHatBlack = activeCap;
        acHatRed = desactiveCap;
        acHatNormal = desactiveCap;

        capBlack.SetActive(acCapBlack);
        //Desactivadas
        capOrange.SetActive(acCapOrange);
        capPurple.SetActive(acCapPurple);
        capWhite.SetActive(acCapWhite);
        hatBlack.SetActive(acHatBlack);
        hatRed.SetActive(acHatRed);
        hatNormal.SetActive(acHatNormal);

        //PlayerPrefs Save

        if (acHatBlack == true)
        {
            valueHatBlack = 1;
            PlayerPrefs.SetInt("hatblack", valueHatBlack);
        }
        else
        {
            valueHatBlack = 0;
        }

        if (acCapBlack == false && acCapOrange == false && acCapPurple == false && acCapWhite == false && acHatRed == false && acHatNormal == false)
        {
            valueBlack = 0;
            valueOrange = 0;
            valuePurple = 0;
            valueWhite = 0;
            valueHatRed = 0;
            valueNormal = 0;

            PlayerPrefs.SetInt("capblack", valueBlack);
            PlayerPrefs.SetInt("caporange", valueOrange);
            PlayerPrefs.SetInt("cappurple", valuePurple);
            PlayerPrefs.SetInt("capwhite", valueWhite);
            PlayerPrefs.SetInt("hatred", valueHatRed);
            PlayerPrefs.SetInt("hatnormal", valueNormal);
        }

    }

    //Gorrita Roja
    public void activeHatRed()
    {
        valueHatRed = acHatRed ? 1 : 0;

        acCapBlack = desactiveCap;
        acCapOrange = desactiveCap;
        acCapPurple = desactiveCap;
        acCapWhite = desactiveCap;
        acHatBlack = desactiveCap;
        acHatRed = activeCap;
        acHatNormal = desactiveCap;

        capBlack.SetActive(acCapBlack);
        //Desactivadas
        capOrange.SetActive(acCapOrange);
        capPurple.SetActive(acCapPurple);
        capWhite.SetActive(acCapWhite);
        hatBlack.SetActive(acHatBlack);
        hatRed.SetActive(acHatRed);
        hatNormal.SetActive(acHatNormal);

        //PlayerPrefs Save

        if (acHatRed == true)
        {
            valueHatRed = 1;
            PlayerPrefs.SetInt("hatred", valueHatRed);
        }
        else
        {
            valueHatRed = 0;
        }

        if (acCapBlack == false && acCapOrange == false && acCapPurple == false && acCapWhite == false && acHatBlack == false && acHatNormal == false)
        {
            valueBlack = 0;
            valueOrange = 0;
            valuePurple = 0;
            valueWhite = 0;
            valueHatBlack = 0;
            valueNormal = 0;

            PlayerPrefs.SetInt("capblack", valueBlack);
            PlayerPrefs.SetInt("caporange", valueOrange);
            PlayerPrefs.SetInt("cappurple", valuePurple);
            PlayerPrefs.SetInt("capwhite", valueWhite);
            PlayerPrefs.SetInt("hatblack", valueHatBlack);
            PlayerPrefs.SetInt("hatnormal", valueNormal);
        }

    }

    //Gorrita Geek
    public void activeHatNormal()
    {
        valueNormal = acHatNormal ? 1 : 0;

        acCapBlack = desactiveCap;
        acCapOrange = desactiveCap;
        acCapPurple = desactiveCap;
        acCapWhite = desactiveCap;
        acHatBlack = desactiveCap;
        acHatRed = desactiveCap;
        acHatNormal = activeCap;

        capBlack.SetActive(acCapBlack);
        //Desactivadas
        capOrange.SetActive(acCapOrange);
        capPurple.SetActive(acCapPurple);
        capWhite.SetActive(acCapWhite);
        hatBlack.SetActive(acHatBlack);
        hatRed.SetActive(acHatRed);
        hatNormal.SetActive(acHatNormal);

        //PlayerPrefs Save

        if (acHatNormal == true)
        {
            valueNormal = 1;
            PlayerPrefs.SetInt("hatnormal", valueNormal);
        }
        else
        {
            valueNormal = 0;
        }

        if (acCapBlack == false && acCapOrange == false && acCapPurple == false && acCapWhite == false && acHatBlack == false && acHatRed == false)
        {
            valueBlack = 0;
            valueOrange = 0;
            valuePurple = 0;
            valueWhite = 0;
            valueHatBlack = 0;
            valueHatRed = 0;

            PlayerPrefs.SetInt("capblack", valueBlack);
            PlayerPrefs.SetInt("caporange", valueOrange);
            PlayerPrefs.SetInt("cappurple", valuePurple);
            PlayerPrefs.SetInt("capwhite", valueWhite);
            PlayerPrefs.SetInt("hatblack", valueHatBlack);
            PlayerPrefs.SetInt("hatred", valueHatRed);
        }

    }

    //Sin gorrito
    public void capOut()
    {
        valueBlack = acCapBlack ? 1 : 0;
        valueOrange = acCapOrange ? 1 : 0;
        valuePurple = acCapPurple ? 1 : 0;
        valueWhite = acCapWhite ? 1 : 0;
        valueHatBlack = acHatBlack ? 1 : 0;
        valueHatRed = acHatRed ? 1 : 0;
        valueNormal = acHatNormal ? 1 : 0;

        acCapBlack = desactiveCap;
        acCapOrange = desactiveCap;
        acCapPurple = desactiveCap;
        acCapWhite = desactiveCap;
        acHatBlack = desactiveCap;
        acHatRed = desactiveCap;
        acHatNormal = desactiveCap;

        capBlack.SetActive(acCapBlack);
        //Desactivadas
        capOrange.SetActive(acCapOrange);
        capPurple.SetActive(acCapPurple);
        capWhite.SetActive(acCapWhite);
        hatBlack.SetActive(acHatBlack);
        hatRed.SetActive(acHatRed);
        hatNormal.SetActive(acHatNormal);

        //PlayerPrefs Save   

        if (acCapBlack == false && acCapOrange == false && acCapPurple == false && acCapWhite == false && acHatBlack == false && acHatRed == false && acHatNormal == false)
        {
            valueNormal = 0;
            valueBlack = 0;
            valueOrange = 0;
            valuePurple = 0;
            valueWhite = 0;
            valueHatBlack = 0;
            valueHatRed = 0;

            PlayerPrefs.SetInt("capblack", valueBlack);
            PlayerPrefs.SetInt("caporange", valueOrange);
            PlayerPrefs.SetInt("cappurple", valuePurple);
            PlayerPrefs.SetInt("capwhite", valueWhite);
            PlayerPrefs.SetInt("hatblack", valueHatBlack);
            PlayerPrefs.SetInt("hatred", valueHatRed);
            PlayerPrefs.SetInt("hatnormal", valueNormal);

        }

    }


}
