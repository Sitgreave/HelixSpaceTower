using System.Collections;
using UnityEngine;

public class SaveState : UI
{
    private bool iSaved;
    private void Awake()
    {
        //resumePrefs();
        //PlatformGenerator.level = 117;
        //PlayerPrefs.SetInt("level",);
        loadSave();

    }
    private void Start()
    {
        iSaved = false;
    }
    private void Update()
    {
        if (Ball.levelComplete && !iSaved)
        {
            savePPrefs();
            iSaved = true;
        }
    }

   
        public void savePPrefs()
         {
        PlayerPrefs.SetInt("record", Score.record);
        PlayerPrefs.SetInt("level", PlatformGenerator.level);
        }
    private void loadSave()
    {
        PlatformGenerator.level = PlayerPrefs.GetInt("level");
        Score.record = PlayerPrefs.GetInt("record");
    }

    public void restartPrefs()
    {
        PlayerPrefs.SetInt("record", Score.record = 0);
        PlayerPrefs.SetInt("level", PlatformGenerator.level = 0);
        RestartLevel();
    }
}
