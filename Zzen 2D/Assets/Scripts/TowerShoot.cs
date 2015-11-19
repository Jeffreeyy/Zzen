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
        if (_towerTarget.GetTarget())
        {
            Debug.Log("Ik heb een target:" + gameObject.name);

            if(_cooldownTimer <= Time.time)
            {
                Debug.Log("Ik schiet nu!");
                Shoot();
            }
        }

	}

	private void Shoot()
	{
		GameObject bullet = Instantiate (_bullet, this.transform.position, Quaternion.identity) as GameObject;
        //Rigidbody2D rb2d = bullet.GetComponent<Rigidbody2D>();
		bullet.transform.SetParent (this.transform);
        _cooldownTimer = Time.time + _cooldown;

        bullet.transform.position = Vector2.MoveTowards(this.transform.position, _towerTarget.target.transform.position, 10f * Time.deltaTime);
        //_towerTarget.target.transform.Translate(new Vector3(1f, 2f, 0f));
	}
}
