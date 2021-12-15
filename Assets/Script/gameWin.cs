using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameWin : MonoBehaviour
{
    public GameObject fireworks;
    public GameObject fireworks1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            fireworks.SetActive(true);
            fireworks1.SetActive(true);
        }
    }
}
