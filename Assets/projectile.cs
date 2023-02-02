using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class projectile : MonoBehaviour
{

    public float Speed;   // projectile's speed
    public float Lifespan; // projectile's lifespan

    private Rigidbody2D P_Projectile;
    Vector3 moveDirection;


    void Awake()
    {
        P_Projectile = GetComponent<Rigidbody2D>();
    }


    void Start()
    {
        moveDirection = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);
        moveDirection.z = 0;
        moveDirection.Normalize();
    }

    void Update()
    {
        transform.position = transform.position + moveDirection * Speed * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        
            Destroy(collision.gameObject);
        Score.FirstScore += 5;
        
    }
}

