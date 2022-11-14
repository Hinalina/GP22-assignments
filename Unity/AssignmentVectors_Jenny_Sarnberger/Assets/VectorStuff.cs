using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorStuff : ProcessingLite.GP21
{
    public Vector2 CirclePos;
    public Vector2 Offset;
    private float dia = 2f;

    // Update is called once per frame
    void Update()
    {
        Background(0);

        if (Input.GetMouseButton(0))
        {
            Line(CirclePos.x, CirclePos.y, MouseX, MouseY);
        }
        if (Input.GetMouseButtonUp(0))
        {
            Offset = new Vector2(MouseX - CirclePos.x, MouseY - CirclePos.y);
            Debug.Log(Offset);
        }
        if (Input.GetMouseButtonDown(0))
        {
            CirclePos.x = MouseX;
            CirclePos.y = MouseY;
        }
        if (!Input.GetMouseButton(0))
        {
            if (CirclePos.x >= Width - 1 || CirclePos.x <= 1)
            {
                Offset.x *= -1;
            }

            if (CirclePos.y >= Height - 1 || CirclePos.y <= 1)
            {
                Offset.y *= -1;
            }
        }

        CirclePos += Offset * Time.deltaTime;
        Circle(CirclePos.x, CirclePos.y, dia);
    }
}
