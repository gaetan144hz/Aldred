using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ziakSprite : MonoBehaviour
{
    public Sprite ziak;
    public Animator playerAnimator;

    AudioSource galerie;
    

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
        galerie.Play();
        Debug.Log(ziak);
    }

    public void onPLayer(InputAction.CallbackContext ctx)
    {
        playerAnimator.enabled = true;
        galerie.Stop();
    }
    void Update()
    {
        
    }
}
