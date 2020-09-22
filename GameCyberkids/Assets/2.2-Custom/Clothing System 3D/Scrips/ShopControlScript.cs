using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopControlScript : MonoBehaviour {
    /*
        int moneyAmount;
        int isGlassesBlackSold;
        int isGlassesWhiteSold;
        int isGlassesBlueSold;


        public Text moneyAmountText;
        public Text glassesBlackPrice;
        public Text glassesBluePrice;
        public Text glassesWhitePrice;


        public Button buyButtonGB;
        public Button buyButtonGBlue;
        public Button buyButtonGW;

    */

    static public bool acGlassWhite;
    static public bool acGlassBlack;
    static public bool acGlassBlue;

    static public int valueGlassWhite;
    static public int valueGlassBlack;
    static public int valueGlassBlue;

        
       


    int moneyAmount;
    public Text moneyAmountText;   
    
    public GameObject btnGlassesBack;
    public GameObject btnGlassesBlack;
    public GameObject btnGlasses;

    public GameObject btnBuyGlassWhite;
    public GameObject btnBuyGlassBlack;
    public GameObject btnBuyGlassBlue;


    // Start is called before the first frame update
    void Start()
    {
        moneyAmount = 290;

        acGlassWhite = (PlayerPrefs.GetInt("acglasswhite") != 0); ;
        acGlassBlack = (PlayerPrefs.GetInt("acglassblack") != 0); ;
        acGlassBlue = (PlayerPrefs.GetInt("acglassblue") != 0); ;

        btnGlassesBack.SetActive(acGlassWhite);
        btnGlassesBlack.SetActive(acGlassBlack);
        btnGlasses.SetActive(acGlassBlue);

    }

    // Update is called once per frame
    void Update()
    {
        moneyAmountText.text = "Puntaje:" + moneyAmount.ToString() + "$";
        if(ScoreScript.scoreValue >= 100)
        {
            /* btnBuyGlassWhite.interactable = true;
             btnBuyGlassBlack.interactable = true;
             btnBuyGlassBlue.interactable = true;*/
            btnBuyGlassWhite.gameObject.SetActive(true);
            btnBuyGlassBlack.gameObject.SetActive(true);
            btnBuyGlassBlue.gameObject.SetActive(true);


        }
        else
        {
            /*btnBuyGlassWhite.interactable = false;
            btnBuyGlassBlack.interactable = false;
            btnBuyGlassBlue.interactable = false;*/
            btnBuyGlassWhite.gameObject.SetActive(false);
            btnBuyGlassBlack.gameObject.SetActive(false);
            btnBuyGlassBlue.gameObject.SetActive(false);

        }
    }

    public void buyGlassesWhite()
    {
        valueGlassWhite = acGlassWhite ? 1 : 0;
       

        if (btnGlassesBack != null)
        {
            ScoreScript.scoreValue -= 100;
            bool isActive = btnGlassesBack.activeSelf;
            btnGlassesBack.SetActive(true);
            //PlayerPrefs
            valueGlassWhite = 1;
            PlayerPrefs.SetInt("acglasswhite", valueGlassWhite);
            //PlayerPrefs
            btnBuyGlassWhite.gameObject.SetActive(false);
        }
    }

    public void buyGlassesBlack()
    {
        valueGlassBlack = acGlassBlack ? 1 : 0;

        if (btnGlassesBlack != null)
        {
            ScoreScript.scoreValue -= 100;
            bool isActive = btnGlassesBlack.activeSelf;
            btnGlassesBlack.SetActive(true);
            //PlayerPrefs
            valueGlassBlack = 1;
            PlayerPrefs.SetInt("acglassblack", valueGlassBlack);
            //PlayerPrefs
            btnBuyGlassBlack.gameObject.SetActive(false);

        }
    }

    public void buyGlassesBlue()
    {       
        valueGlassBlue = acGlassBlue ? 1 : 0;

        if (btnGlasses != null)
        {
            ScoreScript.scoreValue -= 100;
            bool isActive = btnGlasses.activeSelf;
            btnGlasses.SetActive(true);
            //PlayerPrefs
            valueGlassBlue = 1;
            PlayerPrefs.SetInt("acglassblue", valueGlassBlue);
            //PlayerPrefs
            btnBuyGlassBlue.gameObject.SetActive(false);

        }
    }
}
