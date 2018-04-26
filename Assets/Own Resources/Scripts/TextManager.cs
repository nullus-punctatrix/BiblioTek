using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour {
	
	private Vector3 markerLocation;
	private float[] textDimension;
	private string fontType;
	private string fontSize;
	private string fontColor;
	private string background;
	private string textString;

    // Use this for initialization
	void Start () {

        textString = System.IO.File.ReadAllText(@"Assets/Book Shelf/Metamorphosis.txt");
    }

    // Update is called once per frame
    void Update () {

    }

    public string GetTextString()
    {

        return textString;
    }

	void placeText(string textString){
	}

	UnityEngine.UI.Text createText(string fontType, string fontSize, string fontColor, string background, string textString){
		return null;
	}

	void changeProperties(string fontType, string fontSize, string fontColor, string background){
		
	}
}
