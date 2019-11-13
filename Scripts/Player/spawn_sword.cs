using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_sword : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public Collider collider;
    [HideInInspector]
    public Rigidbody rigidbody;
    private void OnCollisionEnter(Collision other) {
        if (other.collider.name == "Player")
        {
            meshRenderer.enabled = true;
            collider.isTrigger = false;
            rigidbody.AddForce(0,200,0,ForceMode.Acceleration);
        }
    }
}
