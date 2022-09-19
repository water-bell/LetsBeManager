using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextData : MonoBehaviour
{
    //private DateTime InitTime = new DateTime(2022, 1, 1); // 초기 날짜 2022년 1월 1일 => Year년차 Week/MaxWeek주 로 수정
    int MaxWeek = 52;
    public Text DateText;
    public Text PopularityText;
    public Text GoldText;
    public Text AcademyNameText;
    public Text ManagerNameText;
    private void Awake()
    {
        
        
    }

    void Start()
    {
        TextPopularity();
        TextGold();
        TextDate();
        TextAcademyName();
        TextManagerName();
    }

    // Update is called once per frame
    void Update()
    {
        TextPopularity();
        TextGold();
        TextDate();
    }
    private void TextDate()
    {
        DateText.text = GameManager.instance.Year.ToString() + "년차 " + GameManager.instance.Week + "/" + MaxWeek + "주";
    }
   private void TextPopularity()
    {
        PopularityText.text = "인지도 : "+ GameManager.instance.Popularity.ToString(); ;
    }
    private void TextGold()
    {
        GoldText.text = GameManager.instance.Gold.ToString() + "G";
    }
    private void TextAcademyName()
    {
        AcademyNameText.text = GameManager.instance.AcademyName;
    }
    private void TextManagerName()
    {
        ManagerNameText.text = GameManager.instance.ManagerName;
    }

}

