using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public float groundCheckSphereRadius = 0.4f;
    public LayerMask groundLayer;
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(transform.position, groundCheckSphereRadius, groundLayer);
    }
}
