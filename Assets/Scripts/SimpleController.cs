using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleController : MonoBehaviour
{
    // the player's rigidbody
    [SerializeField] Rigidbody2D playerBody;
    [SerializeField] float moveSpeed;

    // Update is called once per frame
    void FixedUpdate()
    {
        ProcessMovement();
    }

    // controls our movement
    void ProcessMovement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            playerBody.AddForce(Vector2.right * moveSpeed * Time.deltaTime, ForceMode2D.Impulse);
        }        
        
        if (Input.GetKey(KeyCode.A))
        {
            playerBody.AddForce(Vector2.right * moveSpeed * Time.deltaTime, ForceMode2D.Impulse);
        }
    }
}
