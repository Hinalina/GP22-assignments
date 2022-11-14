using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceMovement : MonoBehaviour
{
    public float Speed;

    Rigidbody2D r2d;

    // Start is called before the first frame update
    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
        r2d.gravityScale = 0;
        r2d.drag = 1;
    }

    void Update()
    {
        Vector2 MousePos = Input.mousePosition;

        MousePos = Camera.main.ScreenToWorldPoint(MousePos);

        transform.up = (Vector3)MousePos - transform.position;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        r2d.AddForce(movement * Speed);
    }
}
