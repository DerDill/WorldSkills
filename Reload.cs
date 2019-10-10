using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Reload : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Lose;
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            PlayerRotation.Ammo = 4;
            Schet.Score = 0;
            Timer.Help = 0;
            Lose.SetActive(false);
        }
    }
}
