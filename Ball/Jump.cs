using System.Collections;
using UnityEngine;

public class Jump : Vision
{
    [SerializeField] int force;
    [SerializeField] Rigidbody ballRigidbody;
    bool ignoreNextCollision = false;


    private void Start()
    {
        ForceBallDown();
    }

    protected override void iOnGround(Collision collision)
    {
        if (!ignoreNextCollision && !Streak.iHave && Ball.liveFlag)
        {
            JumpUpDown();
            lockCam();
        }
    }
    protected override void iCollisionWithStreak(Collision collision)
    {
        ForceBallDown();

    }


    private void JumpUpDown()
    {
        ForceBallUp();
        ignoreNextCollision = true;
        Invoke(nameof(AllowCollision), 0.2f);
        Invoke(nameof(ForceBallDown), 0.4f);
    }
    private void ForceBallUp()
    {
        ballRigidbody.velocity = Vector3.zero;
        ballRigidbody.AddForce(Vector3.up * (force-15), ForceMode.VelocityChange);
    }

    
    private void ForceBallDown()
    {
        ballRigidbody.velocity = Vector3.zero;
        ballRigidbody.AddForce(Vector3.down * (force), ForceMode.VelocityChange);
    }



    private void AllowCollision()
    {
        ignoreNextCollision = false;
      
    }
    private void lockCam()
    {
        Follow.lockCamera = true;
    }


}
