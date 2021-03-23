using UnityEngine;

public class Platform: MonoBehaviour
{
    Transform myTransform;
    Vector3 rotateRandomize; 
    public Animator animator;
    public static int countDestroyed;
    GameObject platform;
    
    private void Awake()
    {
        platform = gameObject;
        myTransform = GetComponent<Transform>();
        countDestroyed = 0;
    }

    private void Start()
    {
        rotateRandomize.x= Random.Range(-10, 10);
        //countDestroyed = 0;
    }


    public void powerDestroy() //destroy with streak
    {
        
        Destroy(platform, 1);
        animator.SetBool("destroy", true);
        myTransform.rotation = Quaternion.Euler(rotateRandomize); //for visual variety of animation    
    }
}
