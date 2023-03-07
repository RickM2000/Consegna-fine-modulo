using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public float threshold;

    // Start is called before the first frame update
     void FixedUpdate()
     {
        if(transform.position.y < threshold)
        {
            transform.position = new Vector3(14.8f, 1.32f, 0f);
        
        }

     }
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
