using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    public int normalHealth;
    private int _health;
    [SerializeField]
    private int _amountOfSeedsDropped = 10;

    [SerializeField] private Image _healthbar;

    void Awake()
    {
        _health = normalHealth;
    }

    public void TakeDamage()
    {
        if (_health <= 1)
        {
            Destroy(this.gameObject);
            GameObject.Find("Main Camera").GetComponent<PlayerController>().seeds += _amountOfSeedsDropped;
        }
        else
        {
            _health--;
            switch(normalHealth)
            {
                case 5:
                    _healthbar.fillAmount -= 0.2f;
                    break;
                case 10:
                    _healthbar.fillAmount -= 0.1f;
                    break;

            }

            
        }

    }

   void OnDestroy()
    {
            GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>().enemiesSpawned.Remove(this.gameObject);
    }
}
