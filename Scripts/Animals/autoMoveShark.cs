using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoMoveShark : MonoBehaviour
{
    public Rigidbody SharkRigid;
    private float SharkSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        SharkRigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        SharkRigid.AddForce(0,0,-SharkSpeed*Time.deltaTime,ForceMode.VelocityChange);
    }
}
