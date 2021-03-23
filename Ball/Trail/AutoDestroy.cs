using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    public GameObject trail;
    private void Start()
    {
        Destroy(trail, 8);
    }
}
