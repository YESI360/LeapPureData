using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverdedo1 : MonoBehaviour
{
    public LibPdInstance pdtest;
    public Transform dedo;

    public int Up;
    public int Down;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        dedo.position = new Vector3(dedo.position.x, dedo.position.y, dedo.position.z);
        //dedo.position = new Vector3(Up, Down, dedo.position.z);
        /*
        float proximity = Vector3.Distance(dedo.position, plano.position);

        proximity /= 7.5f;

        proximity = 1.0f - proximity;

        if (proximity < 0.0f)
            proximity = 0.0f;
        pdtest.SendFloat("proximity", proximity);
        */

        pdtest.SendFloat("proximity", dedo.position.x);
        pdtest.SendFloat("proximity", dedo.position.y);

    }

    /*
    public void arriba ()
    {
        pdtest.SendFloat("proximity", dedo.position.x);
    }
    public void abajo()
    {
        pdtest.SendFloat("proximity", dedo.position.y);
    }
    */
}
