using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpUp : MonoBehaviour
{
   [Range(1,10)]
   public float jumpVelocity;
   public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;
            animator.SetBool("IsJump",true);
        }
    }
}
