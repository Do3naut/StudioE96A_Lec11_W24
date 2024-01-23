using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Component references
    // TODO: create variable to store rigidbody of player (2D)


    [SerializeField] float speed = 5f;
    [SerializeField] float jumpHeight = 5f;

    //TODO: keep track of current horizontal movement direction


    //keep track of if the player is on the ground
    bool isGrounded = false;

    //TODO: keep track of which direction player is facing


    // Start is called before the first frame update
    void Start()
    {
        // TODO: Get references to the rigidbody attached to the current GameObject

    }

    // Update is called once per frame
    void Update()
    {
        Move(direction);

        // TODO: check conditions needed to flip player, and if so, flip player

    }

    void OnJump()
    {
        //if player is on the ground, jump
        //if (isGrounded)
        Jump();
    }

    private void Jump()
    {
        // TODO: change y velocity of player

    }

    void OnMove(InputValue moveVal)
    {
        // TODO: store direction input and store it to global variable

    }

    private void Move(float x)
    {
        // TODO: change x velocity of player
    }

    //commonly used function but not used in this case
    // void OnCollisionEnter(Collision collision)
    // {

    // }

    // void OnCollisionStay(Collision collision)
    // {
    //     //check if angle between normal vector of object of contact and up vector is less than 45 degrees
    //     //AKA if-statement is true if player is touching another object that is 0 to 45 degrees slope
    //     if (Vector3.Angle(collision.GetContact(0).normal, Vector3.up) < 45f)
    //         isGrounded = true;
    //     else
    //         isGrounded = false;
    // }

    // void OnCollisionExit(Collision collision)
    // {
    //     isGrounded = false;
    // }

    private void Flip()
    {
        // TODO: flip local scale of player and change global variable that stores which direction player is facing

    }
}
