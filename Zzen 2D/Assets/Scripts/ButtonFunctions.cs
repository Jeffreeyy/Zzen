using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonFunctions : MonoBehaviour {

    private GameObject pauseButton;

    void Start()
    {
        if (Application.loadedLevel == 3)
        {
            pauseButton = GameObject.Find("PauseMenu");
            pauseButton.SetActive(false);
        }
    }
    public void LoadGame()
    {
            Application.LoadLevel("GameWithArt");
    }

    public void ToAboutMenu()
    {
            Application.LoadLevel("Aboutscene");
    }

    public void ToMainMenu()
    {
        Application.LoadLevel("MainMenu");
    }

    public void PauseMenu()
    {
        Time.timeScale = 0;
        pauseButton.SetActive(true);
    }

    public void HideMenu()
    {
        Time.timeScale = 1;
        pauseButton.SetActive(false);
    }
}
