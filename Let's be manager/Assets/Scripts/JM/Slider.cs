using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Slider : MonoBehaviour
{
    Slider slHP;
    float fSliderBarTime;
    public float e;
    public float maxE;
    
    /*
    public void setExp(e)
    {
        slHP.value = e;
    }
    */
    // Start is called before the first frame update
    void Start()
    {
       slHP = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (e <= 0)
            transform.Find("fill").gameObject.SetActive(false);
        else
            transform.Find("fill").gameObject.SetActive(true);
        
    }
}
