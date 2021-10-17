using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    private bool firstPush = false;
    // Start is called before the first frame update
    public void PressStart()
    {
        Debug.Log("Press Start!");
        if(!firstPush)
        {
            Debug.Log("Go Next Scene!");
            // 次シーンへ行く命令を書く

            firstPush = true;
        }
    }
}
