using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Streak : Vision
{
    public static bool iHave;

    public static int destroyedPlatform;

    
    private void Start()
    {
        destroyedPlatform = 0;
        iHave = false;
    }

    void Update()
    {
        streakCheck();
    }
    private void streakCheck()
    {
        if (destroyedPlatform > 2) iHave = true;
        else iHave = false;
    }


    protected override void iOnPlatform(Collider collider)
    {
        destroyedPlatform++;
    }
    protected override void iCollisionWithStreak(Collision collision)
    {
        destroyedPlatform++;   
        Invoke(nameof(breakStreak), 0.1f);
    }
    protected override void iOnGround(Collision collision)
    {
        breakStreak();
    }
    private void breakStreak()
    {
        destroyedPlatform = 0;
    }
}
