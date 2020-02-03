using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    private void Start()
    {
        FindObjectOfType<FlyCounter>().numFlies += 1;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Tongue")
        {
            Debug.Log("Collision Detected");
            Destroy(gameObject);
            FindObjectOfType<FlyCounter>().numFlies -= 1;
        }

        if (collision.gameObject.tag == "Frog")
        {
            Destroy(gameObject);
            FindObjectOfType<FlyCounter>().numFlies -= 1;
        }
    }
}
