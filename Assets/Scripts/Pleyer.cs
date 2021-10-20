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

        if(horizontalKey > 0)//�E�ɓ��͂����Ƃ�
        {
            switch ((Rotation)transform.eulerAngles.z)
            {
                case Rotation.DOWN :
                    xSpeed = speed;//�E�Ɉړ�
                    break;
                case Rotation.RIGHT:
                    ySpeed = speed;//��Ɉړ�
                    break;
                case Rotation.UP:
                    xSpeed = -speed;//���Ɉړ�
                    break;
                case Rotation.LEFT:
                    ySpeed = -speed;//���Ɉړ�
                    break;
            }
            if (isRightWall)//�E�̕ǂɐڐG
            {
                //�����v���ɉ�]
                transform.Rotate(new Vector3(0, 0, 90));

            }
        }
        else if(horizontalKey < 0)//���ɓ��͂����Ƃ�
        {
            switch ((Rotation)transform.eulerAngles.z)
            {
                case Rotation.DOWN:
                    xSpeed = -speed;//���Ɉړ�
                    break;
                case Rotation.RIGHT:
                    ySpeed = -speed;//���Ɉړ�
                    break;
                case Rotation.UP:
                    xSpeed = speed;//�E�Ɉړ�
                    break;
                case Rotation.LEFT:
                    ySpeed = speed;//��Ɉړ�
                    break;
            }
            if (isLeftWall)//���̕ǂɐڐG
            {
                //���v���ɉ�]
                transform.Rotate(new Vector3(0, 0, -90));

            }
        }
        rb.velocity = new Vector2(xSpeed, ySpeed);

    }
}
