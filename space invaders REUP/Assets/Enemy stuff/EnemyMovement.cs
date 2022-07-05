using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D enemyCharacter;

    public GameObject[] row1;
    public GameObject[] row2;
    public GameObject[] row3;

    float movementTimer = 0;

    bool moveOver;
    bool moveDown;

    int currentPlace = 0;

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
                if (currentPlace < 13)
                {
                    currentPlace += 1;
                    moveOver = true;
                }
                if(currentPlace == 13)
                {
                    moveOver = false;
                    moveDown = true;
                    moveRight = false;
                    moveLeft = true;
                }
            }
            if (moveLeft)
            {
                if (currentPlace <= 13)
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
                }
            }
        }

        if (moveOver)
        {
            enemyCharacter.transform.position = new Vector2(row1[currentPlace].transform.position.x, row1[currentPlace].transform.position.y);
        }

        if (moveDown)
        {
            enemyCharacter.transform.position = new Vector2(enemyCharacter.transform.position.x, row2[currentPlace].transform.position.y);
        }
    }
}
