using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpBar : MonoBehaviour
{

    private Slider slider;
    public float fillSpeed = 5f;
    private float targetProgress = 0;
    void Start()
    {
        slider = gameObject.GetComponent<Slider>();
    }

    
    void Update()
    {
        
    }

    public void AddProgress()
    {

    }
}
