using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMotion : MonoBehaviour
{
    public float initVX;
    public float initVY;

    public float currentVX;
    public float currentVY;

    public string ColliderInfo;

    public string Info1;
    public string Info2;


    Vector2 velocityVector;
    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocityVector = new Vector2(initVX, initVY);
        rb.velocity = velocityVector;

    }

    // Update is called once per frame
    void Update()  {
        currentVX = rb.velocity.x;
        currentVY = rb.velocity.y;
        float magnitude = rb.velocity.magnitude;
        float angle = Mathf.Atan2(currentVY, currentVX) * Mathf.Rad2Deg;
        Info1 = "V; " + rb.velocity.ToString() + " Mag: " + magnitude + " Angle: "+ angle;

        Vector2 unitVector = rb.velocity.normalized;
        Info2 = "unitVector: (" + unitVector.x + "," + unitVector.y + ")";

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ColliderInfo = collision.collider.name;
    }

}
