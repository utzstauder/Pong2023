using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidbody2D;

    public float speed = 2f;

    private float input;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        input = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rigidbody2D.velocity = new Vector2(0, input * speed);
    }
}
