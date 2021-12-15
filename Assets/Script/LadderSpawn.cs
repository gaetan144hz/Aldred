using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LadderSpawn : MonoBehaviour
{
    [SerializeField] private float floatScaler;
    //[SerializeField] private int waiting;
    private bool isButtonPressed;

    public GameObject ladderPrefab;
    public GameObject lastLadder;

    public Rigidbody2D rb;

    [SerializeField] private Transform spawnPoint;

    private void Awake()
    {        
        /*quand input performed stop coroutine
        //et quand canceled j'active le rb pour laisser tomber l'echelle rb en kinematic et dynamic quand c 'est relaché
        faire un bool dans une coroutine
        couroutine dans un scritp a part et de l'appeler dans le script du spawn
        */
    }
    public void OnSpawn(InputAction.CallbackContext ctx)
    {
        if (ctx.started)// 
        {
            ladderSpawn();
            isButtonPressed = true;
            StartCoroutine(scaler());
            rb.bodyType = RigidbodyType2D.Kinematic;
        }
        if (ctx.performed) //se lance 0.4s après 
        {
            isButtonPressed = false;
            return;
        }
        if (ctx.canceled) // appeler quand relaché
        {
            isButtonPressed = false;
            rb.bodyType = RigidbodyType2D.Dynamic;
            //StartCoroutine(wait());
            return;
        }       
    }

    private IEnumerator scaler()
    {
        while (isButtonPressed)
        {
            lastLadder.transform.localScale += new Vector3(0, floatScaler, 0);
            yield return null;
        }
    }
    /*
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ladderCollider")
        {
            rb.gravityScale = 0;
            rb.bodyType = RigidbodyType2D.Kinematic;
        }
    }
    */
    public void ladderSpawn()
    {        
        lastLadder = Instantiate(ladderPrefab, new Vector3(spawnPoint.position.x + 1f, spawnPoint.position.y), ladderPrefab.transform.rotation);
        rb = lastLadder.GetComponent<Rigidbody2D>();
    }  
    
}
