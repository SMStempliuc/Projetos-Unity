using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rigidBody;
    public float acceleration = 100f;
    public float maxSpeed = 10f;

    // Start is called before the first frame update
    void Awake()
    {

        rigidBody = GetComponent<Rigidbody2D>();
}

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");

        if (rigidBody.velocity.x * moveH < maxSpeed)
        {
            rigidBody.AddForce(Vector2.right * moveH * acceleration);
        }

        if (Mathf.Abs(rigidBody.velocity.x) > maxSpeed)
        {
            Vector2 vel = new Vector2(Mathf.Sign(rigidBody.velocity.x) * maxSpeed, rigidBody.velocity.y);
            rigidBody.velocity = vel;
        }

    }
}
