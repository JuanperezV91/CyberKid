using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData : MonoBehaviour
{

    public GameObject jugador;
    

    public PlayerData (Player player)
    {
        jugador = player.jugador; 
    }
  
}
