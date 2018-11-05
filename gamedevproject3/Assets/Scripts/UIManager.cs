using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {
    public GameObject modalPanelObject;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.J))
        {
            if(modalPanelObject.activeSelf == false)
            {
                modalPanelObject.SetActive(true);
            }
            else
            {
                modalPanelObject.SetActive(false);
            }
            
        }
	}
}
