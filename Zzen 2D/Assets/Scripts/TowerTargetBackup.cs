using UnityEngine;
using System.Collections;

public class TowerTargetBackup : MonoBehaviour
{

    [SerializeField]
    private float _targettingRadius;

    private int _layerMask;

    void Start()
    {
        _layerMask = LayerMask.GetMask("Enemy");
    }

    public Vector3 GetTarget() {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, _targettingRadius, _layerMask);
        GameObject target = null;
        float closestDistance = int.MaxValue;
        foreach (Collider2D coll in colliders)
        {
            float distance = Vector3.Distance(transform.position, coll.transform.position);
            if (distance < closestDistance)
            {
                target = coll.gameObject;
                closestDistance = distance;

            }
        }
        return target.transform.position;
    }
  
    void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(this.transform.position, _targettingRadius);
    }
}
