using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour

{
    [SerializeField] int day = 9;
    float myFloat = 4.5f;
    bool myBool = true;
    string myString = "asfnkasnc";


    public LayerMask mask;

    // Start is called before the first frame update
    void Start()
    {
          // Debug.Loggi("Oggi è il giorno " + 8 + " febbraio");
        Debug.Log($"Oggi è il giorno {day} febbraio");

    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
