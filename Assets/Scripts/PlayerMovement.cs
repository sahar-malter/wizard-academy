using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 move;
    private Vector3 velocity;
    private float moveX;
    private float moveZ;
    public float speed;
    public float gravity;
    public GroundCheck groundcheck;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");
        move = transform.right * moveX + transform.forward * moveZ;
        if(groundcheck.isGrounded && velocity.y < 0f)
        {
            velocity.y = 0;
        }
      
    }
    private void FixedUpdate()
    {
        controller.Move(move * speed * Time.fixedDeltaTime);
        velocity.y += gravity * Time.fixedDeltaTime;
        controller.Move(velocity * Time.fixedDeltaTime);

    }
}
