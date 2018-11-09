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
        audioData = transform.GetComponent<AudioSource>();
    }
    // Update is called once per frame
    public void Test()
    {
        if(modalPanelObject.activeSelf == false)
        {
            modalPanelObject.SetActive(true);
            audioData.PlayOneShot(OpenSound);
            //Exemple
            //displayManager.DisplayMessage("Clicked!");
            //displayManager.fadeTime = 0.5f;
            //displayManager.displayTime = 1;
        }
        else
        {
            audioData.PlayOneShot(CloseSound);
            modalPanelObject.SetActive(false);
            //displayManager.DisplayMessage("Clicked!");
            //displayManager.fadeTime = 0.5f;

        }

    }


}
