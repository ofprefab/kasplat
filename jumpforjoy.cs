using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpforjoy : MonoBehaviour
{
    //script derived from class link https://github.com/naxwell/Atelier1/blob/master/jump.cs

    public float thrust = 2400f; //2 times more than mountainjump and 240 times more than jump
    public OVRPlayerController controller;



    // Start is called before the first frame update
    void Start()
    {

        controller = GetComponent<OVRPlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) && OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            controller.JumpForce = thrust;
            controller.Jump();
        }

    }
}