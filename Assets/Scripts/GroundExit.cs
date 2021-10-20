using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollider: MonoBehaviour
{
    private string groundTag = "Ground";
    private bool isGroundExit;

    public bool ExitGround()
    {
        if (isGroundExit)
        {
            return true;
        }
        else return false;
    
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == groundTag)
        {
            isGroundExit = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        isGroundExit = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
