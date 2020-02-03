using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butterfly : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Tongue")
        {
            Destroy(gameObject);
            FindObjectOfType<GameManager>().EndGame();
            Cursor.lockState = CursorLockMode.None;
        }

        if (collision.gameObject.tag == "Frog")
        {
            Destroy(gameObject);
            FindObjectOfType<GameManager>().EndGame();
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
