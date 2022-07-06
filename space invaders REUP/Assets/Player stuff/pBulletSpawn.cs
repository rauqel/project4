using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pBulletSpawn : MonoBehaviour
{
    Collider2D pBulletCollider;
    public GameObject pBullet;
    public Rigidbody2D spawner;
    public GameObject canvas;

    float bulletCooldown = 4f;

    // Start is called before the first frame update
    void Start()
    {
        pBulletCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(bulletCooldown);

        if (Input.GetMouseButtonDown(0))
        {
            if(bulletCooldown >= 1f){
                var bulletPos = new Vector2(spawner.position.x, spawner.position.y);
                var createBullet = Instantiate(pBullet, bulletPos, Quaternion.identity);
                createBullet.transform.SetParent(canvas.transform, true);
                bulletCooldown = 0f;
            }
        }

        if(bulletCooldown < 1f)
        {
            bulletCooldown += Time.deltaTime;
        }
    }
}
