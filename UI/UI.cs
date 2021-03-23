
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class UI : MonoBehaviour
{
   protected bool pause;

    private void Start()
    {
        Ball.levelComplete = false;
    }
    protected void Stop()
    {
        if (!pause)
        {
            Time.timeScale = 0;
            pause = true;
        }
    }

    protected void Go()
    {
        if (pause)
        {
            Time.timeScale = 1;
            pause = false;
        }
    }


    public void RestartLevel()
    {
        SceneManager.LoadScene("1L", LoadSceneMode.Single);
    }


}
