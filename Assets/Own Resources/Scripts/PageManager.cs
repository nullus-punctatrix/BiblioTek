using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageManager : MonoBehaviour {

    private string receivedFullText;
	private string[] pageArray;
	public eBookConverter ebc;
	private int maxChar = 1000;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void changeMaxCharLimit(int newMaxChar)
    {
        maxChar = newMaxChar;
        recieveFullText(receivedFullText);
    }
		
	void recieveFullText(string fullText){
        receivedFullText = fullText;
		processPage (fullText, this.maxChar);
	}

	void readPage(int number){
		
		// Read Page with given number..
	}
	void processPage(string str, int maxChar){
		int totalPages = (str.Length / maxChar) + 1;
		pageArray = new string[totalPages];
		for (int i = 0; i < totalPages; i++) {
			if (str.Length >= maxChar) {
				pageArray [i] = str.Substring (0, maxChar);
				if (str.Length != maxChar) {
					if (str [maxChar] == ' ') {
						str = str.Substring (1, str.Length-1);
					} else {
						if (pageArray [i] [maxChar-1] != ' ') {
							pageArray [i] = pageArray [i] + "-";
						}
					}
				} else {
					// DO NOTHING
				}
				str = str.Substring (maxChar, str.Length - maxChar);
			} else {
				pageArray [i] = str;
				str = "";
			}
		}
		SendMessage ("recievePages", pageArray);
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
			//Debug.Log("Variable \"Number\" is out of bonds...");
		}
	}
}
