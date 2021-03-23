using UnityEngine;

public abstract class Vision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (!Streak.iHave)
        {
            if (isGround(collision)) iOnGround(collision);
            else if (isTrap(collision)) iOnTrap(collision);
        }
             else
            {
                if (isGround(collision) || isTrap(collision)) iCollisionWithStreak(collision); 
            }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isPlatform(other))
        {
            iOnPlatform(other);
        }
        if (isFinish(other))
        {
            iOnFinish(other);
        }
    }
    private bool isGround(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            return true;
        else return false;
    }

    private bool isFinish(Collider other)
    {
        {
            if (other.gameObject.CompareTag("Finish"))
                return true;
            else return false;
        }   
    }
    private bool isPlatform(Collider collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
            return true;
        else return false;
    }

    private bool isTrap(Collision collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
            return true;
        else return false;
    }
    protected virtual void iOnGround(Collision collision)
    {
        return;
    }
    protected virtual void iOnPlatform(Collider collider)
    {
        return;
    }
    protected virtual void iCollisionWithStreak(Collision collision)
    {
        return;
    }
    protected virtual void iOnTrap(Collision collision)
    {
        return;
    }
    protected virtual void iOnFinish(Collider other)
    {
        return;
    }
}
