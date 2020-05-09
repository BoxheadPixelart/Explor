using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine; 

public class CameraSetter : MonoBehaviour
{
    CinemachineBrain brain; 
    // Start is called before the first frame update
    void Start()
    {
        brain = gameObject.GetComponent<CinemachineBrain>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
