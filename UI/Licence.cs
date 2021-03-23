
using UnityEngine;

public class Licence : MonoBehaviour
{
    public GameObject LicPan;

    private void Start()
    {
        LicPan.SetActive(false);
    }


    public void panActive()
    {
        if (LicPan.activeSelf)
        {
            LicPan.SetActive(false);
        }
        else LicPan.SetActive(true);
    }

    public void linkBut()
    {
        Application.OpenURL("https://github.com/Sitgreave/links/blob/main/licence.txt");
    }
}
