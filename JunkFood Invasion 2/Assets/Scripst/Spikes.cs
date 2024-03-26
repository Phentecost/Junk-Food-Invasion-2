using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{

    private float Counter;

    // Update is called once per frame
    void Update()
    {
        // Se creo un cronometro, ese indica el tiempo que permanece inactivo el componente de BoxCollider2D de los pinchos
        // Si el cronometro es menor a 0
        if (Counter <= 0)
        {
            // Se activa el componente de BoxColider2D de los pincho
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }
        else if (Counter > 0)
        {
            // El cronoemtro disminuye con el timpo
            Counter -= Time.deltaTime;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Se toma referencia del C# del jugador
        PlayerController Player = collision.GetComponent<PlayerController>();

        // Se comprueba que el jugador haya tocado el pincho
        if (Player != null)
        {
            // Se cambia vida del jugador
            Player.ChangeLife(-1);

            // Se asigna un tiempo para el cronometro
            Counter = 2.0f;

            // Se desactiva el componente de BoxColaider2D del pincho
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
