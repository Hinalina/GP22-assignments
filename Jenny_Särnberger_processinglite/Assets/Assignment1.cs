using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment1 : ProcessingLite.GP21
{
    float spaceBetweenLines = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Clear background
        Background(100, 0, 100);

        //Draw our art/stuff, or in this case a rectangle
        //Rect(1, 1, 3, 3);

        //BLACK
        Stroke(0, 0, 0);

        //SEMI THICC
        StrokeWeight(1);

        //Circle kek
        Circle(8, 8, 3);
        Circle(5, 5, 6);
        Circle(2, 8, 3);

        for (int i = 0; i < Height / spaceBetweenLines; i++)
        {

            float y = i * spaceBetweenLines;


            Line(0, y, Width, y);
        }

        //WHITE
        Stroke(255, 255, 255);

        //THICC
        StrokeWeight(2);

        //H
        Line(4, 7, 4, 3);
        Line(4, 5, 6, 5);
        Line(6, 7, 6, 3);

        //I
        Line(8, 7, 8, 3);

        //N
        Line(10, 7, 10, 3);
        Line(10, 7, 12, 3);
        Line(12, 7, 12, 3);

        //A
        Line(14, 3, 15.5f, 7);
        Line(15.5f, 7, 17, 3);
        Line(14.8f, 5, 16.2f, 5);


    }
}
