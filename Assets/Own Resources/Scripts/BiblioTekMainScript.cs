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
	public GameObject test;
	private bool LoadTargetsFlag = true;

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
			tbs [i].name = "Marker_" + i;
			tbs [i].gameObject.AddComponent<DefaultTrackableEventHandler> ();
			tbs [i].gameObject.AddComponent<TurnOffBehaviour> ();
			GameObject augmentation = (GameObject)GameObject.Instantiate(test);
			augmentation.transform.parent = tbs[i].gameObject.transform;
			augmentation.transform.localPosition = new Vector3(0f, 0f, 0f);
			augmentation.transform.localRotation = Quaternion.identity;
			//augmentation.transform.localScale = new Vector3(0.005f, 0.005f, 0.005f);
			augmentation.gameObject.SetActive(true);
		}
	}
}
