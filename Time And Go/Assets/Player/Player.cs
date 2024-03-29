using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;
    float _gravitiy;
    private Rigidbody body; 
    public AudioSource JumpSound;

    private void Start()
    {
        animator = GetComponent<Animator>();
        body = GetComponent<Rigidbody>();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("Left");
            transform.position = (transform.position + new Vector3(0,0,-8));
            JumpSound.Play();
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("Right");
            transform.position = (transform.position + new Vector3(0,0,8));
            JumpSound.Play();
        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            _gravitiy = -9.81f;
            transform.position = (transform.position + new Vector3(-8,1,0));
            JumpSound.Play();
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("Back");
            _gravitiy = -9.81f;
            transform.position = (transform.position + new Vector3(8,1,0));
            JumpSound.Play();
        }

    }

}
