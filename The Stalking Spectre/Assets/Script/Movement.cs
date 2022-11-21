using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator animator;

    public float m_MoveSpeed = 5f;

    public Rigidbody m_RB;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        m_RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Code for the movement
        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(0f, 0f, 1f);
            m_RB.AddForce(transform.forward * m_MoveSpeed, ForceMode.Force);
            animator.SetBool("forward", true);
        }
        else
        {
            animator.SetBool("forward", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(0f, 0f, -1f);
            m_RB.AddForce(-transform.forward * m_MoveSpeed, ForceMode.Force);
            animator.SetBool("backward", true);
        }
        else
        {
            animator.SetBool("backward", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(-1f, 0f, 0f);
            m_RB.AddForce(-transform.right * m_MoveSpeed, ForceMode.Force);
            animator.SetBool("left", true);
        }
        else
        {
            animator.SetBool("left", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(1f, 0f, 1f);
            m_RB.AddForce(transform.right * m_MoveSpeed, ForceMode.Force);
            animator.SetBool("right", true); ;
        }
        else
        {
            animator.SetBool("right", false);
        }
    }
}
