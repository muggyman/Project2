using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winScreen; //win
    public GameObject loseScreen1; //eat butterfly
    public GameObject loseScreen2; //empty energy bar
    public GameObject UI;

    private int flyAmt;
    private int bFlyAmt;

    void Start()
    {
        HideWinScreen();
        HideloseScreen1();
        HideloseScreen2();

        UI.SetActive(true);

        //Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void ShowWinScreen()
    {
        winScreen.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void ShowLoseScreen1()
    {
        loseScreen1.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void ShowLoseScreen2()
    {
        loseScreen2.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void HideWinScreen()
    {
        winScreen.SetActive(false);
    }

    public void HideloseScreen1()
    {
        loseScreen1.SetActive(false);
    }

    public void HideloseScreen2()
    {
        loseScreen2.SetActive(false);
    }

}
