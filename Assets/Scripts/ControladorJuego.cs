using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorJuego : MonoBehaviour {

    public static ControladorJuego instance;
    public GameObject prefabPelota;
    public Transform salidaPelota;
    public float timer;
    public bool pelotaEnPantalla;
    public byte puntuacion = 0;
    public Text puntuacionTXT, vidaTXT, puntosFinDeJuego;
    public int vida;
    public GameObject finDeJuego;

    void Start () {
        Time.timeScale = 0;
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        timer = 3;
        vida = 3;
        AtualizarHUD();
        finDeJuego.SetActive(false);
    }
	void Update () {
        timer -= Time.deltaTime;
        if ((Input.GetKey(KeyCode.Space) || timer <= 0) && vida > 0)
        {
            if (!pelotaEnPantalla)
                SpawnPelota();
        }
        if (vida <= 0 || puntuacion >= 10)
        {
            FinDeJuego();
        }
    }
    private void SpawnPelota()
    {
        pelotaEnPantalla = true;
        GameObject clon = Instantiate(prefabPelota);
        clon.name = "Pelota";
        clon.transform.position = salidaPelota.transform.position;

    }
    public void AtualizarHUD()
    {
        vidaTXT.text = "Vidas: " + vida;
        puntuacionTXT.text = "Puntuacion: " + puntuacion;
    }
    private void FinDeJuego()
    {
        Time.timeScale = 0;
        finDeJuego.SetActive(true);
        puntosFinDeJuego.text = "Has conseguido " + puntuacion + " puntos";
        
    }
    public void Reiniciar()
    {
        SceneManager.LoadScene("main");
    }
    public void Empezar()
    {
        Time.timeScale = 1;
    }
}
