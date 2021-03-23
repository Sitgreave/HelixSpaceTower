using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    static public int level = 0;
    public float intervalY;

    private Vector3 distance;
    Transform myTransform;

     int quantity = 10;
    public List<GameObject> platform;
    readonly List<GameObject> platforms = new List<GameObject>();
    public GameObject finish;

    int counter;

    private void Awake()
    {
        myTransform = GetComponent<Transform>();
        distance = myTransform.position;
       
    }


    private void Start()
    {
        quantity += level;
        spawnPlatform();
        counter = 0;
        if (quantity > 15) deactivePlatform();
    }

    void spawnPlatform()
    {
        for (int i = 0; i < quantity; i++)
        {

            distance.y -= intervalY;
            platforms.Add(Instantiate(platform[level], distance, myTransform.rotation, myTransform));
            platforms[i].name = "Platform_" + i.ToString();
        }
        distance.y -= intervalY;
        platforms.Add(Instantiate(finish, distance, myTransform.rotation, myTransform));
    }

    private void Update()
    {
       if( counter != quantity - 15 && quantity > 15)
        {
            activePlatform();
        }
    }


    private  void deactivePlatform()
    {
        for(int i = 15; i < quantity; i++)
        {
            platforms[i].SetActive(false);
        }
    }
    private void activePlatform()
    {

            if (Platform.countDestroyed == counter)
            {
                platforms[15 + counter].SetActive(true);
                counter++;
            }
        
    }
}
