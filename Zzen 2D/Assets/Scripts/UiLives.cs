using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UiLives : MonoBehaviour {

            Text _text;
    [SerializeField]
            int _lives = 10;


	void Start () {
        _text = GetComponent<Text>();
        _text.text = "Lives: " + _lives.ToString();
    }

    public void DownLives()
    {
        _lives -= 1;
        _text.text = "Lives: " + _lives.ToString(); 
    }
}
