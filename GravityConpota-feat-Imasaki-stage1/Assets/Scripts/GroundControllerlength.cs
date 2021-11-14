using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundControllerlength : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 defaultpass;
    public float limitlength;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        defaultpass = transform.position;
    }

    void FixedUpdate()
    {
        rb.MovePosition(new Vector2(defaultpass.x, defaultpass.y + Mathf.PingPong(Time.time/speed,limitlength)));
        StartCoroutine("coRoutine");
    }

    IEnumerator coRoutine()
    {
        yield return new WaitForSeconds(1.0f);
    }
}
