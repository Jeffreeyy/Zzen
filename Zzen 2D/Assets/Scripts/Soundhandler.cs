using UnityEngine;
using System.Collections;

public class Soundhandler : MonoBehaviour {

    private GameObject _audioHandler;
    private AudioSource _main_Tune;
    private AudioSource _main_Menu_Tune;
    private AudioSource _Ambiance_Sound;

	// Use this for initialization
	void Start () {

        if (Application.loadedLevelName == "GameWithArt")
        {
            _main_Tune = GameObject.Find("Main_Tune").GetComponent<AudioSource>();
            PlayMain_Tune();
        }

        if (Application.loadedLevelName == "MainMenu" || Application.loadedLevelName == "AboutScene")
        {
            _main_Menu_Tune = GameObject.Find("Main_Menu_Amb").GetComponent<AudioSource>(); ;
            _Ambiance_Sound = GameObject.Find("Main_Menu_Tune").GetComponent<AudioSource>(); ;
            PlayMain_Menu_Tunes();
        }
    }

	void Update () {
	
	}

    public void PlayMain_Tune()
    {
        _main_Tune.Play();
    }

    public void PlayMain_Menu_Tunes()
    {
        _Ambiance_Sound.Play();
        _main_Menu_Tune.Play();
    }
}
