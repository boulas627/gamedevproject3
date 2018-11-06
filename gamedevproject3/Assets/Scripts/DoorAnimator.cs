using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimator : MonoBehaviour {

    private bool animating;
    public float animationlength = 1;
    private float animationtimer;
    public bool openCW = true;
    private bool opened;

    private void Start()
    {
        animating = false;
        animationtimer = animationlength;
        opened = false;
    }

    public void Animate()
    {
        animating = true;
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
