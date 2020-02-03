using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tongue : MonoBehaviour
{

    bool extend;

    void Start()
    {
        extend = false;
    }

    private void Update()
    {
        if(extend == true)
        {
            Debug.Log("in update if");
            StartCoroutine("Out", 2.0F);
            StopCoroutine("Out");

            StartCoroutine("In", 2.0F);
            StopCoroutine("In");
        }
    }

    public void extendTongue()
    {
        extend = true;
        Debug.Log("extend = true");
    }

    //IEnumerator Start()
    //{
    //StartCoroutine("DoSomething", 2.0F);
    //yield return new WaitForSeconds(1);
    //StopCoroutine("DoSomething");
    //}

    IEnumerator Out()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            transform.localScale += new Vector3(0, 0, 0.2f);
            yield return null;
        }
    }

    IEnumerator In()
    {
        while (true)
        {
            extend = false;
            yield return new WaitForSeconds(1);
            transform.localScale += new Vector3(0, 0, 0);
            yield return null;
        }
    }
}
