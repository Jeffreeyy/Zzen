using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

    private Vector2 _targetPosition;
    private float _bulletLifeTime;

	void FixedUpdate () 
    {
        MoveBullet();
        _bulletLifeTime += 1f * Time.deltaTime;
    }

    public void SetTargetPosition(Vector2 position)
    {
        _targetPosition = position;
    }

    private void MoveBullet()
    {
        this.transform.position = Vector2.MoveTowards(this.transform.position, _targetPosition, 15f * Time.deltaTime);

        if(_bulletLifeTime >= 1f)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.GetComponent<EnemyController>().TakeDamage();
            Destroy(this.gameObject);
        }
    }
}
