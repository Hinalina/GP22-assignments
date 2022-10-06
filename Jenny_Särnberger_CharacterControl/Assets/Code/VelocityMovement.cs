using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityMovement : MonoBehaviour
{
    public float Speed;

    Rigidbody2D r2d;

    // Start is called before the first frame update
    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
        r2d.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(x, y) * Speed;

        r2d.velocity = movement;

        Vector2 MousePos = Input.mousePosition;

        MousePos = Camera.main.ScreenToWorldPoint(MousePos);

        transform.up = (Vector3)MousePos - transform.position;
    }
}
