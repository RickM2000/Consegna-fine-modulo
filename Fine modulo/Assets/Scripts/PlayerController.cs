using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] float speed = 5f;
   [SerializeField] float jumpForce = 5f;
   [SerializeField] Rigidbody rb;
   [SerializeField] CharacterController cc;

    public int score = 0;

        int a = 3;

    bool isGrounded = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cc = GetComponent<CharacterController>();

        //Debug.Log(rb.mass);
    }

    
    void Update()
    {
        //Polling input
      float xMove =  Input.GetAxis("Horizontal");
        float zMove = Input.GetAxis("Vertical");

        //costruisco il vettore movimento 
        Vector3 playerMovement = (Vector3.right * xMove + Vector3.forward * zMove).normalized * speed;


        //applico la mia velocity verticale 
        playerMovement.y = rb.velocity.y;

        // applico il vettore movimento al rigidbody
        rb.velocity = playerMovement;

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            playerMovement.y += Mathf.Sqrt(jumpForce * -2f * (-9.81f));
        }
      
    }
    private void FixedUpdate()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.name);

    }
    private void OnCollisionExit(Collision collision)
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        
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



//movimento del personaggio
// costruisci il vettore movimento 
//applico la mia velocity verticale al vettore movimento
