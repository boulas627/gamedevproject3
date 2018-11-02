using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class Interactable : MonoBehaviour {
    
    private bool isAvail;

    private void Start()
    {
        isAvail = false;
    }

    public bool getAvail()
    {
        return isAvail;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player") == true)
        {
            isAvail = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag.Equals("Player") == true)
        {
            isAvail = false;
        }
    }
}
