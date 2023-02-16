using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
   [SerializeField] float speed = 5f;
   [SerializeField] float jumpHeigth = 5f;
   [SerializeField] Rigidbody rb;
   [SerializeField] LayerMask groundMask;

    public int score = 0

    bool isGrounded = false

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        //Polling input
        float xMove = Input.GetAxisRaw("Horizontal");
        float xMove = Input.GetAxisRaw("Vertical");


        //Costruisco il vettore movimento
        Vector3 velocity = (Vector3.right * xMove + Vector3.forward * zMove).normalized * spedd * Time.deltaTime;

        //Applico la mia velocity verticale al vettore movimento 
        velocity = rb.velocity.y;

       

        if (Input.GetButtonDown("Jump")) && isGrounded)
        {
            //  rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            velocity.y += Math.Sqrt(jumpHeigth * -2f * (-9.81f));
        }

        //applico il vettore movimento al rigibody
        rb.velocity = velocity;


       Debug.DrawRay(tranform.position, transform.forward * 10, Color.cyan);
       if(Physics.Raycast(tranform.position, tranform.forward, 10, groundMask))
        {
            Debug.Log("Colpito");
        }
    }

    private void FixedUpdate()
    {
        
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Collectible"))
        {
            score++;
            Debug.Log(score)
            Destroy(other.gameObject);
        }

        if (other.transform.CompareTag("Ground"))
        {
            isGrounded = true;
        }



    }
    private void OnTriggerExit(Collider other)
    {
        if(other.transform.CompareTag("Ground"))
        {
            isGrounded = false;
        }
        
    }
}
