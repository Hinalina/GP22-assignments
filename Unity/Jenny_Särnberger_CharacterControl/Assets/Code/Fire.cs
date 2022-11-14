using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject Bullet;

    public float BulletSpeed;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var newBullet = Instantiate(Bullet, transform.position, transform.rotation);

            newBullet.GetComponent<Rigidbody2D>().velocity = transform.up * BulletSpeed;
        }
    }
}
