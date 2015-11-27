using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour {

    [SerializeField]
    private Text _updateText;
	private float _spawnDistanceBetween = 5f;
    public List<GameObject> enemiesSpawned = new List<GameObject>();
    private bool _isUpdatingText = false;

	public void SpawnEnemy(List<GameObject> enemies)
	{
        Vector2 spawnLocation = transform.position;

        for (int i = 0; i < enemies.Count; i++)
        {
            GameObject obj = Instantiate(enemies[i], spawnLocation, Quaternion.identity) as GameObject;
            obj.transform.SetParent(this.transform);
            enemiesSpawned.Add(obj);
            spawnLocation.y += _spawnDistanceBetween;
        }
	}

    void Update()
    {
        if (enemiesSpawned != null)
        {
            if (enemiesSpawned.Count == 0 && GameObject.Find("WaveSystem").GetComponent<WaveSpawner>().waveIsActive == true)
            {
                if (_isUpdatingText == false)
                {
                    StartCoroutine(EditUpdateText());
                }
                GameObject.Find("WaveSystem").GetComponent<WaveSpawner>().waveIsActive = false;
            }
        }
    }

    IEnumerator EditUpdateText()
    {
        _isUpdatingText = true;
        _updateText.text = "Wave Clear!";
        yield return new WaitForSeconds(3);
        _updateText.text = " ";
        _isUpdatingText = false;
    }

}
