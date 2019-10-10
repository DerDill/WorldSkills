using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    private static float help; 
    public static float Help
    {
        get
        {
            return help; 

        }
        set
        {
            help = value;
        }

    }
    public static bool Work; 

    public GameObject Panel;
    Text text;
    void Start()
    {
        text = Panel.GetComponentInChildren<Text>();
        Work = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Work == true)
        {
            Help += Time.deltaTime;

            int seconds = (int)Help;
            int min = seconds / 60;
            int sec = seconds % 60;


            text.text = min.ToString() + ":";
            if (sec < 10)
            {
                text.text += "0";

            }
            text.text += sec.ToString();
        }
    }
}
