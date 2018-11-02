using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JournalButton : MonoBehaviour {
    public Button m_YourFirstButton;
    private JournalPanel journalPanel;
    // Use this for initialization
    void Start () {
        m_YourFirstButton.onClick.AddListener(TaskOnClick);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void TaskOnClick()
    {

    }
}
