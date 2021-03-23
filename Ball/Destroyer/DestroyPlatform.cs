using UnityEngine;

public class DestroyPlatform : Vision
{
    Platform platform;
    bool allowDestroy = true;
    protected override void iOnPlatform(Collider collider)
    {
        if (allowDestroy) 
        destroyPlatform(collider);
    }

    protected override void iCollisionWithStreak(Collision collision)
    {
        powerDestroyPlatform(collision);
    }

    private void destroyPlatform(Collider other)
    {
        if (Ball.liveFlag)
        {
            Destroy(other.gameObject);
            Platform.countDestroyed++;
            Invoke(nameof(unlockCamera), 0.001f); //иначе (без задержки) небольшие беды с камерой если 
        }                      //одновременно сломать платформу и оттолкнуться от неё 
    }
    private void unlockCamera()
    {
        Follow.lockCamera = false;
    }

   
    private void allowDestr()
    {
        allowDestroy = true;
    }
    private void powerDestroyPlatform(Collision collision)
    {
        Invoke(nameof(unlockCamera), 0.001f);
        Platform.countDestroyed++;
        platform = collision.collider.gameObject.transform.parent.gameObject.GetComponent<Platform>();
        platform.powerDestroy();
        Streak.destroyedPlatform = 0;
        
    }
}
