using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class eBookConverter : MonoBehaviour{

    
    

    void Start()
    {
        string filePath = Application.streamingAssetsPath;

        string externalPath = "/metamorphism.txt";
        
        changeExternalPath(filePath+externalPath);
    }
	
	// Update is called once per frame
	void Update () {
        
    }

	void changeExternalPath(string externalPath){

        string filePath = Application.streamingAssetsPath;

        filePath = filePath + externalPath;
        string fullText;

        if (Application.platform == RuntimePlatform.Android)
        {
            WWW reader = new WWW(filePath);
            while (!reader.isDone) { }

            fullText = reader.text;
        }
        else
        {
            fullText = File.ReadAllText(filePath);
        }

        sendFullText(fullText);
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
