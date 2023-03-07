using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    float turnspeed = 100.0f;
    float movespeed = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * turnspeed * Input.GetAxisRaw("Vertical") * Time.deltaTime);
    }
}
