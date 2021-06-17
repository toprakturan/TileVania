using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileVaniaTextColor : MonoBehaviour
{
    [SerializeField] [Range(0f, 2f)] float LerpTime;
    [SerializeField] Color[] myColors;
    Text text;

    int colorIndex = 0;
    float t = 0f;
    int len;
    void Start()
    {
        text = GetComponent<Text>();
        len = myColors.Length;
    }

    
    void Update()
    {
        text.color = Color.Lerp(text.color, myColors[colorIndex], LerpTime* Time.deltaTime);

        t = Mathf.Lerp(t, 1f, LerpTime*Time.deltaTime);
        if (t > .9f)
        {
            t = 0f;
            colorIndex++;
            colorIndex = (colorIndex >= len) ? 0 : colorIndex;
        }
    }
}
