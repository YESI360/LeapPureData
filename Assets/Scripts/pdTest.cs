using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pdTest : MonoBehaviour
{
    public int Up;
    public int Down;

    public LibPdInstance pdtest;
    public GameObject cylinder;
    public AudioSource PDSound;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SoundUp()
    {
        cylinder.transform.localScale = new Vector3(Up, Up, Up) * Time.deltaTime;
        pdtest.SendFloat("proximity", Up);
    }

    public void SoundDown()
    {
        cylinder.transform.localScale = new Vector3(Down, Down, Down) * Time.deltaTime;
        pdtest.SendFloat("proximity", Down);
    }
}
