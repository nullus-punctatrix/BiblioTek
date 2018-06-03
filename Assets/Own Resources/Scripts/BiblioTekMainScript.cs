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
	private int segmentPointer = 0;
	private bool segmentChanged = false;
	private bool initialized = false;

	void Start () {
		
	}

	void Update () {
		if (LoadTargetsFlag & pagesRecieved) {
			LoadTargets ();
			LoadTargetsFlag = !LoadTargetsFlag;
            Debug.Log("GIRDI LA GIRDI SIKINTI YOK AMQ");
		}
		else if (segmentChanged){
			LoadSegment (segmentPointer);
			segmentChanged = false;
		}
		else {
			TrackableBehaviour[] tbs = TrackerManager.Instance.GetStateManager ().GetActiveTrackableBehaviours ().ToArray ();
			if (tbs.Length > 0) {
				TextMeshPro tmpo = null;
				for (int i = 0; i < tbs.Length; i++) {
					//GameObject.Find (tbs [i].name).GetComponent ("Canvas(Clone)").gameObject.transform.GetComponent("Text");
					//tmpo = tbs [i].gameObject.GetComponent ("Canvas(Clone)").gameObject.GetComponent ("Text").gameObject.GetComponent<TextMeshPro> ();
					if(tmpo != null){
						//Debug.Log (tmpo.text);
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
			Debug.Log (cachedPages[i]);
		}
		pagesRecieved = true;
        LoadTargetsFlag = true;

    }

	void LoadTargets(){
		TrackableBehaviour[] tbs = TrackerManager.Instance.GetStateManager ().GetTrackableBehaviours ().ToArray ();
		if (tbs.Length == 0) {
			return;
		}
		int maxSegment = (cachedPages.Length / tbs.Length) + 1;
		int count = 1;
		for (int i = 0; i < tbs.Length; i++) {
			tbs [i].name = "Marker_" + count++;
			tbs [i].tag = "Marker";
			tbs [i].gameObject.AddComponent<DefaultTrackableEventHandler> ();
			tbs [i].gameObject.AddComponent<TurnOffBehaviour> ();
			Transform canvasOb = (Transform)Transform.Instantiate (canvas);
			Transform textBox = (Transform)Transform.Instantiate (textPrefab);
			textBox.transform.SetParent (canvasOb);
			textBox.GetComponent<RectTransform> ().sizeDelta = new Vector2 (0, 0);

//			if (i + (tbs.Length * segmentPointer) < cachedPages.Length) {
//				textBox.GetComponent<TextMeshPro> ().text = cachedPages [i + (tbs.Length * segmentPointer)];
//			}

			textBox.GetComponent<TextMeshPro> ().alignment = TextAlignmentOptions.TopJustified;
			//textBox.GetComponent<TextMeshPro> ().autoSizeTextContainer = true;
			//textBox.GetComponent<TextMeshPro> ().fontSizeMin = 100;
			//textBox.GetComponent<TextMeshPro> ().fontSizeMax = 9999;

			canvasOb.transform.SetParent(tbs[i].gameObject.transform); 
			canvasOb.transform.localPosition = new Vector3(-0.2f, 0f, -0.4f);

			//textBox.right = 0;

			canvasOb.transform.localRotation = Quaternion.identity;
			canvasOb.transform.localScale = new Vector3 (0.0005f, 0.0005f, 0.0005f);
			canvasOb.transform.Rotate (new Vector3 (90, 0, 0));
			canvasOb.gameObject.SetActive(true);
		}
		LoadSegment (0);
	}

	void LoadSegment(int segment){
		GameObject[] objArr = GameObject.FindGameObjectsWithTag ("Marker");
		for (int i = 0; i < objArr.Length; i++) {
			string page = "";
			if (i + (segment * objArr.Length) < cachedPages.Length) {
				page = cachedPages [i + (segment * objArr.Length)];
			}
			objArr [i].transform.Find ("Canvas Prefab(Clone)").transform.Find ("textPrefab(Clone)").GetComponent<TextMeshPro> ().text = page;
		}
	}
}
