using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//         XForce=new Vector3(0.2f,0f,0f);
//         ZForce=new Vector3(0f,0f,0.2f);

//         Xkp=KeyCode.RightArrow;
//         Xkn=KeyCode.LeftArrow;
//         Zkp=KeyCode.UpArrow;
//         Zkn=KeyCode.DownArrow;


public class AddVelocity : MonoBehaviour
{
    [SerializeField] float force;
    Vector3 XForce;
    KeyCode Xkp = KeyCode.RightArrow;
    KeyCode Xkn = KeyCode.LeftArrow;

    Vector3 ZForce;
    KeyCode Zkp = KeyCode.UpArrow;
    KeyCode Zkn = KeyCode.DownArrow;
    // Start is called before the first frame update
    void Start()
    {
        XForce = new Vector3(force, 0f, 0f);
        ZForce = new Vector3(0f, 0f, force);

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(Xkp))
        {
            GetComponent<Rigidbody>().velocity += XForce;
        }
        if (Input.GetKey(Xkn))
        {
            GetComponent<Rigidbody>().velocity -= XForce;
        }

        if (Input.GetKey(Zkp))
        {
            GetComponent<Rigidbody>().velocity += ZForce;
        }
        if (Input.GetKey(Zkn))
        {
            GetComponent<Rigidbody>().velocity -= ZForce;
        }

    }
}
