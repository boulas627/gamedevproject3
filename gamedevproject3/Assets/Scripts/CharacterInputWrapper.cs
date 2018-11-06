using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInputWrapper : MonoBehaviour
{
    private int inph;
    private int inpv;
    private Vector3 movement;
    private Transform m_Cam;
    private Vector3 m_CamForward;
    private Rigidbody rbody;

    public float movespeed = 0.1f;
    // Use this for initialization
    void Start()
    {
        rbody = gameObject.GetComponent<Rigidbody>();
        if (Camera.main != null)
        {
            m_Cam = Camera.main.transform;
        }
        else
        {
            Debug.LogWarning(
                "Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.", gameObject);
            // we use self-relative controls in this case, which probably isn't what the user wants, but hey, we warned them!
        }
    }

    private void Update()
    {
        bool movechange = false;
        if (Input.GetKeyDown("up"))
        {
            inpv++;
            movechange = true;
        }
        if (Input.GetKeyDown("left"))
        {
            inph--;
            movechange = true;
        }
        if (Input.GetKeyDown("down"))
        {
            inpv--;
            movechange = true;
        }
        if (Input.GetKeyDown("right"))
        {
            inph++;
            movechange = true;
        }

        if (Input.GetKeyUp("up"))
        {
            inpv--;
            movechange = true;
        }
        if (Input.GetKeyUp("left"))
        {
            inph++;
            movechange = true;
        }
        if (Input.GetKeyUp("down"))
        {
            inpv++;
            movechange = true;
        }
        if (Input.GetKeyUp("right"))
        {
            inph--;
            movechange = true;
        }
        if (movechange)
        {
            if (m_Cam != null)
            {
                // calculate camera relative direction to move:
                m_CamForward = Vector3.Scale(m_Cam.forward, new Vector3(1, 0, 1)).normalized;
                movement = inpv * m_CamForward + inph * m_Cam.right;
            }
            else
            {
                // we use world-relative directions in the case of no main camera
                movement = inpv * Vector3.forward + inph * Vector3.right;
            }
            movement = movement.normalized;
        }
    }

    private void FixedUpdate()
    {
        
        rbody.AddForce(movement * movespeed);
        gameObject.GetComponentInChildren<rotateToFace>().rotateTo(rbody.velocity);
    }
}