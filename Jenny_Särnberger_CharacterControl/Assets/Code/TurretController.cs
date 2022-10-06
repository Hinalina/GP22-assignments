using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Vector2 MousePos = Input.mousePosition;

        MousePos = Camera.main.ScreenToWorldPoint(MousePos);

        transform.up = (Vector3)MousePos - transform.position;
    }
}
