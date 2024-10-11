using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerRigidbodyController : MonoBehaviour
{
    [SerializeField] Rigidbody2D playerBody;
    [SerializeField] float moveSpeed;

    private void FixedUpdate()
    {
        ProcessMovement();
    }

    // processes inputs into movement
    void ProcessMovement()
    {
        // get our movement
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        Debug.Log(hor);
        Debug.Log(ver);

        // apply those to the velocity
        playerBody.velocity = new Vector2(hor * moveSpeed * Time.deltaTime, ver * moveSpeed * Time.deltaTime);
    }
}
