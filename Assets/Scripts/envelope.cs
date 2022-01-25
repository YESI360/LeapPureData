using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class envelope : MonoBehaviour
{
    public LibPdInstance puredata;
    public Transform mover;
    void Start()
    {
        puredata.Bind("AmplitudEnvelope");
    }

    public void FloatReceive (string sender, float value)
    {
        if (sender == "AmplitudEnvelope")
        {
            mover.position = new Vector3(mover.position.x, 0.5f + value, mover.position.z);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
