using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation2 : MonoBehaviour
{
    [SerializeField] Transform PoleTransform;
    private bool playerClicked = false;

    private float Y;
    public int speeds = 20;
    public void OnClick()
    {
        playerClicked = true;
    }
    public void BeforeClick()
    {
        playerClicked = false;
    }

    private void Update()
    {
        if (playerClicked == true && Ball.liveFlag)
        {
            Y -= Input.GetAxis("Mouse X") * speeds * Time.deltaTime;
        }
    }
    private void FixedUpdate()
    {
        if (playerClicked == true)
        {
            PoleTransform.rotation = Quaternion.Euler(0, Y, 0);
        }

        }
    }



