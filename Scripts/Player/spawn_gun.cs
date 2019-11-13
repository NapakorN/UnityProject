using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_gun : MonoBehaviour
{
    public Rigidbody rigidbody;
    public MeshRenderer meshRenderer;
    public Collider collider;

    private void OnCollisionEnter(Collision other) {
        if (other.collider.name == "Player")
        {
            rigidbody.AddForce(0,200,0,ForceMode.Acceleration);
            meshRenderer.enabled = true;
            collider.isTrigger = false;        
        }
    }

    
}
