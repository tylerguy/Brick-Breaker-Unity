using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public int force;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(Vector2.up * force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
