using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JournalButton : MonoBehaviour {
    public GameObject modalPanelObject;
    public AudioClip OpenSound;
    public AudioClip CloseSound;
    private AudioSource audioData;
    private DisplayManager displayManager;
    // Use this for initialization

    void Awake()
    {
        displayManager = DisplayManager.Instance();
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
            displayManager.DisplayMessage("Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!Clicked!");
            displayManager.fadeTime = 0.5f;
            displayManager.displayTime = 1;
            //Exemple
            //displayManager.DisplayMessage("Clicked!");
            //displayManager.fadeTime = 0.5f;
            //displayManager.displayTime = 1;
        }
        else
        {
            modalPanelObject.SetActive(false);
            audioData.PlayOneShot(CloseSound);
            //displayManager.DisplayMessage("Clicked!");
            //displayManager.fadeTime = 0.5f;

        }

    }


}
