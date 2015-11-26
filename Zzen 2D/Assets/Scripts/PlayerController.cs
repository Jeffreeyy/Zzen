using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour 
{
    [SerializeField]
    private Text _seedsText;

    public int seeds = 100;

    void Update()
    {
        _seedsText.text = "Seeds: " + seeds;
    }
}
