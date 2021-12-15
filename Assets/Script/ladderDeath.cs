using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladderDeath : MonoBehaviour
{
    public GameObject dieEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DeathZone")
        {
            Instantiate(dieEffect, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}

