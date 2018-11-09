using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimator : MonoBehaviour {

    private bool animating;
    public float animationlength = 1;
    public int key = -1;
    private float animationtimer;
    public bool openCW = true;
    private bool opened;
    public DisplayManager manager;

    public AudioClip DoorLocked;
    public AudioClip DoorOpen;

    private void Start()
    {
        animating = false;
        animationtimer = animationlength;
        opened = false;
    }

    public void Animate()
    {
        if (key >= 0)
        {
            if (transform.parent.GetComponent<InteractController>().keyring.hasKey(key))
            {
                transform.parent.GetComponent<AudioSource>().PlayOneShot(DoorOpen);
                animating = true;
            }
            else
            {
                transform.parent.GetComponent<AudioSource>().PlayOneShot(DoorLocked);
                manager.DisplayMessage("It's locked...");
            }
        }
        else
        {
            animating = true;
            transform.parent.GetComponent<AudioSource>().PlayOneShot(DoorOpen);
        }
    }

	void Update () {
        if (animating)
        {
            if(animationtimer > 0)
            {
                if ((!opened && openCW) || (opened && !openCW))
                {
                    //rotate clockwise
                    transform.GetChild(1).RotateAround(transform.GetChild(0).transform.position, Vector3.up, 90/animationlength * Time.deltaTime);
                    transform.GetChild(2).RotateAround(transform.GetChild(0).transform.position, Vector3.up, 90/animationlength * Time.deltaTime);
                }
                else
                {
                    //rotate ccw
                    transform.GetChild(1).RotateAround(transform.GetChild(0).transform.position, Vector3.up, -90/animationlength * Time.deltaTime);
                    transform.GetChild(2).RotateAround(transform.GetChild(0).transform.position, Vector3.up, -90/animationlength * Time.deltaTime);
                }
                animationtimer -= Time.deltaTime;
            }
            else
            {
                animating = false;
                animationtimer = animationlength;
                opened = !opened;
            }
        }
	}
}
