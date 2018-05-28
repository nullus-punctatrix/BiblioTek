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
	private bool pagesRecieved = false;
	public Transform canvas;
	public Transform textPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (LoadTargetsFlag & pagesRecieved) {
			LoadTargets ();
			LoadTargetsFlag = !LoadTargetsFlag;
		} 
		else {
			TrackableBehaviour[] tbs = TrackerManager.Instance.GetStateManager ().GetActiveTrackableBehaviours ().ToArray ();
			if (tbs.Length > 0) {
				TextMeshPro tmpo = null;
				for (int i = 0; i < tbs.Length; i++) {
					//GameObject.Find (tbs [i].name).GetComponent ("Canvas(Clone)").gameObject.transform.GetComponent("Text");
					//tmpo = tbs [i].gameObject.GetComponent ("Canvas(Clone)").gameObject.GetComponent ("Text").gameObject.GetComponent<TextMeshPro> ();
					if(tmpo != null){
						Debug.Log (tmpo.text);
					}
				}
			}
		}
	}

	void changeCover(string path){
		
	}

	void recievePages(string[] pages){
		cachedPages = pages;
		for (int i = 0; i < cachedPages.Length; i++) {
			Debug.Log (cachedPages.Length);
		}
		pagesRecieved = true;
	}

	void LoadTargets(){
		TrackableBehaviour[] tbs = TrackerManager.Instance.GetStateManager ().GetTrackableBehaviours ().ToArray ();
		int count = 1;
		for (int i = 0; i < tbs.Length; i++) {
			tbs [i].name = "Marker_" + count++;
			tbs [i].tag = "Marker";
			tbs [i].gameObject.AddComponent<DefaultTrackableEventHandler> ();
			tbs [i].gameObject.AddComponent<TurnOffBehaviour> ();
			Transform canvasOb = (Transform)Transform.Instantiate (canvas);

			Transform textBox = (Transform)Transform.Instantiate (textPrefab);
			textBox.transform.SetParent (canvasOb);

			if (i < cachedPages.Length) {
				textBox.GetComponent<TextMeshPro> ().text = cachedPages [i];
			}
			textBox.GetComponent<TextMeshPro> ().text = "LOL" + count;
			textBox.GetComponent<TextMeshPro> ().alignment = TextAlignmentOptions.TopJustified;


			canvasOb.transform.SetParent(tbs[i].gameObject.transform); 
			canvasOb.transform.localPosition = new Vector3(-0.2f, 0f, -0.4f);
			canvasOb.transform.localRotation = Quaternion.identity;
			canvasOb.transform.localScale = new Vector3 (0.0005f, 0.0005f, 0.0005f);
			canvasOb.transform.Rotate (new Vector3 (90, 0, 0));
			canvasOb.gameObject.SetActive(true);

			//Transform textBox = canvasOb.GetChild (0);
			//textBox.GetComponent<TextMeshPro> ().isTextTruncated;
			//canvasOb.transform.parent = tbs [i].gameObject.transform;
			//textBox.GetComponent<TextMeshPro> ().pageToDisplay = count--;
//			GameObject augmentation = (GameObject)GameObject.Instantiate(test);
//			augmentation.transform.parent = tbs[i].gameObject.transform;
//			augmentation.transform.localPosition = new Vector3(0f, 0f, 0f);
//			augmentation.transform.localRotation = Quaternion.identity;
//			augmentation.gameObject.SetActive(true);
		}
	}
}
