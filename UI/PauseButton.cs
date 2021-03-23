using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : UI
{
    public GameObject PausePanel;
 

     private void Update()
    {
        if(Ball.liveFlag == false)
        {
           // if( pause == false)
           //  Pause();
        }
    }
   
    public void Pause()
    {
        if (pause == false)
        {
            Stop();
            PausePanel.SetActive(true);
        }
        else
        {
            Go();
            PausePanel.SetActive(false);
        }
    }


}
