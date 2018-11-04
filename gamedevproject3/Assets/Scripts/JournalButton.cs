using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JournalButton : MonoBehaviour {
    public GameObject modalPanelObject;
    // Use this for initialization

    void Awake()
    {
        
    }
    // Update is called once per frame
    public void Test()
    {
        modalPanelObject.SetActive(true);
    }


}
