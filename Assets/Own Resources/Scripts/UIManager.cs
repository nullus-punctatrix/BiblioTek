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
        settingsButton.onClick.AddListener(delegate { ListenUI("settings"); });


        exitButton = GameObject.Find("Exit").GetComponent<Button>();
        exitButton.onClick.AddListener(delegate { ListenUI("exit"); });


        settingsCanvas.SetActive(false);
        bookSelectionCanvas.SetActive(false);
        partitionSelectionCanvas.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

	}

	void ListenUI(string buttonName){

        Debug.Log("Basildi");

        if (buttonName.Equals("settings"))
        {
            Debug.Log("Settings Buttonu Tiklandi");

            mainCanvas.SetActive(false);

            //Resources.FindObjectsOfTypeAll<Canvas>()

            settingsCanvas.SetActive(true);
            //settingsCanvas.SetActive(true);





        }
        else if (buttonName.Equals("exit"))
        {
            Debug.Log("Exit Buttonu Tiklandi");

            settingsCanvas.SetActive(false);

            mainCanvas.SetActive(true);


        }
        else
        {
            Debug.Log("UNSUPPORTED BUTTON");
        }





	}
}
