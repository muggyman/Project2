using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butterfly : MonoBehaviour
{
    public float rotationSpeed = 75.0f;

    private void Update()
    {
        StartCoroutine(Rotation());
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Tongue")
        {
            Destroy(gameObject);
            FindObjectOfType<GameManager>().ShowLoseScreen1();
            Cursor.lockState = CursorLockMode.None;
        }

        if (collision.gameObject.tag == "Frog")
        {
            Destroy(gameObject);
            FindObjectOfType<GameManager>().ShowLoseScreen1();
        }
    }

    IEnumerator Rotation()
    {
        this.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        yield return new WaitForSeconds(1f);
    }

}
