using System.Collections.Generic;
using UnityEngine;

public class SegmentHide : MonoBehaviour
{
    int index, count;
    public int minHideID, maxHideID, minHideCount, maxHideCount; 
    public List<GameObject> segments;
    public Material forTrap;
    public int minTrapId, maxTrapId,minTrapCount, maxTrapCount;
    private int indexTrap, countTrap;

    Vector3 upTrap;
    private void Start()
    {
        upTrap.y = 0.01f;
        count = Random.Range(minHideCount, maxHideCount);
        while (count != 0) //spawn free space
        {
            index = Random.Range(minHideID, maxHideID);
            segments[index].SetActive(false);
            count--;
        }

        countTrap = Random.Range(minTrapCount, maxTrapCount);
        while (countTrap != 0) //spawn trap
        {
            indexTrap = Random.Range(minTrapId, maxTrapId);
            if (segments[indexTrap].gameObject.activeSelf)
            {
                segments[indexTrap].tag = "Trap";
                segments[indexTrap].GetComponent<Renderer>().material = forTrap;
                segments[indexTrap].transform.position += upTrap;
                countTrap--;
            }
        }
    }
}
