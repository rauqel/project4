using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    Rigidbody2D pBullet;
    private void Start()
    {
        pBullet = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {

        pBullet.velocity = new Vector2(pBullet.velocity.x, 300.0f) * 8;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Barrier")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
