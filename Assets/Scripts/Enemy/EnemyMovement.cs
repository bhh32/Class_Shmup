using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour 
{
    Rigidbody2D rb;
    Vector3 pos;
    [SerializeField] float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(20f, speed), ForceMode2D.Impulse);
        pos = transform.position;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (transform.position.x < pos.x - .25f)
            rb.AddForce(new Vector2(speed, speed), ForceMode2D.Force);
        else if (transform.position.x > pos.x + .25f)
            rb.AddForce(new Vector2(-speed, speed), ForceMode2D.Force);

        if (transform.position.y < pos.x - .5f)
            rb.AddForce(new Vector2(speed, speed), ForceMode2D.Force);
            

    }
}
