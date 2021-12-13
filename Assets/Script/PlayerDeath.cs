using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject dieEffect;
    public CameraShake cameraShake;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathZone")
        {
            Instantiate(dieEffect, transform.position, Quaternion.identity);
            StartCoroutine(cameraShake.Shake(.20f, .8f));
            Destroy(gameObject);
        }
    }
}
