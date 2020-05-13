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
    }

    // Update is called once per frame
    void Update()
    {
        moneyAmountText.text = "Puntaje:" + moneyAmount.ToString() + "$";
        if(moneyAmount >= 100)
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
        if (btnGlassesBack != null)
        {
            moneyAmount -= 100;
            bool isActive = btnGlassesBack.activeSelf;
            btnGlassesBack.SetActive(true);
            btnBuyGlassWhite.gameObject.SetActive(false);
        }
    }

    public void buyGlassesBlack()
    {
        if (btnGlassesBlack != null)
        {
            moneyAmount -= 100;
            bool isActive = btnGlassesBlack.activeSelf;
            btnGlassesBlack.SetActive(true);
            btnBuyGlassBlack.gameObject.SetActive(false);

        }
    }

    public void buyGlassesBlue()
    {
        if (btnGlasses != null)
        {
            moneyAmount -= 100;
            bool isActive = btnGlasses.activeSelf;
            btnGlasses.SetActive(true);
            btnBuyGlassBlue.gameObject.SetActive(false);

        }
    }
}
