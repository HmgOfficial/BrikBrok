using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pala : MonoBehaviour {

    private Rigidbody2D rb;

	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}
	
	void Update ()
    {
        Movimiento();
    }
    private void Movimiento()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2 (-8, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(8, 0);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }

}
