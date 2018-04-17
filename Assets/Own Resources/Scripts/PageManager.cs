using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageManager : MonoBehaviour {

	private string[] pageArray;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void readPage(int number){
		string page = "";
		// Read Page with given number..
		processPage(page);
	}
	void processPage(string str){
		
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
