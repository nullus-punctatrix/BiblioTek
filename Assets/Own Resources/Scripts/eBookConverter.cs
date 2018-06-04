using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class eBookConverter : MonoBehaviour{

    
    	private string fullText;

   

    string path;

    void Start()
    {
        string filePath = Application.streamingAssetsPath + "/deneme.txt";
        string jsonString;

        if (Application.platform == RuntimePlatform.Android)
        {
            WWW reader = new WWW(filePath);
            while (!reader.isDone) { }

            jsonString = reader.text;
        }
        else
        {
            jsonString = File.ReadAllText(filePath);
        }

        sendFullText(jsonString);


    }
	
	// Update is called once per frame
	void Update () {
        
    }

	void convertBook(){
		
	}

	string readBook(){
		return null;
	}

	void setBookPath(string path){
		//eBookPath = path;
	}

	void setConvertedPath(string path){
		//convertedPath = path;
	}

	void sendFullText(string str){
		SendMessage ("recieveFullText", str);
	}

	void setFullText(string fullText){
		//this.fullText = fullText;
	}
		
}
