using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Schet : MonoBehaviour
{
    private static int score;
    public static int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
        }
    }
    public GameObject Panel;
    Text text;
    void Start()
    {
        text = Panel.GetComponentInChildren<Text>();
        Score = 0;
        text.text = Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = Score.ToString();
    }
}
