
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WinPanel : UI
{
    public GameObject winPanel;
    string record;
    int oldRecord;
   public Text recordText;
    private void Start()
    {
        winPanel.SetActive(false);
        StartCoroutine(myUpdate());
        oldRecord = Score.record;
    }


    IEnumerator myUpdate()
    {
        bool stop = false;

        while (!stop)
        {

            if (Ball.levelComplete)
            {
                if (!winPanel.activeSelf) winPanel.SetActive(true);
                
                if (oldRecord == Score.record)
                {
                    record = "";
                }
                else record = "New record! Score: " + Score.record.ToString();
                recordText.text = record;
                stop = true;
            }
            yield return new WaitForSeconds(1f);
        }
    }
}
