using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pleyer : MonoBehaviour
{
    public float speed;
    public GroundCollider ground;
    public WallCollider rightWall;
    public WallCollider leftWall;

    private Rigidbody2D rb = null;
    private bool isRightWall = false;
    private bool isLeftWall = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalKey = Input.GetAxis("Horizontal");
        float xSpeed = 0.0f;
        isRightWall = rightWall.IsWall();
        isLeftWall = leftWall.IsWall();

        if(horizontalKey > 0)
        {
            xSpeed = speed;
            if (isRightWall)
            {
                transform.Rotate(new Vector3(0, 0, 90));
                Physics2D.gravity = new Vector2(9.81f, 0f);
            }

        }
        else if(horizontalKey < 0)
        {
            xSpeed = -speed;
            if (isLeftWall)
            {
                transform.Rotate(new Vector3(0, 0, -90));
                Physics2D.gravity = new Vector2(-9.81f, 0f);
            }
        }
        rb.velocity = new Vector2(xSpeed, rb.velocity.y);

    }
}
