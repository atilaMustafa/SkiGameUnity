using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }


    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(3);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-3);
        }
    }
}
