using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupable : MonoBehaviour {

    public int flag;

    public void Pickup()
    {
        //code here that sets inventory/story flags
        Destroy(gameObject);
    }
}
