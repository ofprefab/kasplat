
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigjump : MonoBehaviour
{
    //script derived from class link https://github.com/naxwell/Atelier1/blob/master/jump.cs

    public float thrust = 400f; // 40 times the jump originally meant to be only 4 times more
    public OVRPlayerController controller;



    // Start is called before the first frame update
    void Start()
    {

        controller = GetComponent<OVRPlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            controller.JumpForce = thrust;
            controller.Jump();
        }

    }
}
