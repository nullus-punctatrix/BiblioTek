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
		int sl = str.Length;
		Debug.Log ("pageArray Length: " + pageArray.Length);
		for (int i = 0; i < totalPages; i++) {
			pageArray [i] = str.Substring (0, maxChar);
			Debug.Log (pageArray [i]);
			Debug.Log(maxChar + " maxchar, " + sl + "")
			str = str.Substring (maxChar, sl);
			sl = str.Length;
			Debug.Log ("Remaining string after " + i + "th substring: " + str);
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
