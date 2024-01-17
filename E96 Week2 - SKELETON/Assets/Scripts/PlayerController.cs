using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: import UnityEngine.InputSystem and UnityEngine.SceneManagement


public class PlayerController : MonoBehaviour
{
    // TODO: add component references


    // TODO: add variables for speed, jumpHeight, and respawnHeight

    // TODO: add variable to check if we're on the ground


    // Start is called before the first frame update
    void Start()
    {
        // TODO: Get references to the components attached to the current GameObject

    }

    // Update is called once per frame
    void Update()
    {
        // TODO: check if player is under respawnHeight and call Respawn()

    }

    void OnJump()
    {
        // TODO: check if player is on the ground, and call Jump()

    }

    private void Jump()
    {
        // TODO: Set the y velocity to some positive value while keeping the x and z whatever they were originally

    }

    void OnMove(InputValue moveVal)
    {
        //TODO: store input as a 2D vector and call Move()

    }

    private void Move(float x, float z)
    {
        // TODO: Set the x & z velocity of the Rigidbody to correspond with our inputs while keeping the y velocity what it originally is.

    }

    void OnCollisionEnter(Collision collision)
    {
        // This function is commonly useful, but for our current implementation we don't need it

    }

    void OnCollisionStay(Collision collision)
    {
        // TODO: Check if we are in contact with the ground. If we are, note that we are grounded

    }

    void OnCollisionExit(Collision collision)
    {
        // TODO: When we leave the ground, we are no longer grounded

    }

    private void Respawn()
    {
        // TODO: reload current scene

    }
}
