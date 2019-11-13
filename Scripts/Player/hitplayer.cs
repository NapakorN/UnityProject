using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitplayer : MonoBehaviour
{
    public Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other) {
        if (other.collider.name == "Player")
        {
            rigidbody.useGravity = true;
        }
    }

}
