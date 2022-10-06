using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed;
    public float rotSpeed;

    private float angle;

    Rigidbody2D r2d;
    // Start is called before the first frame update
    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        angle -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;

        r2d.MoveRotation(angle);

        float y = Input.GetAxis("Vertical");

        r2d.velocity = r2d.transform.up * y;
    }
}
