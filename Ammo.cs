using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public GameObject[] lifes;
   

    // Update is called once per frame
    void Update()
    {
        for ( int num = 0; num < lifes.Length; num++)
        {
            if (PlayerRotation.Ammo < num + 1)
            {
                lifes[num].SetActive(false);
            }
           else
            {
                lifes[num].SetActive(true);
            }
        }
    }
}
