using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CyberPlayerData
{

    public GameObject _Kid;
    public GameObject _glass;
    public GameObject _Glass_frame;
    public GameObject _pant;
    public GameObject _tshirt;

    public CyberPlayerData (CyberPlayer player)
    {
        player._Kid = _Kid;
        player._glass = _glass;
        player._Glass_frame = _Glass_frame;
        player._pant = _pant;
        player._tshirt = _tshirt;
    }
}
