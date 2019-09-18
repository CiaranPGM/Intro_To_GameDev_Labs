using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Vector3 movement;
    private float movementSqrMagnitute;
    public float walkSpeed = 1.5f;

    // Update is called once per frame
    void Update()
    {
        GetMovementInput();
        CharacterPosition();
        CharacterRotation();
        WalkingAnimation();
        FootstepAudio();
    }

    void GetMovementInput()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");
        movementSqrMagnitute = movement.sqrMagnitude;
        Debug.Log(movement);
    }

    void CharacterPosition()
    {
        //gameObject.transform.position += movement * walkSpeed * Time.deltaTime;
        gameObject.transform.Translate(movement * walkSpeed * Time.deltaTime);
    }

    void CharacterRotation()
    {

    }

    void WalkingAnimation()
    {

    }

    void FootstepAudio()
    {

    }
}
