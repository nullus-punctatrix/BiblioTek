using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using TMPro;
using System.Linq;

public class Scripts : MonoBehaviour {
	//private string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam laoreet nisl eget tempus gravida. Quisque rhoncus, dui id accumsan viverra, odio nisl congue leo, vitae pharetra arcu leo vitae leo. Maecenas ultrices pulvinar ultricies. In feugiat odio sed nibh pharetra placerat. Suspendisse vestibulum vel purus sed venenatis. Aenean sed ornare nulla, vel elementum erat. Nunc in maximus est. Donec quis tincidunt est, vitae hendrerit est. Vestibulum vitae tellus vitae dui mollis mollis. Fusce commodo vestibulum sem, id hendrerit diam viverra ac.";
//	static private int n = 5; // Number of Markers on the Scene
//	private GameObject[] blank_markers = new GameObject[n];
//	public GameObject augmentationObject = null;
	//public GameObject blank_marker;
	//private Vuforia.ImageTargetBehaviour marker_script;
	// Use this for initialization
	public string dataSetName;
	public GameObject augmentationObject;
	void Start () {
		//int counter = 0;
		GameObject[] all_objects = GameObject.FindGameObjectsWithTag ("Untagged");
		//Debug.Log ("All Objects Length: " + all_objects.Length);
		
//		LoadDataSet ();
//		GameObject[] all_markers = GameObject.Find
//		for (int i = 0; i < all_markers.Length; i++) {
//			GameObject marker = all_markers [i];
//			Transform canvasObj = marker.transform.GetChild (0);
//			Transform textObj = canvasObj.transform.GetChild (0);
//			TextMeshPro mText = textObj.GetComponent<TextMeshPro> ();
//			
//		}
		//GameObject blank_marker = GameObject.Find ("Blank Marker (0)");

		//Transform canvasObj = blank_marker.transform.GetChild (0);
		//Transform textObj = canvasObj.transform.GetChild (0);

		//TextMeshPro mText = textObj.GetComponent<TextMeshPro> ();
		//mText.pageToDisplay = 2;
		//Text textBox = textObj.GetComponent<Text> ();
		//textBox.text = lorem;
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

//	GameObject[] FindGameObjectsWithName(string name){
//		int a = GameObject.FindObjectsOfType <GameObject>().Length;
//		GameObject[] arr=new GameObject[a];
//		int FluentNumber = 0;
//		for (int i=0; i<a; i++) {
//			if (GameObject.FindObjectsOfType<GameObject> () [i].name == name) {
//				arr [FluentNumber] = GameObject.FindObjectsOfType<GameObject> () [i];
//				FluentNumber++;
//			}
//		}
//		Array.Resize (ref arr, FluentNumber);
//		return arr;
//	}

	void LoadMarkers(){
		
	}
//
//	void LoadDataSet()
//	    {
//
//				Debug.Log ("Hello Load");
//		        ObjectTracker objectTracker = TrackerManager.Instance.GetTracker<ObjectTracker>();
//		DataSet dataSet = null;
//		        //DataSet dataSet = objectTracker.CreateDataSet();
//		IEnumerable
//		foreach (DataSet ds in objectTracker.GetActiveDataSets()){
//			dataSet = ds;
//		}
//		         
//		        if (dataSet.Load(dataSetName)) {
//			             
//			            objectTracker.Stop();  // stop tracker so that we can add new dataset
//			 
//			            if (!objectTracker.ActivateDataSet(dataSet)) {
//				                // Note: ImageTracker cannot have more than 100 total targets activated
//				                Debug.Log("<color=yellow>Failed to Activate DataSet: " + dataSetName + "</color>");
//				            }
//			 
//			            if (!objectTracker.Start()) {
//				                Debug.Log("<color=yellow>Tracker Failed to Start.</color>");
//				            }
//			 
//			            int counter = 0;
//			 
//			            IEnumerable<TrackableBehaviour> tbs = TrackerManager.Instance.GetStateManager().GetTrackableBehaviours();
//			            foreach (TrackableBehaviour tb in tbs) {
//								Debug.Log("Hello");
//				                if (tb.name == "New Game Object") {
//					 
//					                    // change generic name to include trackable name
//					                    tb.gameObject.name = ++counter + ":DynamicImageTarget-" + tb.TrackableName;
//					 
//					                    // add additional script components for trackable
//					                    tb.gameObject.AddComponent<DefaultTrackableEventHandler>();
//					                    tb.gameObject.AddComponent<TurnOffBehaviour>();
//					 
//					                    if (augmentationObject != null) {
//						                        // instantiate augmentation object and parent to trackable
//						                        GameObject augmentation = (GameObject)GameObject.Instantiate(augmentationObject);
//						                        augmentation.transform.parent = tb.gameObject.transform;
//						                        augmentation.transform.localPosition = new Vector3(0f, 0f, 0f);
//						                        augmentation.transform.localRotation = Quaternion.identity;
//						                        augmentation.transform.localScale = new Vector3(0.005f, 0.005f, 0.005f);
//						                        augmentation.gameObject.SetActive(true);
//												Debug.Log("GameObject created");
//					                    } else {
//						                        Debug.Log("<color=yellow>Warning: No augmentation object specified for: " + tb.TrackableName + "</color>");
//						                    }
//					                }
//				            }
//		        } else {
//			            Debug.LogError("<color=yellow>Failed to load dataset: '" + dataSetName + "'</color>");
//			        }
//	}
}