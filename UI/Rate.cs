using UnityEngine;

public class Rate : MonoBehaviour
{
   public void RateIt()
    {
        Application.OpenURL("market://details?id=" + Application.identifier);
    }
}
