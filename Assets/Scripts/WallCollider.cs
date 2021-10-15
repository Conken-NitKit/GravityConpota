using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollider : MonoBehaviour
{
    private string groundTag = "Ground";
    private bool isWall = false;
    private bool isWallEnter, isWallStay, isWallExit;

    public bool IsWall()
    {
        if (isWallEnter || isWallStay)
        {
            isWall = true;
        }
        else if (isWallExit)
        {
            isWall = false;
        }

        isWallEnter = false;
        isWallStay = false;
        isWallExit = false;
        return isWall;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == groundTag)
        {
            isWallEnter = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == groundTag)
        {
            isWallStay = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == groundTag)
        {
            isWallExit = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
