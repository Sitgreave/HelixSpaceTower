using System.Collections;

using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    int lastPlatform;
    readonly int startIncrease = 1;
    int score, increase, multiply;
    public static int record = 0;
    public Text floatText;
    public Transform floatContainer;
    private void Start()
    {
        increase = startIncrease + PlatformGenerator.level;
        StartCoroutine(myUpdate());
        lastPlatform = 0;
    }


    private void recordUpdate()
    {
        if (score > record)
        {
            record = score;

        }
    }

    private void scoreIncreace()
    {
        multiply = Streak.destroyedPlatform;
        if (multiply == 0) multiply = 1;
        score += increase * multiply;
        lastPlatform++;
        scoreText.text = score.ToString();
        floatText.text = "+" + increase * multiply;
        Instantiate(floatText, floatContainer);
    }
    IEnumerator myUpdate()
    {
        bool stop = false;

        while (!stop)
        {
            if (lastPlatform < Platform.countDestroyed)
            {
                scoreIncreace();
            }

            if (Ball.levelComplete)
            {
                recordUpdate();
                stop = true;
            }
            yield return new WaitForSeconds(.1f);
        }
    }
}
