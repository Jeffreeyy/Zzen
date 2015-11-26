using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	private Rigidbody2D _rb2d;
	private int _targetedWaypoint = 0;
	private Transform _waypoints;
    private float _offset = 2f;
    [SerializeField] private float _movementSpeed = 4f;
    [SerializeField] private LivesPlayer button;

	void Start () 
	{
		_rb2d = GetComponent<Rigidbody2D> ();
		_waypoints = GameObject.Find("Waypoints").transform;
        //button = GameObject.Find("LivesText").GetComponent<LivesPlayer>();
	}
	

	void FixedUpdate () 
	{
		WaypointHandler ();
	}

	private void WaypointHandler()
	{
		Transform targetWaypoint = _waypoints.GetChild(_targetedWaypoint);
		Vector3 relative = (targetWaypoint.position + new Vector3(0,_offset,0)) - transform.position;
		Vector3 movementNormal = Vector3.Normalize(relative);
		float distanceToWaypoint = relative.magnitude;

		if(distanceToWaypoint < 0.1)
		{
			if(_targetedWaypoint + 1 < _waypoints.childCount)
			{
				_targetedWaypoint++;
			}
		}
		else
		{
			_rb2d.AddForce(new Vector2(movementNormal.x, movementNormal.y) * _movementSpeed);
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "Finish")
		{
            button.LivesMin(1);
			Destroy(gameObject);
		}
	}
}
