using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public GameObject cam;
    Vector3 rot;
    // Start is called before the first frame update
    void Start()
    {
        rot.x = 45f;
        rot.z = 45f;
    }

    // Update is called once per frame
    void Update()
    {
        rot.y += 1f;
        cam.transform.rotation = Quaternion.Euler(rot.x,rot.y,rot.z);
    }
}
