using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    
    private Animator animator;
    private Rigidbody rb;
    private float otherway;
    [SerializeField] public float speed;
    private Vector3 direction;
    private void Move()
    {
        animator.SetBool("IsRunning", true);
        animator.SetInteger("Way", 0);
        transform.position += speed * direction * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetInteger("Way", 1);
            transform.position += speed * Vector3.right * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {

            animator.SetInteger("Way", 2);
            transform.position += speed * Vector3.left * Time.deltaTime;
        }

        if (speed == 0)
        {
            animator.SetBool("IsRunning", false);
        }
    }
    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        direction = Vector3.forward;

    }
    private void Update()
    {
        Move();
    }



}
