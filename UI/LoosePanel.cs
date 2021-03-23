using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoosePanel : UI
{
    public GameObject loosePanel;

    private void Start()
    {
        loosePanel.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (!Ball.liveFlag)
        {
            loosePanel.SetActive(true);
        }
    }
}
