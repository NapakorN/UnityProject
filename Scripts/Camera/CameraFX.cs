using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class CameraFX : MonoBehaviour
{
    public PostProcessingProfile normal, waterFX;
    private PostProcessingBehaviour CamFX;
    // Start is called before the first frame update
    void Start()
    {
        CamFX = FindObjectOfType<PostProcessingBehaviour>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            CamFX.profile = waterFX;
        }
    }
    private void OnTriggerExit(Collider other) {
        if (other.name == "Player")
        {
            CamFX.profile = normal;
        }
    }
}
