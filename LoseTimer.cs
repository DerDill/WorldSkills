using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoseTimer : MonoBehaviour
{
    public Text count;
    private Text Mycount;
    // Start is called before the first frame update
    void Start()
    {
        Mycount = GetComponent<Text>();
        Mycount.text = count.text;
    }

    // Update is called once per frame
    void Update()
    {
        Mycount.text = count.text;
    }
}
