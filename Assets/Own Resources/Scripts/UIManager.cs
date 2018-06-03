using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    string Url = "https://finalprojectgeeo.firebaseapp.com/";

    int[] size = { 500, 750, 1000, 1250 };

    int fountSizeCount=0;

    GameObject mainCanvas;
    GameObject settingsCanvas;
    GameObject bookSelectionCanvas;
    GameObject partitionSelectionCanvas;
    GameObject uploadBookCanvas;

    Button settingsButton;
    Button exitButton;
    Button bookSelectionButton;
    Button uploadButton;
    Button linkButton;
    Button backInPartitionButton;
    Button backInBookSelectButton;
    Button backInUploadButton;
    Button fontSizeButton;


    // Use this for initialization
    void Start () {

        mainCanvas = GameObject.Find("MainCanvas").gameObject;
        settingsCanvas = GameObject.Find("SettingsCanvas").gameObject;
        bookSelectionCanvas = GameObject.Find("BookSelectionCanvas").gameObject;
        partitionSelectionCanvas = GameObject.Find("PartitionSelectionCanvas").gameObject;
        uploadBookCanvas = GameObject.Find("UploadBookCanvas").gameObject;

        Debug.Log(mainCanvas);
        Debug.Log(settingsCanvas);
        Debug.Log(bookSelectionCanvas);
        Debug.Log(partitionSelectionCanvas);

        settingsButton = GameObject.Find("Settings").GetComponent<Button>();
        settingsButton.onClick.AddListener(delegate { ListenUI("settings"); });


        exitButton = GameObject.Find("Exit").GetComponent<Button>();
        exitButton.onClick.AddListener(delegate { ListenUI("exit"); });

        bookSelectionButton = GameObject.Find("BookSelection").GetComponent<Button>();
        bookSelectionButton.onClick.AddListener(delegate { ListenUI("bookSelection"); });

        uploadButton = GameObject.Find("UploadBook").GetComponent<Button>();
        uploadButton.onClick.AddListener(delegate { ListenUI("uploadCanvas"); });

        linkButton = GameObject.Find("LinkButton").GetComponent<Button>();
        linkButton.onClick.AddListener(delegate { ListenUI("link"); });

        backInPartitionButton= GameObject.Find("BackInPartition").GetComponent<Button>();
        backInPartitionButton.onClick.AddListener(delegate { ListenUI("backInPartition"); });

        backInBookSelectButton = GameObject.Find("BackInBookSelect").GetComponent<Button>();
        backInBookSelectButton.onClick.AddListener(delegate { ListenUI("backInBookSelect"); });

        backInUploadButton = GameObject.Find("BackInUpload").GetComponent<Button>();
        backInUploadButton.onClick.AddListener(delegate { ListenUI("backInUpload"); });

        fontSizeButton = GameObject.Find("FontSize").GetComponent<Button>();
        fontSizeButton.onClick.AddListener(delegate { ListenUI("changeFontSize"); });


        settingsCanvas.SetActive(false);
        bookSelectionCanvas.SetActive(false);
        partitionSelectionCanvas.SetActive(false);
        uploadBookCanvas.SetActive(false);
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

            settingsCanvas.SetActive(true);

        }
        else if (buttonName.Equals("exit"))
        {
            Debug.Log("Exit Buttonu Tiklandi");

            settingsCanvas.SetActive(false);

            mainCanvas.SetActive(true);

        }
        else if (buttonName.Equals("bookSelection"))
        {
            Debug.Log("BookSelection Buttonu Tiklandi");

            settingsCanvas.SetActive(false);

            bookSelectionCanvas.SetActive(true);

        }
        else if (buttonName.Equals("uploadCanvas"))
        {
            Debug.Log("Upload Buttonu Tiklandi");

            bookSelectionCanvas.SetActive(false);

            uploadBookCanvas.SetActive(true);

        }
        else if (buttonName.Equals("link"))
        {
            Debug.Log("Link Buttonu Tiklandi");

            uploadBookCanvas.SetActive(false);

            bookSelectionCanvas.SetActive(true);

            Application.OpenURL(Url);

        }
        else if (buttonName.Equals("backInPartition"))
        {
            Debug.Log("BackInPartition Buttonu Tiklandi");

            partitionSelectionCanvas.SetActive(false);

            settingsCanvas.SetActive(true);

        }
        else if (buttonName.Equals("backInBookSelect"))
        {
            Debug.Log("BackInBookSelect Buttonu Tiklandi");

            bookSelectionCanvas.SetActive(false);

            settingsCanvas.SetActive(true);

        }
        else if (buttonName.Equals("backInUpload"))
        {
            Debug.Log("BackInUpload Buttonu Tiklandi");

            uploadBookCanvas.SetActive(false);

            bookSelectionCanvas.SetActive(true);

        }
        else if (buttonName.Equals("changeFontSize"))
        {
            Debug.Log("ChangeFontSize Buttonu Tiklandi");

            Debug.Log(fountSizeCount);

            SendMessage("changeMaxCharLimit", size[fountSizeCount]);

            fontSizeButton.GetComponentInChildren<Text>().text = "Font Size: " + size[(fountSizeCount++)%4];
       

        }
        else
        {
            Debug.Log("UNSUPPORTED BUTTON");
        }





	}
}
