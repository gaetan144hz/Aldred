using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladderCollider : MonoBehaviour
{
    private LadderSpawn ladderSpawn;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ladderCollider")
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
}
