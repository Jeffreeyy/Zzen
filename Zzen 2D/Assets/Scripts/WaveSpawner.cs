using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[System.Serializable]
public class WaveInfo
{
    public List<GameObject> waveInfo;
}


public class WaveSpawner : MonoBehaviour {

    private int _waveCounter = 0;

    public bool waveIsActive = false;

    public List<WaveInfo> waves = new List<WaveInfo>();

    public void SpawnEnemies()
    {
        if (waveIsActive == false)
        {
            waveIsActive = true;
            GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>().SpawnEnemy(waves[_waveCounter].waveInfo);
            _waveCounter++;
        }
    }

   
}
