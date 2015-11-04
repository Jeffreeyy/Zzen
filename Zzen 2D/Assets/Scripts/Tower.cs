using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour {

	public GameObject towerPrefab;
	private GameObject _tower;

	void Start () {
		this.gameObject.SetActive (true);
	}

	private bool canPlaceTower()
	{
		return _tower == null;
	}

	void OnMouseUp()
	{
		if(canPlaceTower())
		{
			_tower = (GameObject)
			Instantiate(towerPrefab, transform.position, Quaternion.identity);
			this.gameObject.SetActive(false);
		}
	}
}
