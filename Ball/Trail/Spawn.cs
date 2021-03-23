using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : Vision
{
    public Transform myTransform;
    public GameObject trail;
    Vector3 trailTransform;
    Quaternion trailRotation;
    public TrailRenderer trailRenderer;

    public Material trailStreak;
    public Material trailBasic;

    public ParticleSystem particle;
    bool allow;

    private void Start()
    {
        allow = true;
    }

    private void Update()
    {
        if (Streak.iHave)
        {
            if (trailRenderer.material != trailStreak)
            {
                trailRenderer.material = trailStreak;

                // trailRenderer.time = 0.5f;
            }
        }
        else
        {
            if (trailRenderer.material != trailBasic)
            {
                trailRenderer.material = trailBasic;

                // trailRenderer.time = 0.5f;
            }
        }
    }
    protected override void iOnGround(Collision collision)
    {
        if (allow)
        {
            trailTransform = myTransform.position;
            trailTransform.y += 0.3f;
            trailRotation = Quaternion.Euler(90, 0, Random.Range(-180, 180));
            Instantiate(trail, trailTransform, trailRotation, collision.transform);
            allow = false;
            Invoke(nameof(allowInstantiate), 0.3f);

        }
    }

    protected override void iOnPlatform(Collider collider)
    {
        particle.transform.position = myTransform.position;
        //  particle.transform.parent = collision.transform;
        particle.Play();
    }
    private void allowInstantiate()
    {
        allow = true;
    }


}
