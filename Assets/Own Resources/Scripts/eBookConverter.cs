using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eBookConverter : MonoBehaviour{
	
	private string eBookPath;
	private string convertedPath;
	private string fullText;

	// Use this for initialization
	void Start () {
		sendFullText ("TEST");
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
		eBookPath = path;
	}

	void setConvertedPath(string path){
		convertedPath = path;
	}

	void sendFullText(string str){
		SendMessage ("recieveFullText", str);
	}

	void setFullText(string fullText){
		this.fullText = fullText;
	}
		
}
