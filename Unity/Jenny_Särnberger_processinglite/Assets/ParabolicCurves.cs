using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolicCurves : ProcessingLite.GP21
{
    int numberoflines = 20;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < numberoflines; i++)
        {

            float y1 = Height - i * Height / numberoflines;
            float x2 = i * Width / numberoflines;

            if (i % 3 == 0)
            {
                Stroke(100, 0, 100);
            }
            else
            {
                Stroke(0, 0, 0);
            }

            Line(0, y1, x2, 0);

        }
    }
}
