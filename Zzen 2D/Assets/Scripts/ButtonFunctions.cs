using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonFunctions : MonoBehaviour {

    public void LoadGame()
    {
            Application.LoadLevel("Game");
    }

    public void ToAboutMenu()
    {
            Application.LoadLevel("Aboutscene");
    }

    public void ToMainMenu()

    {
        Application.LoadLevel("MainMenu");
    }
}
