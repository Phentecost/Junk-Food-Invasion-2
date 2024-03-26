using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPos : MonoBehaviour
{
    private GameMaster gm;
    void Start()
    {
        // Se toma referencia del Game Master
        gm = GameObject.Find("GM").GetComponent<GameMaster>();

        // Se asigna la posicion del ultimo check point cuando se reinicie el nivel
        transform.position = gm.LastPosition;
    }
}
