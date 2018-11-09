using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class JournalPanel : MonoBehaviour {
    public bool Pressed_tomato_leaf = false;
    public bool Entry_36 = false;
    public bool Entry_30 = false;
    public bool Minecraft_Poster = false;
    public bool Entry_44 = false;
    public bool Letter_from_Aurora = false;
    public GameObject Pressed_tomato_leaf_O;
    public GameObject Entry_36_O;
    public GameObject Entry_30_O;
    public GameObject Minecraft_Poster_O;
    public GameObject Entry_44_O;
    public GameObject Letter_from_Aurora_O;
    public GameObject Pressed_tomato_leaf_H;
    public GameObject Entry_36_H;
    public GameObject Entry_30_H;
    public GameObject Minecraft_Poster_H;
    public GameObject Entry_44_H;
    public GameObject Letter_from_Aurora_H;

    void Awake()
    {

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Pressed_tomato_leaf == true && Pressed_tomato_leaf_O.activeSelf == false)
        {
            Pressed_tomato_leaf_O.SetActive(true);
            Pressed_tomato_leaf_H.SetActive(false);
        }
        if (Entry_36 == true && Entry_36_O.activeSelf == false)
        {
            Entry_36_O.SetActive(true);
            Entry_36_H.SetActive(false);
        }
        if (Entry_30 == true && Entry_30_O.activeSelf == false)
        {
            Entry_30_O.SetActive(true);
            Entry_30_H.SetActive(false);
        }
        if (Minecraft_Poster == true && Minecraft_Poster_O.activeSelf == false)
        {
            Minecraft_Poster_O.SetActive(true);
            Minecraft_Poster_H.SetActive(false);
        }
        if (Entry_44 == true && Entry_44_O.activeSelf == false)
        {
            Entry_44_O.SetActive(true);
            Entry_44_H.SetActive(false);
        }
        if (Letter_from_Aurora == true && Letter_from_Aurora_O.activeSelf == false)
        {
            Letter_from_Aurora_O.SetActive(true);
            Letter_from_Aurora_H.SetActive(false);
        }
    }
}
