using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    private int _health = 10;

    [SerializeField] private Image _healthbar;

    public void TakeDamage()
    {
        if (_health <= 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _health--;
            _healthbar.fillAmount -= 0.1f;
        }

    }
}
