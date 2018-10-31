using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraControl : MonoBehaviour
{   
    private CinemachineVirtualCamera camera;
    private int camDelay;

    void Start()
    {
        camera = transform.parent.gameObject.GetComponent<CinemachineVirtualCamera>();
        camDelay = 0;
    }

    void Update()
    {
        if (camDelay > 0)
        {
            camDelay--;
            camera.Priority -= 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player") == true)
        {
            camera.Priority = 3;
            camDelay = 2;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag.Equals("Player") == true)
        {
            camera.Priority = 0;
        }
    }
}
