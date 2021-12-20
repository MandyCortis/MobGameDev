using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Photon.Pun;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab1;
    public GameObject playerPrefab2;

    void Start()
    {
        //instaniate object and sync to all players in this room
        if (PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.Instantiate(playerPrefab1.name, new Vector3(-6.5f, -1, 1f),
          Quaternion.identity, 1);
            
        }
        else
        {
            PhotonNetwork.Instantiate(playerPrefab2.name, new Vector3(45, -1f, 1f),
          Quaternion.identity, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
