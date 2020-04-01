using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Playerreturn : MonoBehaviour
{ public Transform target = null;
public Transform target2 = null;
bool bJump = false;
bool bJump2 = false;

private void OnTriggerEnter(Collider other)
{
    if (other.gameObject.tag == "Teleport")
    {
        this.transform.position = target.position;
      
    }

    
}

private void OnTriggerExit(Collider other)
{
        if (other.gameObject.tag == "Teleport")
        {
        }
    
}

// Update is called once per frame
void Update()
{

}
}


