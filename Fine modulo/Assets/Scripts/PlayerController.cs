using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] float speed = 5f;
    CharacterController controller;

    public Transform TerraCheck;
    float distanzaTerra = 0.01f;
    public LayerMask TerraMask;
    bool toccaterra;
    Vector3 Velocity;

        float Gravity = -9.8f;
        float HigthJump = 3f;

    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }



    private void FixedUpdate()
    {
        
    }
    
    void Update()
    {
      float xMove =  Input.GetAxis("Horizontal");
      float yMove =  Input.GetAxis("Vertical");
        Vector3 movimento = transform.right * xMove + transform.forward * yMove;
        controller.Move(movimento * Time.deltaTime * speed);
      
        


        Vector3 playerMovement = Vector3.right * xMove * speed;
        transform.position += playerMovement;

        toccaterra = Physics.CheckSphere(TerraCheck.position, distanzaTerra, TerraMask);


        if (toccaterra && Velocity.y < 0)
        {
            Velocity.y = -10f;
        }
        if (Input.GetButtonDown("Jump") && toccaterra)
        {
            Velocity.y = Mathf.Sqrt(Gravity = HigthJump * -2f);
        }

        Velocity.y += Gravity* Time.deltaTime;
        controller.Move(Velocity * Time.deltaTime);
    }
}
//movimento del personaggio
// costruisci il vettore movimento 
//applico la mia velocity verticale al vettore movimento
