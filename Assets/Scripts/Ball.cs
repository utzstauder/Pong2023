using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rigidbody2D;

    public Vector2 initialVelocity;

    Vector3 initialPosition;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        initialPosition = transform.position;
    }

    private void Start()
    {
        rigidbody2D.velocity = initialVelocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.collider.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.gameObject.name);

        transform.position = initialPosition;
        rigidbody2D.velocity = new Vector2(
            -rigidbody2D.velocity.x,
            rigidbody2D.velocity.y
            );
    }
}
