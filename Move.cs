using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float Speed = 7;
    private bool Flag;
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Speed * Time.deltaTime);
    }
  
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Border"))
        {
            if(Flag == false)
            {
                PlayerRotation.Ammo -= 1;
                Destroy(gameObject);
               
            }
            Flag = false;

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Schet.Score += 10;
            Destroy(collision.gameObject);
            Flag = true;
            Destroy(gameObject);
        }
    }
}
