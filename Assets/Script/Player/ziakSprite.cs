using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ziakSprite : MonoBehaviour
{
    public Sprite playerSprite;
    public Sprite ziak;
    public Animator playerAnimator;

    public AudioSource galerie;
    public AudioSource baseAudio;

    public void Awake()
    {
        galerie = GetComponent<AudioSource>();
        playerAnimator = GetComponent<Animator>();
    }

    public void onZiak(InputAction.CallbackContext ctx)
    {
        playerAnimator.enabled = false;
        this.GetComponent<SpriteRenderer>().color = Color.white;
        this.GetComponent<SpriteRenderer>().sprite = ziak;
        baseAudio.Stop();
        galerie.Play();
        Debug.Log(ziak);
    }

    public void onPLayer(InputAction.CallbackContext ctx)
    {
        
        playerAnimator.enabled = true;
        this.GetComponent<SpriteRenderer>().sprite = playerSprite;
        this.GetComponent<SpriteRenderer>().color = new Color32(86, 181, 255, 255);
        galerie.Stop();
        baseAudio.Play();
    }
    void Update()
    {
        
    }
}
