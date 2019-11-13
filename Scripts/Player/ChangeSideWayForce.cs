using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSideWayForce : MonoBehaviour
{
    public InputMovement movement;
    private void OnCollisionEnter(Collision other) {
        if (other.collider.tag == "React")
        {
            movement.SlideWayForce = 85f;
        }
    }
}
