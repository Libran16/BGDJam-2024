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
            animator.SetTrigger("Jump");
            transform.position = (transform.position + new Vector3(0,0,-8));
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("Jump");
            transform.position = (transform.position + new Vector3(0,0,8));
        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("Jump");
            transform.position = (transform.position + new Vector3(-8,2,0));
        }

    }
}
