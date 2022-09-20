using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextData : MonoBehaviour
{
    int MaxWeek = 52;
    public Text DateText;
    public Text PopularityText;
    public Text GoldText;
    public Text AcademyNameText;
    public Text ManagerNameText;
    public Text CurrentPlayerNumText;
    public Text GraduatedPlayerNumText;
    public Text SuccessPlayerNumText;
    public Text PopularityGradeText;
    private void Awake()
    {
        
        
    }

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        TextPopularity();
        TextGold();
        TextDate();
        TextAcademyName();
        TextManagerName();
        TextCurrentPlayerNum();
        TextGraduatedPlayerNum();
        TextSuccessPlayerNum();
        TextPopularityGrade();
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

    private void TextCurrentPlayerNum()
    {
        CurrentPlayerNumText.text = GameManager.instance.CurrentPlayerNum.ToString();
    }
    private void TextGraduatedPlayerNum()
    {
        GraduatedPlayerNumText.text = GameManager.instance.GraduatedPlayerNum.ToString();
    }
    private void TextSuccessPlayerNum()
    {
        SuccessPlayerNumText.text = GameManager.instance.SuccessPlayerNum.ToString();
    }
    private void TextPopularityGrade()
    {
        PopularityGradeText.text = GameManager.instance.PopularityGrade.ToString() + "등급 (" + GameManager.instance.Popularity.ToString() +"100)";
    }
}

