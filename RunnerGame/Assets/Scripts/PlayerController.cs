using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public static PlayerController ins; 
    int direction = 0;
    Rigidbody rb;
    //Animation anim;
    public  Animator anim; 
    public bool isGrounded; 

    private void Awake()
    {
        ins = this;
    }
    private void Start()
    {
        anim = GetComponent<Animator>();
        //anim = GetComponent<Animation>();
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        playAnim();
    }
    public void MoveRight()
    {
        if (direction < 1)
        {
            direction++;
            transform.Translate(Vector3.right);
        }
    }
    public void MoveLeft()
    {
        if(direction >-1)
        {
            direction--;
            transform.Translate(Vector3.left);
        
        }
    }
    public void Jump()
    {
        rb.AddForce(Vector3.up * 100);
        isGrounded = false;
     //   anim.SetBool("jump",true);
    }
    void playAnim()
    {
        if (isGrounded)
        {
            anim.SetBool("jump", false);
        }
        else
        {
            anim.SetBool("jump", true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

}
