using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundControlleracross: MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 defaultpass;
    public float limitacross;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        defaultpass = transform.position;
    }

    void Update()
    {
        rb.MovePosition(new Vector2(defaultpass.x + Mathf.PingPong(Time.time/speed, limitacross), defaultpass.y));
    }
}