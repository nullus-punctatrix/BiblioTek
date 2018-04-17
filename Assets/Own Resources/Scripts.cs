using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scripts : MonoBehaviour {
	private string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam laoreet nisl eget tempus gravida. Quisque rhoncus, dui id accumsan viverra, odio nisl congue leo, vitae pharetra arcu leo vitae leo. Maecenas ultrices pulvinar ultricies. In feugiat odio sed nibh pharetra placerat. Suspendisse vestibulum vel purus sed venenatis. Aenean sed ornare nulla, vel elementum erat. Nunc in maximus est. Donec quis tincidunt est, vitae hendrerit est. Vestibulum vitae tellus vitae dui mollis mollis. Fusce commodo vestibulum sem, id hendrerit diam viverra ac.";
	static private int n = 5; // Number of Markers on the Scene
	private GameObject[] blank_markers = new GameObject[n];
	//public GameObject blank_marker;
	//private Vuforia.ImageTargetBehaviour marker_script;
	// Use this for initialization
	void Start () {
		GameObject blank_marker = GameObject.Find ("Blank Marker (0)");

		GameObject canvasObj = blank_marker.transform.GetChild (0).transform;
		GameObject textObj = canvasObj.transform.GetChild (0).transform;
		Text textBox = textObj.GetComponent<Text> ();
		textBox.text = lorem;
		//UnityEngine.UI.Text text = canvas.GetComponent<UnityEngine.UI.Text> ();

		//UnityEngine.UI.Text text_box = blank_marker.GetComponent<GameObject>().GetComponent<UnityEngine.UI.Text>();
		//text_box.text = lorem;
		//Instantiate (marker_plane, new Vector3(0, -1, 0), Quaternion.identity);

		//blank_marker = GameObject.Find ("Blank Marker(Clone)");

		//blank_marker.AddComponent<Vuforia.ImageTargetBehaviour>();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
