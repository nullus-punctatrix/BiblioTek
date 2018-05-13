using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using TMPro;
using System.Linq;

public class BiblioTekMainScript : MonoBehaviour {

	private UnityEngine.UI.Image coverImage;
	private string[] cachedPages;
	private int bookmark;
	private bool LoadTargetsFlag = true;
	public Transform canvas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (LoadTargetsFlag) {
			LoadTargets ();
			LoadTargetsFlag = !LoadTargetsFlag;
		}
	}

	void changeCover(string path){
		
	}

	void LoadTargets(){
		TrackableBehaviour[] tbs = TrackerManager.Instance.GetStateManager ().GetTrackableBehaviours ().ToArray ();
		int count = tbs.Length;
		for (int i = 0; i < tbs.Length; i++) {
			Debug.Log (tbs[i]);
			tbs [i].name = "Marker_" + count;
			tbs [i].tag = "Marker";
			tbs [i].gameObject.AddComponent<DefaultTrackableEventHandler> ();
			tbs [i].gameObject.AddComponent<TurnOffBehaviour> ();
			Transform canvasOb = (Transform)Transform.Instantiate (canvas);
			Transform textBox = canvasOb.GetChild (0);
			textBox.GetComponent<TextMeshPro> ().pageToDisplay = count--;
			//textBox.GetComponent<TextMeshPro> ().isTextTruncated;
			canvasOb.transform.SetParent(tbs[i].gameObject.transform); 
			//canvasOb.transform.parent = tbs [i].gameObject.transform;
			canvasOb.transform.localPosition = new Vector3(-0.2f, 0f, -0.4f);
			canvasOb.transform.localRotation = Quaternion.identity;
			canvasOb.transform.localScale = new Vector3 (0.0005f, 0.0005f, 0.0005f);
			canvasOb.transform.Rotate (new Vector3 (90, 0, 0));
			canvasOb.gameObject.SetActive(true);
//			GameObject augmentation = (GameObject)GameObject.Instantiate(test);
//			augmentation.transform.parent = tbs[i].gameObject.transform;
//			augmentation.transform.localPosition = new Vector3(0f, 0f, 0f);
//			augmentation.transform.localRotation = Quaternion.identity;
//			augmentation.gameObject.SetActive(true);
		}
	}
}
