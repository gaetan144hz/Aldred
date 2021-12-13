using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent (typeof(BoxCollider2D))]
public class Movement : MonoBehaviour
{

    public Rigidbody2D rb;

    private PlayerInput playerInput;

    [SerializeField] float moveSpeed = 3;

    private float horizontal;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2 (horizontal * moveSpeed, rb.velocity.y);
    }
    public void OnMove(InputValue value)
    {
        SetVelocity(value.Get<Vector2>());
        //SetVelocity(ctx.ReadValue<Vector2>());
    }

    public void SetVelocity(Vector2 direction)
    {
        horizontal = direction.x;
    }
}
