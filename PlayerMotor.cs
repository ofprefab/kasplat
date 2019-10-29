using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerMotor : MonoBehaviour
{
    //code derived from https://gamedev.stackexchange.com/questions/140502/unity-3d-c-can-t-move-through-the-air-while-jumping

    private CharacterController controller;

    public Rigidbody rb;

    public float speed = 5.0F;
    public float jumpSpeed = 0.01F;
    public float gravity = 0.001F;
    public float airFriction = 2.55f;

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;
        if (controller.isGrounded)
        {
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        else
        {
            moveDirection *= airFriction;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}