using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverdedo : MonoBehaviour
{
    public LibPdInstance pd;
    public Transform dedo;
    public Transform plano;
    void Start()
    {
        
    }

    void Update()
    {
        float proximity = Vector3.Distance(dedo.position, plano.position);

        proximity /= 7.5f;

        proximity = 1.0f - proximity;

        if (proximity < 0.0f)
            proximity = 0.0f;

        pd.SendFloat("proximity", proximity);
    }
}
