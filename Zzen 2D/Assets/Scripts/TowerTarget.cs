using UnityEngine;
using System.Collections;

public class TowerTarget : MonoBehaviour {

	private GameObject _target;
	[SerializeField] private float _targettingRadius;

	private int _layerMask;

	void Start()
	{
		_layerMask = LayerMask.GetMask ("Enemy");
	}
		
	void Update () 
	{
		Collider2D col = Physics2D.OverlapCircle (this.transform.position, _targettingRadius, _layerMask);
		Debug.Log (col);
	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.white;
		Gizmos.DrawWireSphere (this.transform.position, _targettingRadius);
	}
}
