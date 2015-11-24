using UnityEngine;
using System.Collections;

public class TowerShoot : MonoBehaviour {

	[SerializeField] private GameObject _bullet;

    private TowerTarget _towerTarget;

    

    private float _cooldown = 1f;
    private float _cooldownTimer;

	void Start () 
	{
        _towerTarget = GetComponent<TowerTarget>();  
        
	}

	void Update () 
	{
        if (_towerTarget.GetTarget() != null)
        {
            if(_cooldownTimer <= Time.time)
            {
                Shoot();
            }
        }

	}

	private void Shoot()
	{
		GameObject bullet = Instantiate (_bullet, this.transform.position, Quaternion.identity) as GameObject;
        bullet.GetComponent<BulletMovement>().SetTargetPosition(_towerTarget.GetTarget().transform.position);
		bullet.transform.SetParent (this.transform);
        _cooldownTimer = Time.time + _cooldown;
	}
}
