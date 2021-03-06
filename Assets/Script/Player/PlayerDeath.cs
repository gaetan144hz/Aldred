using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] Movement movement;
    [SerializeField] SpriteRenderer spriteRenderer;

    public GameObject gameOverUI;

    public GameObject dieEffect;
    //public CameraShake cameraShake;

    private void Update()
    {
        
    }

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
            //StartCoroutine(cameraShake.Shake(.20f, .8f));
            Destroy(this.spriteRenderer);
            Destroy(this.movement);
            gameOver();
            //SceneManager.LoadScene("nomDeLaScene");
        }
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
