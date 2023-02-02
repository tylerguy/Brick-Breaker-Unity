using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour

{

    public GameObject Player;
    public GameObject Enemy;
    public float speed;
    public Transform target;


    // Start is called before the first frame update
    void Start()
    {
        

    }

    private void Awake()
    {
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
            MoveTowardsTarget();
           
       
    }

 

    private void MoveTowardsTarget()
    {
        transform.position -= transform.up * speed * Time.deltaTime;
    }
}
