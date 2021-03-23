using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlBar : MonoBehaviour
{
    public Image bar;
    float fill;
    float quantity;
    int lastPlatform = 0;

    public Text levelNow;
    public Text levelNext;
    private void Start()
    {
        levelNow.text = PlatformGenerator.level.ToString();
        levelNext.text = (1+PlatformGenerator.level).ToString();
        fill = 0;
        quantity = 11 + PlatformGenerator.level * 1;
    }
    private void Update()
    {
        if (lastPlatform < Platform.countDestroyed)
        {
            fill += 100 / quantity / 100;
            bar.fillAmount = fill ;
            lastPlatform++;
        }
        
        
    }
}
