using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pleyer : MonoBehaviour
{
    public float speed;
    public GroundCollider ground;
    public WallCollider rightWall;
    public WallCollider leftWall;

    private Rigidbody2D rb;
    private bool isRightWall = false;
    private bool isLeftWall = false;

    public enum Rotation
    {
        DOWN = 0,
        RIGHT = 90,
        UP = 180,
        LEFT = 270,
    }
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalKey = Input.GetAxis("Horizontal");
        float xSpeed = 0.0f;
        float ySpeed = 0.0f;

        isRightWall = rightWall.IsWall();
        isLeftWall = leftWall.IsWall();

        if(horizontalKey > 0)//右に入力したとき
        {
            switch ((Rotation)transform.eulerAngles.z)
            {
                case Rotation.DOWN :
                    xSpeed = speed;//右に移動
                    break;
                case Rotation.RIGHT:
                    ySpeed = speed;//上に移動
                    break;
                case Rotation.UP:
                    xSpeed = -speed;//左に移動
                    break;
                case Rotation.LEFT:
                    ySpeed = -speed;//下に移動
                    break;
            }
            if (isRightWall)//右の壁に接触
            {
                //反時計回りに回転
                transform.Rotate(new Vector3(0, 0, 90));

            }
        }
        else if(horizontalKey < 0)//左に入力したとき
        {
            switch ((Rotation)transform.eulerAngles.z)
            {
                case Rotation.DOWN:
                    xSpeed = -speed;//左に移動
                    break;
                case Rotation.RIGHT:
                    ySpeed = -speed;//下に移動
                    break;
                case Rotation.UP:
                    xSpeed = speed;//右に移動
                    break;
                case Rotation.LEFT:
                    ySpeed = speed;//上に移動
                    break;
            }
            if (isLeftWall)//左の壁に接触
            {
                //時計回りに回転
                transform.Rotate(new Vector3(0, 0, -90));

            }
        }
        rb.velocity = new Vector2(xSpeed, ySpeed);

    }
}
