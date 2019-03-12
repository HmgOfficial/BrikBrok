using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour {

    private Rigidbody2D rb;
    private int velocidad = 8;

	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(1, 1) * velocidad, ForceMode2D.Impulse);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            Destroy(gameObject);
            ControladorJuego.instance.timer = 3;
            ControladorJuego.instance.pelotaEnPantalla = false;
            ControladorJuego.instance.vida--;
            ControladorJuego.instance.AtualizarHUD();
        }
    }
}
