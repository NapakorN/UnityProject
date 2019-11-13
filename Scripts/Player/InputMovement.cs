using UnityEngine;
public class InputMovement : MonoBehaviour
{
    public Rigidbody rigid;
    public jumpUp jump;
    public Animator animator;
    public Transform transform;
    public float AutomaticForce = 2000f;
    public float SlideWayForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();       
    }

    // For increase velocity automaticly to our player
    void Update()
    {
        rigid.AddForce(0, 0, AutomaticForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rigid.AddForce(SlideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            animator.SetBool("IsRight",true);
        }else{animator.SetBool("IsRight",false);}
        if (Input.GetKey("a"))
        {
            rigid.AddForce(-SlideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            animator.SetBool("IsLeft",true);
        }else{animator.SetBool("IsLeft",false);}
        
    }
    //Enable jump ability when player's running on floor
    private void OnCollisionStay(Collision other) {
        if (other.collider.tag == "Floor")
        {
            jump.enabled = true;
            animator.SetBool("IsJump",false); //Disable jump animation
        }
    }
    //Disable jump ability
    private void OnCollisionExit(Collision other)
    {
        if (other.collider.tag == "Floor")
        {
            jump.enabled = false;           
        }
    }

        
}


