using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	private Rigidbody2D _rb2d;
	private int _targetedWaypoint = 0;
	private Transform _waypoints;

	private float _movementSpeed = 3f;

	void Start () 
	{
		_rb2d = GetComponent<Rigidbody2D> ();
		_waypoints = GameObject.Find("Waypoints").transform;
	}
	

	void FixedUpdate () 
	{
		WaypointHandler ();
		Debug.Log (_targetedWaypoint);
	}

	private void WaypointHandler()
	{
		Transform targetWaypoint = _waypoints.GetChild(_targetedWaypoint);
		Vector3 relative = targetWaypoint.position - transform.position;
		Vector3 movementNormal = Vector3.Normalize(relative);
		float distanceToWaypoint = relative.magnitude;
		float targetAngle = Mathf.Atan2(relative.y, relative.x) * Mathf.Rad2Deg - 90;

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
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, targetAngle), Time.deltaTime * 3f);

		if(_targetedWaypoint == 15f)
		{
			Destroy(this.gameObject.transform.parent.gameObject);
		}
	}
}
