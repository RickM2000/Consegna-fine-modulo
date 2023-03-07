using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] float speed = 5f;
   [SerializeField] float jumpHeight = 5f;
   [SerializeField] Rigidbody rb;
    [SerializeField] LayerMask groundMask;

    public int score = 0;


    bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
     

        //Debug.Log(rb.mass);
    }

    
    void Update()
    {
        //Polling input
      float xMove =  Input.GetAxis("Horizontal");
        

        //costruisco il vettore movimento 
        Vector3 velocity = (Vector3.right * xMove  ).normalized * speed;


        //applico la mia velocity verticale 
        velocity.y = rb.velocity.y;

        

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            //  rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            velocity.y += Mathf.Sqrt(jumpHeight * -2f * (-9.81f));
        }
      // applico il vettore movimento al rigidbody
        rb.velocity = velocity;
    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Ground"))
        {
            isGrounded = true;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("Ground"))
        {
            isGrounded = false;

        }
    }
}




