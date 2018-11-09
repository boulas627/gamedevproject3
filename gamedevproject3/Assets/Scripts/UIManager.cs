using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {
    public GameObject modalPanelObject;
    public AudioSource audiosrc;
    public AudioClip openJournal;
    public AudioClip closeJournal;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.J))
        {
            if(modalPanelObject.activeSelf == false)
            {
                audiosrc.PlayOneShot(openJournal);
                modalPanelObject.SetActive(true);
            }
            else
            {
                audiosrc.PlayOneShot(closeJournal);
                modalPanelObject.SetActive(false);
            }
            
        }
	}
}
