using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    GameObject mainCanvas;
    GameObject settingsCanvas;
    GameObject bookSelectionCanvas;
    GameObject partitionSelectionCanvas;

    Button settingsButton;
    Button exitButton;


    // Use this for initialization
    void Start () {

        mainCanvas = GameObject.Find("MainCanvas").gameObject;
        settingsCanvas = GameObject.Find("SettingsCanvas").gameObject;
        bookSelectionCanvas = GameObject.Find("BookSelectionCanvas").gameObject;
        partitionSelectionCanvas = GameObject.Find("PartitionSelectionCanvas").gameObject;

        Debug.Log(mainCanvas);
        Debug.Log(settingsCanvas);
        Debug.Log(bookSelectionCanvas);
        Debug.Log(partitionSelectionCanvas);

        settingsButton = GameObject.Find("Settings").GetComponent<Button>();
        settingsButton.onClick.AddListener(ListenUI);

        exitButton = GameObject.Find("Exit").GetComponent<Button>();
        exitButton.onClick.AddListener(ListenUI);

        ListenUI();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

	void ListenUI(){

        Debug.Log("Basildi");
	}
}
