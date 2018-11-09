using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupable : MonoBehaviour {

    public JournalPanel jpanel;
    public int flag;
    public int key = -1;
    public DisplayManager manager;
    public string message;
    public ImageFade fadeout;

    public void Pickup()
    {
        if (key >= 0)
        {
            transform.parent.GetComponent<InteractController>().keyring.getKey(key);
        }
        switch (flag)
        {
            case 1:
                jpanel.Pressed_tomato_leaf = true;
                break;
            case 2:
                jpanel.Entry_30 = true;
                break;
            case 3:
                jpanel.Entry_36 = true;
                break;
            case 4:
                jpanel.Minecraft_Poster = true;
                break;
            case 5:
                jpanel.Entry_44 = true;
                break;
            case 6:
                jpanel.Letter_from_Aurora = true;
                break;
            case 10:
                fadeout.Fadeout();
                break;

        }
        if (message != "")
            manager.DisplayMessage(message);
        //code here that sets inventory/story flags
        Destroy(gameObject);
    }
}
