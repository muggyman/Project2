using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TongueSpawner : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject tonguePrefab;

    public bool active = false;

    void Start()
    {
        //tonguePrefab = GameObject.Find("Tpivot");
        //SpawnTongue();
    }

    void Update()
    {
        //Debug.Log(active);

        if (active == true)
        {
            SpawnTongue();
            active = false;
        }
    }

    public void ActiveState()
    {
        Debug.Log("In Active State");
        if (active == false)
        {
            Debug.Log("In Active State If");
            active = true;
        }
    }

    public void SpawnTongue()
    {
        Debug.Log("SpawnTounge Called");
        GameObject Tongue = Instantiate(tonguePrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
