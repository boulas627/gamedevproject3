using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomTransition : MonoBehaviour {

    public Transform target;

    private void OnTriggerEnter(Collider isplayer)
    {
        if (isplayer.gameObject.tag.Equals("Player") == true)
        {
            isplayer.transform.position = target.position;
        }
    }
}
