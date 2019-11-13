using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody rigidbody;
    public Animator animator;
    public float jumpForce = 30f;
    public float fallingForce=2.5f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rigidbody.velocity.y < 0)
        {
            rigidbody.velocity += Vector3.up * Physics.gravity.y * (fallingForce - 1) * Time.deltaTime;
            
        }else if (rigidbody.velocity.y > 0 && !Input.GetKey("space"))
        {
            rigidbody.velocity += Vector3.up * Physics.gravity.y * (jumpForce - 1) * Time.deltaTime;
            animator.SetBool("IsJump",false);
        }
    }
}
