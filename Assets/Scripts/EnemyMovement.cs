using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] LayerMask blockLayer;
    Rigidbody2D rigidbody2D;
    float speed = 0;

    public enum MOVE_DIRECTION
    {
        STOP,
        LEFT,
        RIGHT,
    }
    MOVE_DIRECTION moveDirection = MOVE_DIRECTION.RIGHT;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!IsGround())
        {
            ChangeDirection();
           }
        }
    private void FixedUpdate()
    {
        switch (moveDirection)
        {
            case MOVE_DIRECTION.STOP:
                speed = 0;
                break;
            case MOVE_DIRECTION.LEFT:
                transform.localScale = new Vector3(-0.4f, 0.4f, 0.4f);
                speed = -1;
                break;
            case MOVE_DIRECTION.RIGHT:
                transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
                speed = 1;
                break;
        }
        rigidbody2D.velocity = new Vector2(speed, rigidbody2D.velocity.y);
    }
    bool IsGround()
    {
        Vector3 startVec = transform.position + transform.right * 0.6f* transform.localScale.x;
        Vector3 endVec = startVec - transform.up * 0.6f;
        Debug.DrawLine(startVec, endVec);
        return Physics2D.Linecast(startVec, endVec, blockLayer);
    }

    void ChangeDirection()
    {
        if (moveDirection == MOVE_DIRECTION.RIGHT)
        {
            // ç∂Ç…à⁄ìÆ
            moveDirection = MOVE_DIRECTION.LEFT;
        }
        else
        {
            // âEÇ…à⁄ìÆ
            moveDirection = MOVE_DIRECTION.RIGHT;
        }
    }
    }