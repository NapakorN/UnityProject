using UnityEngine;


public class PlayerCollision : MonoBehaviour
{
    public InputMovement movement;
    public Animator animator;
    public FollowPlayer followPlayer;
    public autoMoveShark autoMoveShark;
    public autoMoveShark2 autoMoveShark2;
    public autoMoveShark3 autoMoveShark3;
    public autoMoveShark4 autoMoveShark4;
    public Rigidbody rigidbody, CanonBall, CanonBall1, CanonBall2;
    public Light HeadSpotlight;
    [SerializeField]
    private GameObject Canonball1,Canonball2,Canonball3, smoke1, smoke2, smoke3;
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
        Canonball1.SetActive(false);
        Canonball2.SetActive(false);
        Canonball3.SetActive(false);
        smoke1.SetActive(false);
        smoke2.SetActive(false);
        smoke3.SetActive(false);

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacles")
        {
            movement.enabled = false;
            animator.SetBool("SetDeath", true);
            followPlayer.offset.z = -5;
            rigidbody.AddForce(0, -100, -700, ForceMode.Acceleration);

        }
        else if (collision.collider.name == "Ubox" || collision.collider.name == "Nbox")
        {
            movement.enabled = false;
            animator.SetBool("SetDeath", true);
            followPlayer.offset.z = -5;
            rigidbody.AddForce(0, 0, -700, ForceMode.Acceleration);
        }
        else if (collision.collider.tag == "Obstacles" && collision.collider.tag == "RightText")
        {
            movement.enabled = false;
            animator.SetBool("SetDeath", true);
            followPlayer.offset.z = -5;
            rigidbody.AddForce(0, -100, -700, ForceMode.Acceleration);
        }
        else if (collision.collider.tag == "React")
        {
            rigidbody.AddForce(0, 0, -50, ForceMode.Acceleration);
        } 
        
    }

    void OnCollisionStay(Collision other) {
        if (other.collider.name =="stop")
        {
            rigidbody.AddForce(0,0,800,ForceMode.Force);
            movement.enabled = false;    
            animator.SetBool("IsEnd",true);
            followPlayer.offset.z = -5;
            followPlayer.offset.y = 3.55f;
        }
        if (other.collider.tag == "SwimArea")
        {
            animator.SetBool("IsSwim",true);
            
        }
        else if (other.collider.tag == "React")
        {
            rigidbody.AddForce(0,0,-50,ForceMode.Acceleration);
            HeadSpotlight.range = 10f;
        }  
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "SharkSwitch")
        {
            autoMoveShark.enabled = true;
        } 
        if (other.name == "SharkSwitch1")
        {
            autoMoveShark2.enabled = true;
             autoMoveShark3.enabled = true;
              autoMoveShark4.enabled = true;
        }
        if (other.name == "waterArea")
        {
            movement.AutomaticForce = 800f;
            movement.SlideWayForce = 25f;
        }
        if (other.name == "boom")
        {
            Canonball1.SetActive(true);
            Canonball2.SetActive(true);
            Canonball3.SetActive(true);
            
            CanonBall.AddForce(-2000 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            CanonBall1.AddForce(-2000 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            CanonBall2.AddForce(-2000 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        HeadSpotlight.range = 76f;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.name == "boom")
        {
            smoke1.SetActive(true);
            smoke2.SetActive(true);
            smoke3.SetActive(true);
        }
        else
        {
            smoke1.SetActive(false);
            smoke2.SetActive(false);
            smoke3.SetActive(false);
        }
    }



}
    

