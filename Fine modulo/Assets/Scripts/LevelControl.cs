using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControl : MonoBehaviour
{
    public float Rotation = 50.0f;
    public Vector3 currentRotation;
    public Vector3 anglesToRotate;
    

    //imposto controllo di rotazione
    void Start()
    {
        // currentRotation = new Vector3(currentRotation.x % 360f, currentRotation.y % 360f, currentRotation.z % 360f);
        //// rotationY = Quaternion.AngleAxis(currentRotation.y, new Vector3(0f, 1f, 0f));


        //Quaternion rotationX = Quaternion.AngleAxis(currentRotation.x, new Vector3(1f, 0f, 0f));


        //Quaternion rotationZ = Quaternion.AngleAxis(currentRotation.z, new Vector3(0f, 0f, 1f));

        // this.transform.rotation = rotationY * rotationX * rotationZ;
    }

    // Update is called once per frame
    void Update()
    {
        // Quaternion rotationY = Quaternion.AngleAxis(anglesToRotate.y, new Vector3(0f, 1f, 0f));


        // Quaternion rotationX = Quaternion.AngleAxis(anglesToRotate.x, new Vector3(1f, 0f, 0f));


        // Quaternion rotationZ = Quaternion.AngleAxis(anglesToRotate.z, new Vector3(0f, 0f, 1f));

        // this.transform.rotation = rotationY * rotationX * rotationZ * this.transform.rotation;



        // if (Input.GetKey(KeyCode.A))
        // transform.Translate(Vector3.forward, Space.Self);

        //if (Input.GetKey(KeyCode.D))
        //  transform.Translate(Vector3.back, Space.Self);









    }


}
