using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("Left");
            transform.position = (transform.position + new Vector3(0,0,-8));
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("Right");
            transform.position = (transform.position + new Vector3(0,0,8));
        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = (transform.position + new Vector3(-8,2,0));
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("Back");
            transform.position = (transform.position + new Vector3(8,2,0));
        }

    }
}
