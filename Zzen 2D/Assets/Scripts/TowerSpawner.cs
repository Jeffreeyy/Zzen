using UnityEngine;
using System.Collections;

public class TowerSpawner : MonoBehaviour {

    [SerializeField]private GameObject PlayerStats;
	[SerializeField] private GameObject _towerPrefab;
	private GameObject _tower;

	private bool canPlaceTower()
	{
		return _tower == null;
	}

	void OnMouseUp()
	{
		if(canPlaceTower())
		{
            if (PlayerStats.GetComponent<PlayerController>().seeds >= 50)
            {            
                _tower = (GameObject)
			    Instantiate(_towerPrefab, transform.position, Quaternion.identity);
                PlayerStats.GetComponent<PlayerController>().seeds -= 50;
            }

		}
	}
}
