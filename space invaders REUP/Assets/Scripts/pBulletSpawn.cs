using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pBulletSpawn : MonoBehaviour
{
    Collider2D pBulletCollider;
    public Image pBullet;

    float bulletCooldown = 4f;

    public PlayerController playerScript;

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
            if(bulletCooldown >= 3f){
                Instantiate(pBullet, transform.position, Quaternion.identity);
                bulletCooldown = 0f;
            }
        }

        if(bulletCooldown < 3f)
        {
            bulletCooldown += Time.deltaTime;
        }
    }
}
