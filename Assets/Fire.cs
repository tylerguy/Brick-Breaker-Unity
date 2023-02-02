using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fire : MonoBehaviour
{
    public AudioClip sound;   //play laser sound
    public GameObject Projectile;    // reference to projectile prefab
    public Transform SpawnTransform; // where the prefab will spawn


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) | Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            Instantiate(Projectile, SpawnTransform.position, SpawnTransform.rotation);

        }
    }
}
