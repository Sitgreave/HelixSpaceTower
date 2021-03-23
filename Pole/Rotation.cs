using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] Transform PoleTransform;
    private bool playerClicked = false;

    private float Y;
    public int speeds;
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

            float pointer_x = Input.GetAxis("Mouse X");
            if (Input.touchCount > 0)
            {
                pointer_x = Input.touches[0].deltaPosition.x;
                Y -= pointer_x * speeds * Time.deltaTime;
        }
       
    }
    private void FixedUpdate()
    {
        if (Ball.liveFlag)
        {
            PoleTransform.rotation = Quaternion.Euler(0, Y, 0);
        }
    }
}



