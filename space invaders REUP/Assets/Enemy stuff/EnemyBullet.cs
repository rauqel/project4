using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    Collider2D bulletCollider;
    Rigidbody2D eBullet;

    // Start is called before the first frame update
    void Start()
    {
        bulletCollider = GetComponent<Collider2D>();
        eBullet = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Barrier")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }

    private void Update()
    {
        eBullet.velocity = new Vector2(eBullet.velocity.x, -300.0f) * 8;
    }
}
