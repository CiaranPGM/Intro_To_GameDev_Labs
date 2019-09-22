using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Vector3 movement;
    private float movementSqrMagnitute;
    public float walkSpeed = 1.5f;
    public Animator anim;
    public AudioSource footstepSource, backgroundMusic;
    public AudioClip[] footsetpClips;
    private int counter = 0;

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
        Vector3.ClampMagnitude(movement, 1.0f);
        movementSqrMagnitute = movement.sqrMagnitude;
        //Debug.Log(movement);
    }

    void CharacterPosition()
    {
        gameObject.transform.Translate(movement * walkSpeed * Time.deltaTime, Space.World);
    }

    void CharacterRotation()
    {
        Vector3 zero = new Vector3(0, 0, 0);
        if(movement != zero)
            gameObject.transform.rotation = Quaternion.LookRotation(movement);
    }

    void WalkingAnimation()
    {
        anim.SetFloat("MoveSpeed", movementSqrMagnitute);
    }

    void FootstepAudio()
    {
        if(movementSqrMagnitute > 0.3f && !footstepSource.isPlaying)
        {
            footstepSource.clip = footsetpClips[counter];
            footstepSource.volume = movementSqrMagnitute;
            footstepSource.Play();
            backgroundMusic.volume = 0.5f;
            if(counter == 0)
            {
                counter = 1;
            }
            else { counter = 0; }
        }else if(movementSqrMagnitute <= 0.3f && footstepSource.isPlaying){
            footstepSource.Stop();
            backgroundMusic.volume = 1.0f;
        }
    }
}
