using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LivesPlayer : MonoBehaviour {

    [SerializeField]
    private GameObject _button;

    static public float lives = 10;

    private Text text;

	void Start () {
        text = _button.GetComponent<Text>();
        text.text = ("Lives: " + lives);
    }

    void Update()
    {
        if (lives <= 0)
        {
            Application.LoadLevel("GameOver");
        }
    }

    public void LivesMin(int amount)
    {
        lives -= amount;
        text.text = ("Lives: " + lives);
    }
}