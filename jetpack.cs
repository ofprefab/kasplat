using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jetpack : MonoBehaviour
{

    //script derived from https://www.youtube.com/watch?v=2merbiVLv28

    //couldn't get it working, the last minute of video

    public float speed = 3;

    public CharacterController CharCont;
    public OVRPlayerController OPC;

    public Vector3 currentVector = Vector3.up;

    public float CurrentForce = 0;

    public float MaxForce = 5;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger) && MaxForce > 0)
        {
            MaxForce -= Time.deltaTime;

            if (CurrentForce < 1)
                CurrentForce += Time.deltaTime * 10;
            else
                CurrentForce = 1;

        }

        if (MaxForce < 0 && CurrentForce > 0)
        {
            CurrentForce -= Time.deltaTime;
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger) && MaxForce > 0)
        {
            if (CurrentForce > 0)
                CurrentForce -= Time.deltaTime;
            else
                CurrentForce = 0;

            if (MaxForce < 5)
                MaxForce += Time.deltaTime;
            else
                MaxForce = 5;
        }

        if (CurrentForce > 0)
            UseJetPack();
    }

    public void UseJetPack()
    {

        currentVector = Vector3.up;

        currentVector += transform.right * Input.GetAxis("Horizantal");
        currentVector += transform.forward * Input.GetAxis("Vertical");

        CharCont.Move((currentVector * speed * Time.fixedDeltaTime - CharCont.velocity * Time.fixedDeltaTime) * CurrentForce);

    }
}
