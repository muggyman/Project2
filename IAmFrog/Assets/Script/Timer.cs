using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startTime = 120;

    public Text timer;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        //print(currentTime);
        timer.text = currentTime.ToString("0");

        if (currentTime <= 20)
        {
            timer.color = Color.red;
        }

        if (currentTime <= 0)
        {
            currentTime = 0;
            FindObjectOfType<GameManager>().EndGame();
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
