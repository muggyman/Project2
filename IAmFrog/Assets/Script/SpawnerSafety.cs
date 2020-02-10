using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSafety : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bugPrefab;

    public void SpawnBug()
    {
        GameObject Bug = Instantiate(bugPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
