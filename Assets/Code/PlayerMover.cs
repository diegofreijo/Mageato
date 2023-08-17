using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMover : MonoBehaviour
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
        rb.velocity = direction * speed;

        if (direction.x != 0)
            transform.localScale = new Vector3(
                direction.x < 0 ? -1 : 1,
                1, 1);
    }
}
