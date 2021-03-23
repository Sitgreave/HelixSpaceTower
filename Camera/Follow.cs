using UnityEngine;


// BEGIN 2d_camerafollow
// Adjusts the camera to always match the Y-position of a target object,
// within certain limits.
public class Follow : MonoBehaviour
{
    public float smooth = 0.1f;//скорость сопровождения
    public GameObject target;//объект сопровождения
    static public bool lockCamera;
    private void Start()
    {
        lockCamera = true;
    }
    void FixedUpdate()
    {
        if (target != null && lockCamera != true)
        {
            Vector3 pos = new Vector3(target.transform.position.x, target.transform.position.y+80, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, pos, smooth);
        }
    }

}
   



// END 2d_camerafollow