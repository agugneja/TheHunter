using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void StartGame() {
        //load game
        SceneManager.LoadScene(1);
    }

    public void QuitGame() {
        //quit game
        Application.Quit();
    }

    public void MainMenu() {
        //load main menu
        SceneManager.LoadScene(0);
    }
}
