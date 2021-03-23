using UnityEngine.Advertisements;
using UnityEngine;

public class Ads : Vision
{
    private bool adsTriggered;
    private bool isPremium;

    private bool wasRespawned = false;
    public Animator animator;
    public GameObject respawnPanel;
    public GameObject losePanel;
    int deathToAds = 5;
    public Material normPlatform;
    GameObject collision1;
    bool allow;
    void Start()
    {
        allow = true;
        Debug.Log(deathToAds);
        respawnPanel.SetActive(false);
        deathToAds = PlayerPrefs.GetInt("deathToAds");
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("4056045", false);
        }
    }

    protected override void iOnTrap(Collision collision)
    {
        collision1 = collision.gameObject;
        animator.SetBool("dead", true);
  
        //collision.gameObject.GetComponent<Material>().c/ = normPlatform;
        if (allow == true)
        {
            deathToAds--;
            Debug.Log(deathToAds);
            if (Advertisement.IsReady() && deathToAds <= 0)
            {
                Advertisement.Show("video");
                deathToAds = 5;
            }
            if (!wasRespawned)
            {
                respawnPanel.SetActive(true);
            }
            
            allow = false;
            Invoke("allowContact", 0.3f);
        }
        PlayerPrefs.SetInt("deathToAds", deathToAds);
    }

    private void allowContact()
    {
        allow = true;

    }
    public void ContinueWithAds()
    {
        collision1.tag = "Ground";
        Advertisement.Show("rewardedVideo");
        wasRespawned = true;
        respawnPanel.SetActive(false);
        losePanel.SetActive(false);
        
        Ball.liveFlag = true;
        animator.SetBool("dead", false);

        transform.position += Vector3.up * 2;
    }
}
