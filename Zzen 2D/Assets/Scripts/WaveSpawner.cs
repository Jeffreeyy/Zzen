using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


[System.Serializable]
public class WaveInfo
{
    public List<GameObject> waveInfo;
}


public class WaveSpawner : MonoBehaviour {

    [SerializeField]
    private Text _WaveText;

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
            _WaveText.text = "Wave: " + _waveCounter;
        }
    }

   
}
