using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public GameObject Player;
    public float speed;
    public GameObject Enemy;
    

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        

        if (Input.GetKey(KeyCode.LeftArrow ) | Input.GetKey(KeyCode.A))
        {
            Debug.Log("Left Pressed");
            Player.transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow) | Input.GetKey(KeyCode.D))
        {
            Debug.Log("Right Pressed");
            Player.transform.position += Vector3.right * speed * Time.deltaTime;
        }

        



        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - Player.transform.position;
        float angle = Vector2.SignedAngle(Vector2.up, direction);
        Player.transform.eulerAngles = new Vector3(0, 0, angle);

       }


    

}
