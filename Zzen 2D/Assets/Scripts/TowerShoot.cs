using UnityEngine;
using System.Collections;

public class TowerShoot : MonoBehaviour {

	[SerializeField] private GameObject _bullet;

	void Start () 
	{
		Shoot ();
	}

	void Update () 
	{

	}

	private void Shoot()
	{
		GameObject bullet = Instantiate (_bullet, this.transform.position, Quaternion.identity) as GameObject;
		bullet.transform.SetParent (this.transform);
	}
}
