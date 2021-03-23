using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSwitcher : Vision
{
    public Animator animator;

    protected override void iOnGround(Collision collision)
    {
        animator.SetBool("streak", false);
    }

    protected override void iOnPlatform(Collider collider)
    {
        animator.SetBool("streak", true);
    }

    protected override void iCollisionWithStreak(Collision collision)
    {
       // animator.SetBool("streak", false);
    }

    protected override void iOnTrap(Collision collision)
    {
        animator.SetBool("dead", true);
    }
    

}
