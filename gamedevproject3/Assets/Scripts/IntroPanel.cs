using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroPanel : MonoBehaviour {
    private DisplayManager displayManager;
    private float holder;
    private bool displaying = false;
    void Awake()
    {
        displayManager = DisplayManager.Instance();
        displayManager.fadeTime = 1;
        displayManager.displayTime = 6;
        displayManager.displayText.alignment = TextAnchor.MiddleCenter;
        displayManager.DisplayMessage("It was quite some time after getting married when she died. Your wife of 20 years passed away suddenly when the house caught on fire one day while she was sleeping.");
    }
    // Use this for initialization
    void Start () {
        holder = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(holder);
        Debug.Log(Time.time);
        if (Time.time - holder > 8 && displaying == false)
        {
            displaying = true;
            if (Display1() != null)
            {
                StopCoroutine(Display1());
            }
            StartCoroutine(Display1());

        }
        if (Time.time - holder > 15 && displaying == true)
        {
            if (FadeAlpha() != null)
            {
                StopCoroutine(FadeAlpha());
                
            }
            StartCoroutine(FadeAlpha());

        }
        if(Time.time - holder > 17)
        {
            this.gameObject.SetActive(false);
        }
    }
    IEnumerator Display1()
    {
        displayManager.DisplayMessage("It did not happen all at once, but your memories of the past started to fade away. The pain of her being gone was overbearing and you ripped up your old journal trying to escape the past, leaving pages everywhere.");

        yield return null;
    }
    IEnumerator FadeAlpha()
    {
        this.GetComponent<Image>().CrossFadeAlpha(0f, 0.3f, false);
        yield return null;
    }
}
