using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Fire : MonoBehaviour
{
    [SerializeField] private Animator animator;

    void OnMove(InputValue value)
    {
        var direction = value.Get<Vector2>();
        animator.SetBool("Running", direction != Vector2.zero);
    }
}
