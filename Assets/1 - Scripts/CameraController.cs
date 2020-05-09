using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    List<GameObject> vCameras = new List<GameObject>(); 
    // Start is called before the first frame update
    void Start()
    {
       
       for (int i = 0; i < gameObject.transform.childCount ; i++)
       {
            vCameras.Add(gameObject.transform.GetChild(i).gameObject); 
       }
        print(gameObject.transform.childCount);

       // DisableAllCameras(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < vCameras.Capacity -1 ; i++)
            {
                print(vCameras[i].name);  
            }
        }
        //
        if (Input.GetKeyDown(KeyCode.B))
        {
            DisableAllCameras();
            //EnableCam(1); 
        }
    }

    public void DisableAllCameras()
    {
        for (int i = 0; i <= vCameras.Capacity - 1; i++)
        {
            vCameras[i].SetActive(false); 
        }
    }
    public void EnableCam(int select)
    {
        vCameras[select].gameObject.SetActive(true); 
    }
}
