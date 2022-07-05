using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D enemyCharacter;

    public GameObject[] row1;
    public GameObject[] row2;
    public GameObject[] row3;
    public GameObject[] row4;
    public GameObject[] row5;
    public GameObject[] row6;
    public GameObject[] row7;
    public GameObject[] row8;
    public GameObject[] row9;
    public GameObject[] row10;
    public GameObject[] row11;

    public Collider2D leftCheck;
    public Collider2D rightCheck;

    float movementTimer = 0;

    bool moveOver;
    bool moveDown;

    public int currentPlace;
    int counter;

    bool moveLeft;
    bool moveRight = true;

    // Start is called before the first frame update
    void Start()
    {
        enemyCharacter = GetComponent<Rigidbody2D>();

        enemyCharacter.transform.position = new Vector2(row1[currentPlace].transform.position.x, row1[currentPlace].transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        movementTimer += Time.deltaTime;
        if(movementTimer >= 1f)
        {
            movementTimer = 0;
            if (moveRight)
            {
                if (currentPlace < 10)
                {
                    currentPlace += 1;
                    moveOver = true;
                }
                if(currentPlace == 10)
                {
                    moveOver = false;
                    moveDown = true;
                    moveRight = false;
                    moveLeft = true;

                    counter += 1;
                }
            }
            if (moveLeft)
            {
                if (currentPlace <= 10)
                {
                    currentPlace -= 1;
                    moveOver = true;
                }
                if (currentPlace == -1)
                {
                    moveOver = false;
                    moveDown = true;
                    moveLeft = false;
                    moveRight = true;

                    counter += 1;
                }
            }
        }

        if (moveOver)
        {
            enemyCharacter.transform.position = new Vector2(row1[currentPlace].transform.position.x, row1[currentPlace].transform.position.y);
        }

        if (moveDown)
        {
            if (counter == 1)
            {
                enemyCharacter.transform.position = new Vector2(enemyCharacter.transform.position.x, row2[currentPlace].transform.position.y);
            }
            if (counter == 2)
            {
                enemyCharacter.transform.position = new Vector2(enemyCharacter.transform.position.x, row3[currentPlace].transform.position.y);
            }
            if (counter == 3)
            {
                enemyCharacter.transform.position = new Vector2(enemyCharacter.transform.position.x, row4[currentPlace].transform.position.y);
            }
            if (counter == 4)
            {
                enemyCharacter.transform.position = new Vector2(enemyCharacter.transform.position.x, row5[currentPlace].transform.position.y);
            }
            if (counter == 5)
            {
                enemyCharacter.transform.position = new Vector2(enemyCharacter.transform.position.x, row6[currentPlace].transform.position.y);
            }
            if (counter == 6)
            {
                enemyCharacter.transform.position = new Vector2(enemyCharacter.transform.position.x, row7[currentPlace].transform.position.y);
            }
            if (counter == 7)
            {
                enemyCharacter.transform.position = new Vector2(enemyCharacter.transform.position.x, row8[currentPlace].transform.position.y);
            }
            if (counter == 8)
            {
                enemyCharacter.transform.position = new Vector2(enemyCharacter.transform.position.x, row9[currentPlace].transform.position.y);
            }
            if (counter == 9)
            {
                enemyCharacter.transform.position = new Vector2(enemyCharacter.transform.position.x, row10[currentPlace].transform.position.y);
            }
            if (counter == 10)
            {
                enemyCharacter.transform.position = new Vector2(enemyCharacter.transform.position.x, row11[currentPlace].transform.position.y);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }
}
