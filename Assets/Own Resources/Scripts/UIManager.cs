using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    string Url = "https://finalprojectgeeo.firebaseapp.com/";

    int[] size = { 500, 750, 1000, 1250 };

    string[] color = { "Black","Red", "Green", "Blue" };

    string[] books = { "Metamorphism", "Alice In Wonderland", "uc", "dort" };

    //string[] type = {"Arial","Anton","Bangers","Liberation","Noto"};

    int fontSizeCount=2;

    int fontColorCount = 0;

    //int fontTypeCount = 0;

    int totalPartitionNumber=0;

    int currentPartitionNumber = 0;

    int currentBookNumber = 0;

    GameObject mainCanvas;
    GameObject settingsCanvas;
    GameObject bookSelectionCanvas;
    //GameObject partitionSelectionCanvas;
    GameObject uploadBookCanvas;

    Button settingsButton;
    Button exitButton;
    Button bookSelectionButton;
    Button uploadButton;
    Button linkButton;
    //Button backInPartitionButton;
    Button backInBookSelectButton;
    Button backInUploadButton;
    Button fontSizeButton;
    Button fontColorButton;
    //Button fontTypeButton;
    Button changePartitionButton;
    Button changeBookButton;

    // Use this for initialization
    void Start () {

        mainCanvas = GameObject.Find("MainCanvas").gameObject;
        settingsCanvas = GameObject.Find("SettingsCanvas").gameObject;
        bookSelectionCanvas = GameObject.Find("BookSelectionCanvas").gameObject;
        //partitionSelectionCanvas = GameObject.Find("PartitionSelectionCanvas").gameObject;
        uploadBookCanvas = GameObject.Find("UploadBookCanvas").gameObject;

        //Debug.Log(mainCanvas);
        //Debug.Log(settingsCanvas);
        //Debug.Log(bookSelectionCanvas);
        //Debug.Log(partitionSelectionCanvas);

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

        //backInPartitionButton= GameObject.Find("BackInPartition").GetComponent<Button>();
        //backInPartitionButton.onClick.AddListener(delegate { ListenUI("backInPartition"); });

        backInBookSelectButton = GameObject.Find("BackInBookSelect").GetComponent<Button>();
        backInBookSelectButton.onClick.AddListener(delegate { ListenUI("backInBookSelect"); });

        backInUploadButton = GameObject.Find("BackInUpload").GetComponent<Button>();
        backInUploadButton.onClick.AddListener(delegate { ListenUI("backInUpload"); });

        fontSizeButton = GameObject.Find("FontSize").GetComponent<Button>();
        fontSizeButton.onClick.AddListener(delegate { ListenUI("changeFontSize"); });
        fontSizeButton.GetComponentInChildren<Text>().text = "Font Size: Medium";


        fontColorButton = GameObject.Find("FontColor").GetComponent<Button>();
        fontColorButton.onClick.AddListener(delegate { ListenUI("changeFontColor"); });
        fontColorButton.GetComponentInChildren<Text>().text = "Font Color: " + color[fontColorCount];


        //fontTypeButton = GameObject.Find("FontType").GetComponent<Button>();
        //fontTypeButton.onClick.AddListener(delegate { ListenUI("changeFontType"); });
        //fontTypeButton.GetComponentInChildren<Text>().text = "Font Type: " + type[fontTypeCount];

        changePartitionButton = GameObject.Find("ChangePartition").GetComponent<Button>();
        changePartitionButton.onClick.AddListener(delegate { ListenUI("changePartition"); });
        if (totalPartitionNumber != 0)
        {
            changePartitionButton.GetComponentInChildren<Text>().text = "Partition Number: " + currentPartitionNumber;
        }
        else
        {
            changePartitionButton.GetComponentInChildren<Text>().text = "Partition Number: " + 0;
        }

        changeBookButton= GameObject.Find("ChangeBook").GetComponent<Button>();
        changeBookButton.onClick.AddListener(delegate { ListenUI("changeBook"); });
        changeBookButton.GetComponentInChildren<Text>().text = "Book: " + books[currentBookNumber];
        SendMessage("changeExternalPath", "/" + books[currentBookNumber].ToLowerInvariant().Replace(" ", string.Empty) + ".txt");


        settingsCanvas.SetActive(false);
        bookSelectionCanvas.SetActive(false);
        //partitionSelectionCanvas.SetActive(false);
        uploadBookCanvas.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
       //Debug.Log(totalPartitionNumber);

    }

    void receiveMaxNumberOfPartitions(int maxNOP)
    {
        totalPartitionNumber=maxNOP;
    }

    void ListenUI(string buttonName) {

        //Debug.Log("Basildi");

        if (buttonName.Equals("settings"))
        {
            Debug.Log("Settings Buttonu Tiklandi");

            mainCanvas.SetActive(false);

            settingsCanvas.SetActive(true);

        }
        else if (buttonName.Equals("exit"))
        {
            // Debug.Log("Exit Buttonu Tiklandi");

            settingsCanvas.SetActive(false);

            mainCanvas.SetActive(true);

        }
        else if (buttonName.Equals("bookSelection"))
        {
            //Debug.Log("BookSelection Buttonu Tiklandi");

            settingsCanvas.SetActive(false);

            bookSelectionCanvas.SetActive(true);

        }
        else if (buttonName.Equals("uploadCanvas"))
        {
            //  Debug.Log("Upload Buttonu Tiklandi");

            bookSelectionCanvas.SetActive(false);

            uploadBookCanvas.SetActive(true);

        }
        else if (buttonName.Equals("link"))
        {
            // Debug.Log("Link Buttonu Tiklandi");

            uploadBookCanvas.SetActive(false);

            bookSelectionCanvas.SetActive(true);

            Application.OpenURL(Url);

        }
        //else if (buttonName.Equals("backInPartition"))
        //{
        //    Debug.Log("BackInPartition Buttonu Tiklandi");

        //    partitionSelectionCanvas.SetActive(false);

        //    settingsCanvas.SetActive(true);

        //}
        else if (buttonName.Equals("backInBookSelect"))
        {
            // Debug.Log("BackInBookSelect Buttonu Tiklandi");

            bookSelectionCanvas.SetActive(false);

            settingsCanvas.SetActive(true);

        }
        else if (buttonName.Equals("backInUpload"))
        {
            // Debug.Log("BackInUpload Buttonu Tiklandi");

            uploadBookCanvas.SetActive(false);

            bookSelectionCanvas.SetActive(true);

        }
        else if (buttonName.Equals("changeFontSize"))
        {
            // Debug.Log("ChangeFontSize Buttonu Tiklandi");

            fontSizeCount++;

            fontSizeCount %= 4;

            SendMessage("changeMaxCharLimit", size[fontSizeCount]);

            if (size[fontSizeCount] == 500) {
                fontSizeButton.GetComponentInChildren<Text>().text = "Font Size: XLarge";
            }
            else if (size[fontSizeCount] == 750) {
                fontSizeButton.GetComponentInChildren<Text>().text = "Font Size: Large";
            }
            else if (size[fontSizeCount] == 1000) {
                fontSizeButton.GetComponentInChildren<Text>().text = "Font Size: Medium";
            }
            else if (size[fontSizeCount] == 1250) {
                fontSizeButton.GetComponentInChildren<Text>().text = "Font Size: Small";
            }
        }
        else if (buttonName.Equals("changeFontColor"))
        {
            //Debug.Log("ChangeFontColor Buttonu Tiklandi");

            fontColorCount++;

            fontColorCount %= 4;

            SendMessage("changeTextColor", color[fontColorCount]);

            fontColorButton.GetComponentInChildren<Text>().text = "Font Color: " + color[fontColorCount];


        }
        //else if (buttonName.Equals("changeFontType"))
        //{
        //   // Debug.Log("ChangeFontType Buttonu Tiklandi");

        //    fontTypeCount++;

        //    fontTypeCount %= 5;

        //    SendMessage("changeTextType", type[fontTypeCount]);

        //    fontTypeButton.GetComponentInChildren<Text>().text = "Font Color: " + type[fontTypeCount];


        //}
        else if (buttonName.Equals("changePartition"))
        {
          //  Debug.Log("ChangePartition Buttonu Tiklandi");

            if (totalPartitionNumber != 0)
            {
              //  Debug.Log("ICINE GIRDI");

                currentPartitionNumber = (currentPartitionNumber + 1) % totalPartitionNumber;

                changePartitionButton.GetComponentInChildren<Text>().text = "Partition Number: " + currentPartitionNumber;

                SendMessage("receiveCurrentSegment", currentPartitionNumber);
            }
        }
        else if (buttonName.Equals("changeBook"))
        {

            currentBookNumber++;

            currentBookNumber %= 2;

            Debug.Log("/" + Char.ToLowerInvariant((books[currentBookNumber])[0]) + (books[currentBookNumber].Replace(" ", string.Empty)).Substring(1) + ".txt");

            SendMessage("changeExternalPath", "/"+ Char.ToLowerInvariant((books[currentBookNumber])[0]) + (books[currentBookNumber].Replace(" ", string.Empty)).Substring(1) + ".txt");

            changeBookButton.GetComponentInChildren<Text>().text = "Book: " + books[currentBookNumber];
        }
        else
        {
           // Debug.Log("UNSUPPORTED BUTTON");
        }
	}
}
