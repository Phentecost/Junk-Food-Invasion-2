using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPonts : MonoBehaviour
{
    GameMaster gameM;
    private void Start()
    {
        // Se toma referencia del Game Master
        gameM = GameObject.Find("GM").GetComponent<GameMaster>();
    }

    // Cuando el check point detecte un objeto
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Se toma referencia del C# del jugador
        PlayerController Player = collision.GetComponent<PlayerController>();

        // Se comprueba que el check point haya detectado el jugador
        if (Player != null)
        {
            // Se asigna la posicion de este check point a la ultima posicion de Respawn
            gameM.LastPosition = transform.position;
        }
    }
}
