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

    public void Avail()
    {
        isAvail = true;
    }
    public void notAvail()
    {
        isAvail = false;
    }
}
