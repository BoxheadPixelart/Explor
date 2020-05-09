using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTriggerZone : MonoBehaviour
{
    Renderer render;
    public GameObject vCam;
    CameraController camControl; 
    public int enterSelection;
    public int exitSelection;
    public bool onEnter;
    public bool onExit; 
    // Start is called before the first frame update
    void Start()
    {
        vCam = GameObject.FindGameObjectWithTag("VCams"); 
        render = GetComponent<Renderer>();
        render.enabled = false;

        camControl = vCam.GetComponent<CameraController>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PlayerCollider")
        {
            if (onEnter)
            {
                print("Triggered");
                camControl.DisableAllCameras();
                camControl.EnableCam(enterSelection);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "PlayerCollider")
        {
            if (onExit)
            {
                print("Triggered");
                camControl.DisableAllCameras();
                camControl.EnableCam(exitSelection);
            }
        }
    }
}
