using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : Vision
{
    public List<AudioClip> audioClips;
    public AudioSource audioSource;
    public AudioSource audioDestroySource;

    int needSound = 1;
    Type soundType;


    bool speedSoundPlayed = false;
    bool cooldown;

    
    public Sprite onButtonSoundImage;
    public Sprite offButtonSoundImage;
    public Image nowImage;

    
    
    private void Start()
    {
        audioDestroySource.pitch = 1;
      needSound = PlayerPrefs.GetInt("soundState");
        if(needSound == 1)
        {
            nowImage.sprite = onButtonSoundImage;
        }
        else nowImage.sprite = offButtonSoundImage;
    }

    

    protected override void iOnGround(Collision collision)
    {

            playThis(Type.contact);

            audioDestroySource.pitch = 1;
            audioSource.pitch = Random.Range(0.85f, 1.1f);
    }


    protected override void iOnTrap(Collision collision)
    {
        playThis(Type.death);
    }

    protected override void iCollisionWithStreak(Collision collision)
    {
        playThis(Type.powerDestroy);
        audioDestroySource.pitch =1f;
    }

    protected override void iOnPlatform(Collider collider)
    {
        if(audioDestroySource.pitch < 1.3) audioDestroySource.pitch += 0.02f;
        playThis(Type.destroy);
    }

    private void playThis(Type soundType)
    {
        if (needSound == 1)
        {
            if (!cooldown)
            {
                cooldown = true;
                switch (soundType)
                {
                    case Type.contact: audioSource.PlayOneShot(audioClips[0]); break;
                    case Type.destroy:
                        audioDestroySource.PlayOneShot(audioClips[1]); break;
                    case Type.powerDestroy: audioSource.PlayOneShot(audioClips[2]); break;
                    case Type.death: audioSource.PlayOneShot(audioClips[3]); break;
                }
                Invoke("deCoolDown", .05f); 
            }
        }
    }
    void deCoolDown()
    {
        cooldown = false;
    }
    public enum Type
    {
        contact,
        destroy,
        powerDestroy,
        death,
    }


    public void soundMode()
    {
        if (needSound == 1)
        {
            needSound = 0;
            nowImage.sprite = offButtonSoundImage;
        }
        else
        {
            needSound = 1;
            nowImage.sprite = onButtonSoundImage;
        }
        PlayerPrefs.SetInt("soundState", needSound);
    }
}
