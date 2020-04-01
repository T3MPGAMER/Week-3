using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementP2 : MonoBehaviour
{
    
    public Rigidbody rb;
    public float moveSpeed;
    public float jumpForce;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
        
    }
}
