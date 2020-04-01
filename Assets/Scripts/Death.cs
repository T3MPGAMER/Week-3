using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Death : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider collidedObject)
    {
        if (collidedObject.tag == "Enemy")

        {
           

            Destroy(this.gameObject); SceneManager.LoadScene("Start");

        }


    }
}
