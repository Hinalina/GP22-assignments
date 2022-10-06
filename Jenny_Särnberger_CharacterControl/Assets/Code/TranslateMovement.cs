using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateMovement : MonoBehaviour
{
    public float Speed;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(x, y, 0) * Speed * Time.deltaTime;

        transform.Translate(movement);

        Vector2 MousePos = Input.mousePosition;

        MousePos = Camera.main.ScreenToWorldPoint(MousePos);

        transform.up = (Vector3)MousePos - transform.position;
    }
}
