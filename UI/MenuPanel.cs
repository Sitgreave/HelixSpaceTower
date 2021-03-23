using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPanel : UI
{
    public GameObject menuPanel;
    public Text recordText;
    private void Start()
    {

        menuPanel.SetActive(true);  
    }

    public void StartGame()
    {
        menuPanel.SetActive(false);
    }

}
