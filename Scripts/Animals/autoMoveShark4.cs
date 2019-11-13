using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoMoveShark4 : MonoBehaviour
{
    public Rigidbody Shark;
    private float SharkSpeed = 16f;
    // Start is called before the first frame update
    void Start()
    {
        Shark = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Shark.AddForce(0,0,-SharkSpeed*Time.deltaTime,ForceMode.VelocityChange);
    }
}
