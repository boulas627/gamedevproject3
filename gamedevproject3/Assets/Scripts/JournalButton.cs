using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JournalButton : MonoBehaviour {
    public GameObject modalPanelObject;
    public AudioClip OpenSound;
    public AudioClip CloseSound;
    private AudioSource audioData;
    // Use this for initialization

    void Awake()
    {
        
    }
    void Start()
    {
        audioData = GameObject.Find("Journal Button").GetComponent<AudioSource>();
    }
    // Update is called once per frame
    public void Test()
    {
        if(modalPanelObject.activeSelf == false)
        {
            modalPanelObject.SetActive(true);
            audioData.PlayOneShot(OpenSound);
        }
        else
        {
            modalPanelObject.SetActive(false);
            audioData.PlayOneShot(CloseSound);

        }

    }


}
