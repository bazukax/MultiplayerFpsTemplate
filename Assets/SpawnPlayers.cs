using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform[] spawnPositions;
    void Start()
    {
        PhotonNetwork.Instantiate(playerPrefab.name, spawnPositions[Random.Range(0, spawnPositions.Length)].position, Quaternion.identity);
    }
    
}
