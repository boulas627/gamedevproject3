using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupable : MonoBehaviour {

    public int flag;
    public int key = -1;

    public void Pickup()
    {
        if(key >= 0)
            transform.parent.GetComponent<InteractController>().keyring.getKey(key);
        //code here that sets inventory/story flags
        Destroy(gameObject);
    }
}
