using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerController Player = collision.gameObject.GetComponent<PlayerController>();
        if (Player != null)
        {
            Player.CurrentLife -= 1;
        }
    }
}
