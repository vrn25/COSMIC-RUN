﻿using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float sideforce = 500f;

    // Start is called before the first frame update
    /*void Start()
    {
        Debug.Log("Hello World");
        rb.AddForce(0,200,500);
    }*/

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0,0, sideforce * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -sideforce * Time.deltaTime);
        }

        if (rb.position.x < -12f || rb.position.x > 16f)
        {
            FindObjectOfType<Gamemanager>().Endgame();
        }
    }
}
