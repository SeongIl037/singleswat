using System;
using UnityEngine;
using System.Collections.Generic;
public class SpawnManager : MonoBehaviour
{
    private GameObject _player;
    
    public List<Transform> SpawnPoints;
    private int _spawnPointIndex;
    
    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _spawnPointIndex = StageManger.Instance.RespawnPoint;
        
        Spawn();
    }

    private void Spawn()
    {
        _player.transform.position = SpawnPoints[_spawnPointIndex].position;
    }   
}
