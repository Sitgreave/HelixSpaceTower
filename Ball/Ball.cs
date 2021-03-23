using UnityEngine;
public class Ball : Vision
{
   public static bool liveFlag = true;
    public static bool levelComplete;


    private void Start()
    {
        levelComplete = false;
        liveFlag = true;
    }

   
  

  
    protected override void iOnTrap(Collision collision)
    {
            liveFlag = false;
    }

    protected override void iOnFinish(Collider other)
    {
        PlatformGenerator.level++;
        levelComplete = true;
    }



}
