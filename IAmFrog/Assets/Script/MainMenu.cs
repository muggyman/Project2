using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject controlUI;
    public GameObject InstructionsUI;

    public void PlayGame()
    {
        SceneManager.LoadScene("Level");
    }

    public void Controls()
    {
        controlUI.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void Instructions()
    {
        InstructionsUI.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
