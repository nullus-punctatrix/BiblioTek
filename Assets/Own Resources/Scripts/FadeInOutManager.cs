//using UnityEngine;
//using UnityEngine.UI;
//using System.Collections;
//using TMPro;
//public class FadeInOutManager : MonoBehaviour {
//
//    //GameObject textField;
//
//
//	void Start(){
//		
//	}
//    
//
//    void Update()
//    {
//		if (gameObject.activeInHierarchy)
//        {
//			StartCoroutine(FadeTextToFullAlpha(1f, (Text)gameObject.GetComponentInChildren<TextMeshPro>()));
//        }
//		if (!gameObject.activeInHierarchy)
//        {
//			StartCoroutine(FadeTextToZeroAlpha(1f, (Text)gameObject.GetComponentInChildren<TextMeshPro>()));
//        }
//    }
//
//
//
//    public IEnumerator FadeTextToFullAlpha(float t, Text i)
//    {
//        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
//        while (i.color.a < 1.0f)
//        {
//            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
//            yield return null;
//        }
//    }
//
//    public IEnumerator FadeTextToZeroAlpha(float t, Text i)
//    {
//        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
//        while (i.color.a > 0.0f)
//        {
//            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
//            yield return null;
//        }
//    }
//}
