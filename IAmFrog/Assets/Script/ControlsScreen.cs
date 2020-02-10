using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsScreen : MonoBehaviour
{
    public GameObject MainUI;

    public void MainMenu()
    {
        MainUI.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
