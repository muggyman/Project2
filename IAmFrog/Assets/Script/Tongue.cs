using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tongue : MonoBehaviour
{

    void Update()
    {

    }

    IEnumerator Start()
    {
        StartCoroutine("DoSomething", 2.0F);
        yield return new WaitForSeconds(1);
        StopCoroutine("DoSomething");
    }

    IEnumerator DoSomething(float someParameter)
    {
        while (true)
        {
            transform.localScale += new Vector3(0, 0, 0.15f);
            yield return null;
        }
    }

}
