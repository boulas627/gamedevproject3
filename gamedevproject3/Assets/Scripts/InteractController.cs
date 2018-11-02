using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractController : MonoBehaviour {

    public Text nameLabel;
    public GameObject player;

    private Interactable thisInteract = null;

    // Use this for initialization
    private void Start ()
    {
        nameLabel.enabled = false;
    }
	
	// Update is called once per frame
	private void Update () {
        if (Input.GetKeyDown("x"))
        {
            if(thisInteract != null)
            {
                if(thisInteract.gameObject.GetComponent<DoorAnimator>() != null)
                {
                    thisInteract.gameObject.GetComponent<DoorAnimator>().Animate();
                }
            }
        }

        thisInteract = null;
        foreach (Transform child in transform)
        {
            Interactable inter = child.GetComponent<Interactable>();
            if (inter.getAvail() == true)
            {
                if (thisInteract == null)
                {
                    thisInteract = inter;
                }
                else
                {
                    //if next one is closer, use that one
                    float distnew = (inter.transform.position - player.transform.position).magnitude;
                    float distold = (thisInteract.transform.position - player.transform.position).magnitude;
                    if (distnew < distold)
                        thisInteract = inter;
                }
            }
            if(thisInteract == null)
            {
                nameLabel.enabled = false;
            }
            else
            {
                nameLabel.enabled = true;
                Vector3 namePos = Camera.main.WorldToScreenPoint(thisInteract.transform.position);
                nameLabel.transform.position = namePos;
            }
        }
    }
}
