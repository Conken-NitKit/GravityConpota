using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasyChange : MonoBehaviour
{
    public void OnClickStartButton(){
        SceneManager.LoadScene("Easy");
    }
}
