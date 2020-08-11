using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetClickerFour : MonoBehaviour
{
    public GameObject PanelTargetFour;
    static public bool activePanelFour;
    [SerializeField] public QuizManagerT2 quizManT2;
    public GameObject target4;

  
    public void OpenTargetFour()
    {
        if (PanelTargetFour != null)
        {
            bool isActive = PanelTargetFour.activeSelf;
            PanelTargetFour.SetActive(true);
            activePanelFour = true;
        }

        target4.SetActive(false);
        quizManT2.StartGame(0);

        ObjetiveControl.contTargets += 1;
        ScoreScript.scoreValue += 10;

    }

    void OnMouseDown()
    {
        OpenTargetFour();
    }
}
