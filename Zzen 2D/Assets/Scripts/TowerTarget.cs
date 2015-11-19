using UnityEngine;
using System.Collections;

public class TowerTarget : MonoBehaviour {

	public GameObject target;
	[SerializeField] private float _targettingRadius;
    private float _closestTargetDistance;

	private int _layerMask;

	void Start()
	{
		_layerMask = LayerMask.GetMask ("Enemy");
	}
		
	void Update () 
	{
		Collider2D[] col = Physics2D.OverlapCircleAll (this.transform.position, _targettingRadius, _layerMask);
        if (col != null)
        {
            Collider2D closestEnemy = null;
            float closestDistance = -1f;

            for (int i = 0; i < col.Length; i++)
            {
                if (col[i].tag == "Enemy")
                {
                    Debug.Log(col[i].name);
                    float dist = Vector2.Distance(col[i].transform.position, this.transform.position);
                    if(closestDistance == -1f)
                    {
                        closestDistance = dist;
                        closestEnemy = col[i];
                    }
                    else
                    {
                        if(dist < closestDistance)
                        {
                            closestEnemy = col[i];
                            closestDistance = dist;
                        }
                    }
                    //Debug.Log(col[i].name + ":" + dist);


                    if (closestEnemy != null)
                    {
                        target = closestEnemy.transform.gameObject;
                    }

                }
                
                
               // _target = col.transform.gameObject;
            }
           
        }
	}

    public GameObject GetTarget()
    {
        if (target)
            return target;
        else
            return null;
    }

	void OnDrawGizmos()
	{
		Gizmos.color = Color.white;
		Gizmos.DrawWireSphere (this.transform.position, _targettingRadius);
	}
}
