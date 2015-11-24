using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LivesPlayer : MonoBehaviour {

    [SerializeField]
    private GameObject _button;

    public  float lives = 10;

    private Text text;

	void Start () {
        text = _button.GetComponent<Text>();
        text.text = ("Lives: " + lives);
    }

    public void LivesMin(int amount)
    {
        lives--;
        text.text = ("Lives: " + lives);
    }
}