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
            GameObject.Find("Main Camera").GetComponent<PlayerController>().seeds += 25;
        }
        else
        {
            _health--;
            _healthbar.fillAmount -= 0.1f;
        }

    }

   void OnDestroy()
    {
        if (Application.loadedLevelName == "GameWithArt")
        {
            GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>().enemiesSpawned.Remove(this.gameObject);
        }
    }
}
