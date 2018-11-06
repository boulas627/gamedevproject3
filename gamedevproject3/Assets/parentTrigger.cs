using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parentTrigger : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player") == true)
        {
            transform.parent.GetComponent<Interactable>().Avail();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player") == true)
        {
            transform.parent.GetComponent<Interactable>().notAvail();
        }
    }
}
