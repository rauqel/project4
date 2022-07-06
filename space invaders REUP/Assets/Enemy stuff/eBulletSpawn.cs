using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eBulletSpawn : MonoBehaviour
{
    Collider2D eBulletCollider;
    public GameObject eBullet;
    public Rigidbody2D spawner;
    public GameObject canvas;

    float bulletCooldown = 0f;

    // Start is called before the first frame update
    void Start()
    {
        eBulletCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(bulletCooldown);
        
        if (bulletCooldown >= 3.5f)
        {
            var bulletPos = new Vector2(spawner.position.x, spawner.position.y);
            var createBullet = Instantiate(eBullet, bulletPos, Quaternion.identity);
            createBullet.transform.SetParent(canvas.transform, true);
            bulletCooldown = 0f;
        }

        if (bulletCooldown < 3.5f)
        {
            bulletCooldown += Time.deltaTime;
        }
    }
}
