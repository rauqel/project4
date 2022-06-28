using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    Collider2D bulletCollider;
    Rigidbody2D bulletObject;

    // Start is called before the first frame update
    void Start()
    {
        bulletCollider = GetComponent<Collider2D>();
        bulletObject = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Barrier")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
