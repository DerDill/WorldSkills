using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpawn : MonoBehaviour
{
    private float Speed = 3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Border"))
        {
            Destroy(gameObject);
        }
    }
}
