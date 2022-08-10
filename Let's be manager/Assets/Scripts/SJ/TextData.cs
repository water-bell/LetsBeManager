using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextData : MonoBehaviour
{
    private DateTime InitTime = new DateTime(2022, 1, 1); // 초기 날짜 2022년 1월 1일
    public Text DateText;
    public Text PopularityText;
    public Text GoldText;
    private void Awake()
    {
        TextDate();
        
    }

    void Start()
    {
        TextPopularity();
        TextGold();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void TextDate()
    {
        DateText.text = InitTime.ToString("yyyy년 MM월 dd일");
    }
   private void TextPopularity()
    {
        PopularityText.text += GameManager.instance.Popularity.ToString(); ;
    }
    private void TextGold()
    {
        GoldText.text = GameManager.instance.Gold.ToString() + "G";
    }
}
