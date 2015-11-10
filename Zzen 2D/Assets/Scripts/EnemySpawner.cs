using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	[SerializeField] private GameObject[] _enemies;
	private float _spawnDistanceBetween = 5f;


	public void SpawnEnemy()
	{
		Vector2 spawnLocation = transform.position;
		for(int i = 0; i < _enemies.Length; i++)
		{

			GameObject obj = Instantiate (_enemies[i], spawnLocation, Quaternion.identity) as GameObject;
			obj.transform.SetParent (this.transform);

			spawnLocation.y += _spawnDistanceBetween;
		}
	}
}
