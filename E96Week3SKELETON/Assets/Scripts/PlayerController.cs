using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Component references
    // TODO: create variable to store rigidbody of player (2D)
    // TODO: create variable storing the Animator


    [SerializeField] float speed = 5f;
    [SerializeField] float jumpHeight = 5f;

    //TODO: keep track of current horizontal movement direction


    //keep track of if the player is on the ground
    bool isGrounded = false;

    //TODO: keep track of which direction player is facing


    // Start is called before the first frame update
    void Start()
    {
        // TODO: Get references to the rigidbody and animator attached to the current GameObject

    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Pass in the proper direction that the player should move in
        Move(0);

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

        // TODO: Here, we can handle animation transitioning logic
    }

    private void Flip()
    {
        // TODO: flip local scale of player and change global variable that stores which direction player is facing

    }

    // TODO: Week 3's assignment needs a couple of extra functions here...
}
