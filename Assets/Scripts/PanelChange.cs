using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelChange : MonoBehaviour
{
    public GameObject Panel;
    public GameObject subPanel;

    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(true);
        subPanel.SetActive(false);
    }

    // Update is called once per frame
    public void MainView()
    {
        Panel.SetActive(true);
        subPanel.SetActive(false);
    }

    public void SubView()
    {
        Panel.SetActive(false);
        subPanel.SetActive(true);
    }
}
