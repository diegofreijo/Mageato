using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Camera mainCamera;
    public float speed = 1f;

    private float startPosition;
    private float length;

    void Start()
    {
        startPosition = transform.position.x;
        // length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void FixedUpdate()
    {
        var dist = mainCamera.transform.position.x * speed;

        transform.position = new Vector3(startPosition + dist, transform.position.y, transform.position.z);
    }
}
