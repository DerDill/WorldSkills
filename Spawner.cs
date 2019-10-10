using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    private float Speed = 3;
    public GameObject Hit;
    private Sprite[] Hits;
    public GameObject Canvas;
    void Start()
    {
        Hits = Resources.LoadAll<Sprite>("Hits");
        StartCoroutine(Spawn());

        
    }

    // Update is called once per frame
  IEnumerator Spawn()
    {
        while(true)
        {

            var tmp = Instantiate(
                Hit,
                transform.position,
                Quaternion.Euler(new Vector3(0, 0, 0))
                );
            tmp.transform.SetParent(Canvas.transform);
            tmp.transform.localScale = new Vector3(1f, 1f, 1f);

            Image image = tmp.GetComponent<Image>();
            image.sprite = Hits[Random.Range(0, 6)];



            yield return new WaitForSeconds(Random.Range(1f, 3f));
        }
        

    }

    
}
