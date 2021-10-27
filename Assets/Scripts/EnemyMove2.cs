using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove2 : MonoBehaviour
{
    private Vector3 Enemy1;

    void Start()
    {
        Enemy1 = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * 0.50f + Enemy1.x, Enemy1.y, Enemy1.z);
    }
}