using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyberPlayer : MonoBehaviour
{
    public GameObject _Kid;    
    public GameObject _glass;
    public GameObject _Glass_frame;   
    public GameObject _pant;   
    public GameObject _tshirt;

    public void SavePlayer()
    {
        CyberSaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        CyberPlayerData data = CyberSaveSystem.LoadPlayer();

        data._Kid = _Kid;
        data._glass = _glass;
        data._Glass_frame = _Glass_frame;
        data._pant = _pant;
        data._tshirt = _tshirt;
    }
}
