using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform spawnPoint;
    public GameObject bugPrefab;

    private int num;

    void Start()
    {
        num = Random.Range(0, 3);

        if (num == 1)
        {
            SpawnBug();
        }
    }

    void SpawnBug()
    {
        GameObject Bug = Instantiate(bugPrefab, spawnPoint.position, spawnPoint.rotation);
    }

}
