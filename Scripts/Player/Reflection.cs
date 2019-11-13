using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflection : MonoBehaviour
{
    public InputMovement ChangeMovement;

    public Rigidbody rigid;
    private void OnCollisionEnter(Collision collision)
    {
        try
        {
            if (collision.collider.name == "Player")
            {
                ChangeMovement.rigid.AddForce(0, 0, -500, ForceMode.Acceleration);
            }
        }
        catch
        {
            Debug.Log("Error!");
        }
    }
}
