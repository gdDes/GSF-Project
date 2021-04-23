using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    /// <summary>
    //  Contribution: Coded the movement for the character.
    //  Feature: Character Movement.
    //	Date:	Start Date: 04/23/2021  End Date: 04/23/2021
    //  References: Unity Offical Scripting
    //	Links: Technologies, U. (n.d.). CharacterController.Move. Unity. https://docs.unity3d.com/ScriptReference/CharacterController.Move.html. 
    /// </summary>

    //variables
    private CharacterController controller;
    private Vector3 velocity;
    private bool isPlayerOnGround;
    private float speed = 5.0f;
    private float jumpHeight = 2.0f;
    private float gravity = -10.0f;
    private Rigidbody rigidBody { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
        rigidBody = GetComponent<Rigidbody>();

        rigidBody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
    }

    // Update is called once per frame
    void Update()
    {
        isPlayerOnGround = controller.isGrounded;
        if(isPlayerOnGround && velocity.y < 0)
        {
            velocity.y = 0.0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * speed);

        if(move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        if(Input.GetKeyDown(KeyCode.Space) && isPlayerOnGround)
        {
            velocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
