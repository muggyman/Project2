using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlyCounter : MonoBehaviour
{
    public float numFlies = 0f;

    public Text counter;

    // Update is called once per frame
    void Update()
    {
        counter.text = numFlies.ToString("0");

        if (numFlies <= 0)
        {
            numFlies = 0;
            FindObjectOfType<GameManager>().EndGame();
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
