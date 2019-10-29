using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mountainjump : MonoBehaviour
{
    //script derived from class link https://github.com/naxwell/Atelier1/blob/master/jump.cs

    public float thrust = 1200f; //3 times more than bigjump, and 120 times more than jump
    public OVRPlayerController controller;



    // Start is called before the first frame update
    void Start()
    {

        controller = GetComponent<OVRPlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            controller.JumpForce = thrust;
            controller.Jump();
        }

    }
}