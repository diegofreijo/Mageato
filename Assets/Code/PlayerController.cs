using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private SpriteRenderer spriteRenderer;

    void Start()
    {
        // this.rb = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue value)
    {
        var direction = value.Get<Vector2>();
        // Debug.Log(direction);
        // transform.position = transform.position + new Vector3(direction.x, direction.y, 0);
        rb.velocity = direction * speed;

        if (direction.x != 0)
            spriteRenderer.flipX = direction.x < 0;
    }
}
