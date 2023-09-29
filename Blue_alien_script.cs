using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue_alien_script : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float float_strength;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true) {
            myRigidbody.velocity = Vector2.up * float_strength;
        }
        
    }
}
