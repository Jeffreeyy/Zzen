using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TowerSpawner : MonoBehaviour {

    [SerializeField] private GameObject PlayerStats;
	[SerializeField] private GameObject _towerPrefab;
    [SerializeField] private Text _updateText;
	private GameObject _tower;
    private bool _isUpdatingText = false;

	private bool canPlaceTower()
	{
		return _tower == null;
	}

	void OnMouseUp()
	{
		if(canPlaceTower())
		{
            if (PlayerStats.GetComponent<PlayerController>().seeds >= 50)
            {            
                _tower = (GameObject)
			    Instantiate(_towerPrefab, transform.position, Quaternion.identity);
                PlayerStats.GetComponent<PlayerController>().seeds -= 50;
            }
            else
            {
                if (_isUpdatingText == false)
                {
                    StartCoroutine(EditUpdateText());
                }
            }

		}
	}

    IEnumerator EditUpdateText()
    {
        _isUpdatingText = true;
        _updateText.text = "Not enough seeds! You need 50 seeds to plant!";
        yield return new WaitForSeconds(3);
        _updateText.text = " ";
        _isUpdatingText = false;
    }
}
