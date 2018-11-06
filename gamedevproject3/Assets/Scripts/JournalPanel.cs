using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class JournalPanel : MonoBehaviour {
    public int progress_num = -1;

    void Awake()
    {
        if(progress_num == 0)
        {
            GameObject.Find("MemTitle1").SetActive(false);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
