using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float rotationSpeed = 75.0f;

    private void Start()
    {
        FindObjectOfType<FlyCounter>().numFlies += 1;
    }

    private void Update()
    {
        StartCoroutine(Rotation());
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Tongue")
        {
            Debug.Log("Collision Detected");
            Destroy(gameObject);
            FindObjectOfType<FlyCounter>().numFlies -= 1;
            FindObjectOfType<EnergyBar>().AddEnergy(500);
        }

        if (collision.gameObject.tag == "Frog")
        {
            Destroy(gameObject);
            FindObjectOfType<FlyCounter>().numFlies -= 1;
            FindObjectOfType<EnergyBar>().AddEnergy(500);
        }
    }

    IEnumerator Rotation()
    {
        this.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        yield return new WaitForSeconds(1f);
    }

}
