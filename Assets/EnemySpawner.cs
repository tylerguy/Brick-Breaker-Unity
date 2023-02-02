using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1.0f, 2.0f);

    }

    void Spawn()
    {
        Instantiate(EnemyPrefab, new Vector3(-30, 40, 75), Quaternion.identity);
        Instantiate(EnemyPrefab, new Vector3(-15, 40, 75), Quaternion.identity);
        Instantiate(EnemyPrefab, new Vector3(0, 40, 75), Quaternion.identity);
        Instantiate(EnemyPrefab, new Vector3(15, 40, 75), Quaternion.identity);
        Instantiate(EnemyPrefab, new Vector3(30, 40, 75), Quaternion.identity);
        Instantiate(EnemyPrefab, new Vector3(45, 40, 75), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
