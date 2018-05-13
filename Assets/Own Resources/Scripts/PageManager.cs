using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageManager : MonoBehaviour {

	private string[] pageArray;
	public eBookConverter ebc;
	private int maxChar = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	void recieveFullText(string fullText){
		processPage (fullText, this.maxChar);
	}

	void readPage(int number){
		string page = "";
		// Read Page with given number..
	}
	void processPage(string str, int maxChar){
		int totalPages = str.Length / maxChar;
		pageArray = new string[totalPages];
		for (int i = 0; i < totalPages; i++) {
			if (str [maxChar].Equals(" ")) {
				
			} else {
				
			}
			pageArray [i] = str.Substring (0, maxChar);
			str = str.Substring (maxChar, str.Length - maxChar);
		}
	}

	string getPage(int number){
		if (number <= pageArray.Length) {
			return pageArray [number];
		} else {
			return null;
		}
	}
	void setPage(int number, string str){
		if (number <= pageArray.Length) {
			pageArray [number] = str;
		} else {
			Debug.Log("Variable \"Number\" is out of bonds...");
		}
	}
}
