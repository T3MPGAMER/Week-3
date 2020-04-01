using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed;
    public float jumpForce;


    void Start()
    { rb.GetComponent<Rigidbody>(); }
    void Update()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed * 3,
rb.velocity.y, 3 * moveSpeed);
       
    }
}


