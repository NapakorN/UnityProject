using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTutorial : MonoBehaviour
{
    public InputMovement inputMovement;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            inputMovement.rigid.AddForce(0,0,-1000*Time.deltaTime,ForceMode.Force);
        }
    }
}
