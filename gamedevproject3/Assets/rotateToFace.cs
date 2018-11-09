using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateToFace : MonoBehaviour {

    public Quaternion rotationOffset;

    public void rotateTo(Vector3 vec)
    {
        if (vec != Vector3.zero)
        {
            Vector3 rot = Vector3.RotateTowards(transform.forward, Quaternion.AngleAxis(50, Vector3.up) * vec, .1f, .1f);
            transform.forward = rot;
            //Quaternion rotation = Quaternion.LookRotation(vec, Vector3.up);
            //transform.rotation = rotation;
            transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
        }
    }
}
