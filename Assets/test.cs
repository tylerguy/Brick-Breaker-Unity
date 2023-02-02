using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /* Always runs before start, even if script is disabled
     * intialises variables before the main game update.
     * All procedures run before start is called.
    */
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Start");        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }
    
    /* useful for updating
     * useful for physics updates
     */
    private void FixedUpdate()
    {
        Debug.Log("Fixed Update");
    }
    
    
    /* good for updating camera location after the player has moved
     * runs after all update calls
     * should only be used when a value has changed in the same frame.
     */
    private void LateUpdate()
    {
        Debug.Log("Late Update");
        
    }
}
