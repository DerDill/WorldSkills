using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float offset;
    public GameObject Bullet;
    public Transform posit;
    public GameObject Canvas;
    private float TimeShot;
    public float startTime;
    private static int ammo;
    public static int Ammo
    {
        get
        {
            return ammo;
        }
        set
        {
            ammo = value;
        }
    }
    public GameObject Lose;

    private void Start()
    {
        Ammo = 4;
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);
        if (TimeShot <= 0 && Ammo > 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                var tmp = Instantiate(Bullet, posit.position, transform.rotation);
                tmp.transform.SetParent(Canvas.transform);
                tmp.transform.localScale = new Vector3(1f, 1f, 1f);
                TimeShot = startTime;
            }
        }
        else
        {
            TimeShot -= Time.deltaTime;
        }
       if(Ammo <= 0)
        {
            Timer.Work = false;
            Lose.SetActive(true);

        }
    }
    
}
