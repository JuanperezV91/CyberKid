using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ProgressBarSec : MonoBehaviour
{
    [SerializeField] Slider progressBar;
    [SerializeField] Text levelTier;

    [SerializeField] int maxTier = 6; //max amount per tier, always set this value to the visual bar + 1
    [SerializeField] int statValue = ControlObjAns.countSeguridad; //your real progress value

    [SerializeField] Button addBtnObj1, addBtnObj2, addBtnObj3, addBtnObj4, addBtnObj5, addBtnObj6;

    // Start is called before the first frame update
    void Start()
    {
        UpdateProgressBar();

        addBtnObj1.onClick.AddListener(IncreaseProgress);
        addBtnObj2.onClick.AddListener(IncreaseProgress);
        addBtnObj3.onClick.AddListener(IncreaseProgress);
        addBtnObj4.onClick.AddListener(IncreaseProgress);
        addBtnObj5.onClick.AddListener(IncreaseProgress);
        addBtnObj6.onClick.AddListener(IncreaseProgress);

        //subBtn.onClick.AddListener(DecreaseProgress);
    }

    void Update()
    {
        if (statValue >= 0 && statValue <= 2)
        {
            levelTier.text = "Sin Seguridad";
        }
        else 
            if (statValue >= 3 && statValue <= 4)
        {
            levelTier.text = "Seguridad Media";
        }
        else
            if (statValue >= 5 && statValue <= 6)
        {
            levelTier.text = "CiberSeguro";
        }
    }

    //Method for updating the progress bar based on the real progress value (statValue)
    private void UpdateProgressBar()
    {
        progressBar.value = statValue % maxTier; //Increase the bar value using modulo, so it resets when reach the max tier amount
      //  levelTier.text = Mathf.Floor(statValue / ((float)maxTier)).ToString(); //Use floor operation to define our current tier
    }

    //Method for increasing progress
    void IncreaseProgress()
    {
        statValue++;
        UpdateProgressBar();
    }

   /* //Method for decreasing progress, and clamp the value, so it doesn't go below the minimum value (in this case 0)
    void DecreaseProgress()
    {
        statValue--;
        statValue = Mathf.Clamp(statValue, 0, int.MaxValue);
        UpdateProgressBar();
    }
    */




    //progress bar por niveles
    /*
      [SerializeField] Slider progressBar;
    [SerializeField] Text levelTier;

    [SerializeField] int maxTier = 6; //max amount per tier, always set this value to the visual bar + 1
    [SerializeField] int statValue = ControlObjAns.countSeguridad; //your real progress value

    [SerializeField] Button addBtn, subBtn;

    // Start is called before the first frame update
    void Start()
    {
        UpdateProgressBar();

        addBtn.onClick.AddListener(IncreaseProgress);
        subBtn.onClick.AddListener(DecreaseProgress);
    }

    //Method for updating the progress bar based on the real progress value (statValue)
    private void UpdateProgressBar()
    {
        progressBar.value = statValue % maxTier; //Increase the bar value using modulo, so it resets when reach the max tier amount
        levelTier.text = Mathf.Floor(statValue / ((float)maxTier)).ToString(); //Use floor operation to define our current tier
    }

    //Method for increasing progress
    void IncreaseProgress()
    {
        statValue++;
        UpdateProgressBar();
    }

    //Method for decreasing progress, and clamp the value, so it doesn't go below the minimum value (in this case 0)
    void DecreaseProgress()
    {
        statValue--;
        statValue = Mathf.Clamp(statValue, 0, int.MaxValue);
        UpdateProgressBar();
    }
     */
}