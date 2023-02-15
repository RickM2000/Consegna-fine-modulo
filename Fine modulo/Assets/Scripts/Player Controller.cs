using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
   [SerializeField] float speed = 5f;
    Rigidbody rb;
   
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
        Vector3 palyerMovement = (Vector3.right * xMove + Vector3.forward * zMove).normalized * spedd * Time.deltaTime;

            //tranform.position += palyerMovement;


            //Applico la transazione
            //Transform.Translate(palyerMovement, Space.World);

            rb.velocity = playerMoevement;
    }

    public string LogDay(int dayToLog)
    {

        
        dayToLog = dayToLog + 1;

        string massage Of

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
        Debug.Log(collision.transform.name);


    }

    private void OnCollisionStay(Collision collision)
    {
        
    }
}
