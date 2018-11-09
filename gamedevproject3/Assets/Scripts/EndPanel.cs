using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndPanel : MonoBehaviour
{
    private DisplayManager displayManager;
    private float holder;
    private bool displaying = false;
    void Awake()
    {
        displayManager = DisplayManager.Instance();
        displayManager.fadeTime = 1;
        displayManager.displayTime = 6;
        displayManager.displayText.alignment = TextAnchor.MiddleCenter;
        displayManager.DisplayMessage("\"Oh there you are. It is about time you came home to me. I watched you die days ago and then lost where you were. It was really weird, something was tugging me to stay on earth, just watching you.\"");
    }
    // Use this for initialization
    void Start()
    {
        holder = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(holder);
        Debug.Log(Time.time);
        if (Time.time - holder > 8 && Time.time - holder < 9 && displaying == false)
        {
            displaying = true;
            if (Display1() != null)
            {
                StopCoroutine(Display1());
            }
            StartCoroutine(Display1());

        }
        if (Time.time - holder > 17 && Time.time - holder < 18 && displaying == true)
        {
            displaying = false;
            if (Display2() != null)
            {
                StopCoroutine(Display2());
            }
            StartCoroutine(Display2());

        }
        if (Time.time - holder > 26 && Time.time - holder < 27 && displaying == false)
        {
            displaying = true;
            if (Display3() != null)
            {
                StopCoroutine(Display3());
            }
            StartCoroutine(Display3());

        }
        if (Time.time - holder > 34 && Time.time - holder < 35 && displaying == true)
        {
            displaying = false;
            if (Display4() != null)
            {
                StopCoroutine(Display4());
            }
            StartCoroutine(Display4());

        }
        if (Time.time - holder > 42 && Time.time - holder < 43 && displaying == false)
        {
            displaying = true;
            if (Display5() != null)
            {
                StopCoroutine(Display5());
            }
            StartCoroutine(Display5());

        }
        if (Time.time - holder > 51 && Time.time - holder < 52 && displaying == true)
        {
            displaying = false;
            if (FadeAlpha() != null)
            {
                StopCoroutine(FadeAlpha());

            }
            StartCoroutine(FadeAlpha());

        }
        if (Time.time - holder > 52)
        {
            SceneManager.LoadScene("StartScene");
            this.gameObject.SetActive(false);
        }
    }
    IEnumerator Display1()
    {
        displayManager.DisplayMessage("\"However when you died, everything started to lose color except our house and then people started to fade away too.\"");

        yield return null;
    }
    IEnumerator Display2()
    {
        displayManager.displayText.fontSize = 45;
        displayManager.displayTime = 7;
        displayManager.DisplayMessage("\"I started collecting these pieces of your journal wondering if you were ever going to come. Its funny because I found Entry 47 yesterday and I think this is supposed to be the part when you smile. Just like you said here 'I don’t really get upset or angry when I’m around MJ.'\"");

        yield return null;
    }
    IEnumerator Display3()
    {
        displayManager.displayTime = 6;
        displayManager.displayText.fontSize = 54;
        displayManager.DisplayMessage("\"Remember your wedding vows to me? You would always find me while Entry 47 was the last entry. That way all you would have to do is be near me to know you would never be alone again.\"");

        yield return null;
    }
    IEnumerator Display4()
    {
        displayManager.displayText.fontSize = 54;
        displayManager.DisplayMessage("\"Well you found me.\"");

        yield return null;
    }
    IEnumerator Display5()
    {
        displayManager.displayText.fontSize = 54;
        displayManager.DisplayMessage("...gives tomato leaf.");

        yield return null;
    }
    IEnumerator FadeAlpha()
    {
        this.GetComponent<Image>().CrossFadeAlpha(0f, 0.3f, false);
        yield return null;
    }
}
