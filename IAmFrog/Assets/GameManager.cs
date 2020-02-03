using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject endScreen;
    public GameObject UI;

    void Start()
    {
        hideEndScreen();

        UI.SetActive(true);
    }

    public void EndGame()
    {
        endScreen.SetActive(true);
    }

    public void hideEndScreen()
    {
        endScreen.SetActive(false);
    }
}
