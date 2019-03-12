using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladrillo : MonoBehaviour {

    private SpriteRenderer sr;

	void Start ()
    {
        sr = GetComponent<SpriteRenderer>();
        CambiarColor();
	}
    private void CambiarColor()
    {
        sr.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pelota")
        {
            Destroy(gameObject);
            ControladorJuego.instance.puntuacion++;
            ControladorJuego.instance.AtualizarHUD();
        }

    }
}
