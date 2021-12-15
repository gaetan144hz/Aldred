using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] Movement movement;
    [SerializeField] SpriteRenderer spriteRenderer;

    public GameObject dieEffect;
    public CameraShake cameraShake;

    private void Awake()
    {
        movement = GetComponent<Movement>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "DeathZone")
        {
            Instantiate(dieEffect, transform.position, Quaternion.identity);
            StartCoroutine(cameraShake.Shake(.20f, .8f));
            Destroy(spriteRenderer);
            Destroy(movement);
            Destroy(dieEffect);
            SceneManager.LoadScene(0); 
            //SceneManager.LoadScene("nomDeLaScene");
        }
    }
}
