using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour {

	[SerializeField] private GameObject _towerPrefab;
	private GameObject _tower;

	void Start () {
		//this.gameObject.SetActive (true);
	}

	private bool canPlaceTower()
	{
		return _tower == null;
	}

	void OnMouseUp()
	{
		Vector2 temp = transform.position;
		if(canPlaceTower())
		{
            _tower = (GameObject)
			Instantiate(_towerPrefab, transform.position, Quaternion.identity);
			//this.gameObject.SetActive(false);

		}
	}
}
