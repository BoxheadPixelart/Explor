using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class PlayerMovement : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent; 
    // Start is called before the first frame updat
    public Camera portalCamera;
    public GameObject MoveCam;
    public GameObject FocusCam;
    public GameObject vCam;
    CameraController camControl;
    private void Start()
    {
        camControl = vCam.GetComponent<CameraController>();
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // do we hit our portal plane?
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.gameObject);


                var localPoint = hit.textureCoord;
                // convert the hit texture coordinates into camera coordinates
                Ray portalRay = portalCamera.ScreenPointToRay(new Vector2(localPoint.x * portalCamera.pixelWidth, localPoint.y * portalCamera.pixelHeight));
                RaycastHit portalHit;
                // test these camera coordinates in another raycast test
                if (Physics.Raycast(portalRay, out portalHit))
                {
                    if (portalHit.collider.gameObject.tag == "Level")
                    {
                        agent.SetDestination(portalHit.point);
                        //vCam.DisableAllCams(); 
                    }

                    if (portalHit.collider.gameObject.name == "FocusItem")
                    {
                        MoveCam.SetActive(false);
                        FocusCam.SetActive(true);
                    }
                   
                }
            }
        }

    }
   
}
