using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalVars : MonoBehaviour {

    public int numkeys;
    private bool[] keys;

    private void Start()
    {
        keys = new bool[numkeys];
        for(int i = 0; i < numkeys; i++)
        {
            keys[i] = false;
        }
    }

    public bool hasKey(int key)
    {
        return keys[key];
    }
    public void getKey(int key)
    {
        keys[key] = true;
    }
}
