
﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class FadeInOutManager : MonoBehaviour {

    private TextMeshPro m_textMeshPro;
    
    IEnumerator Start()
    {
        m_textMeshPro = gameObject.GetComponent<TextMeshPro>() ?? gameObject.AddComponent<TextMeshPro>();


        int totalVisibleCharacters = m_textMeshPro.textInfo.characterCount;
        int counter = 0;

        while (true)
        {
            int visibleCount = counter % (totalVisibleCharacters + 1);

            m_textMeshPro.maxVisibleCharacters = visibleCount;
            //m_textMeshPro.maxVisibleLines = MaxLines;

            if (visibleCount >= totalVisibleCharacters)
            {
                yield return new WaitForSeconds(1.0f);
                //return;
            }

            counter += 1;

            yield return new WaitForSeconds(0.05f);
        }
    }

}

