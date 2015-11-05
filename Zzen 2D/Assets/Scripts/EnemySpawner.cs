using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemyPrefab;

	public void SpawnEnemy()
	{
		Instantiate(enemyPrefab, transform.position, Quaternion.identity);
	}
}
