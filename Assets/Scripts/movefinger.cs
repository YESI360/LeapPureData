using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movefinger : MonoBehaviour
{
    public Transform mover;
    public GameObject coso;
    public pdTest efectopd;
    void Start()
    {
        
    }


    void Update()
    {
        coso.transform.position = new Vector3(1, 1, 1);
    }




}
