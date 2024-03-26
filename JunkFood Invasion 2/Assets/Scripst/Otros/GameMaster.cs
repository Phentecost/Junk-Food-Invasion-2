using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    // Se crea una variable que contenga el C# del GameMaster
    private static GameMaster Instant;

    // Variable que almacena la posicion del ultimo check point que paso el jugador
    public Vector2 LastPosition;

    // Void awake es una funcion que se ejecuta antes que la funcion Start
    private void Awake()
    {
        // Se busca controlar la cantidad de GameMaster en los niveles con el finde que solo halla uno
        // Se comprueba que no halla un GameMaster
        if (Instant == null)
        {
            // Se asigna este gameObject a la variable 
            Instant = this;

            //Unity, cada vez que se carga una escena, el borra el progreso de los C#, en este caso, se requiere mantener la informacion de este
            // Se le dice a unity que no borre los datos de este C#
            DontDestroyOnLoad(Instant);
        }
        else // Si ya hay un GameMaster
        {
            // Se Destruye
            Destroy(gameObject);
        }
    }
}
