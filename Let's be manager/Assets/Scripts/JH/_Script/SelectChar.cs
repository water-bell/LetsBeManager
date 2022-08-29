using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectChar : MonoBehaviour
{
    public Text statText;
    public Text potenText;
    public GameObject pitcher0;
    public GameObject pitcher1;
    public GameObject batter0;
    public GameObject batter1;
    
    //게임에 존재하는 선수의 수
    static int p = 0; //투수
    static int b = 0; //타자
    
    //임의로 저장할 변수들
    List<int> randList = new List<int>() { 0, 0, 0, 0, 0 };
    string randPoten;
    

    #region 투수 능력치 뽑기
    public void SelectPitcher()
    {
        Character pitcher = new Character();

        if (p == 0)  //기존 선수가 0명일때
        {
            GameManager.instance.pitcher0.stats = pitcher.RandStat();
            GameManager.instance.pitcher0.poten = pitcher.RandPoten();
            randList = GameManager.instance.pitcher0.stats;
            randPoten = GameManager.instance.pitcher0.poten;
            p++;
        }
        else if (p == 1) //기존 선수가 1명일때
        {
            GameManager.instance.pitcher1.stats = pitcher.RandStat();
            GameManager.instance.pitcher1.poten = pitcher.RandPoten();
            randList = GameManager.instance.pitcher1.stats;
            randPoten = GameManager.instance.pitcher1.poten;
            p++;
        }

    }
    #endregion

    #region 타자 능력치 뽑기
    public void SelectBatter()
    {
        Character batter = new Character();
        if (b == 0)
        {
            GameManager.instance.batter0.stats = batter.RandStat();
            GameManager.instance.batter0.poten = batter.RandPoten();
            randList = GameManager.instance.batter0.stats;
            randPoten = GameManager.instance.batter0.poten;
            b++;
        }
        else if (b == 1)
        {
            GameManager.instance.batter1.stats = batter.RandStat();
            GameManager.instance.batter1.poten = batter.RandPoten();
            randList = GameManager.instance.batter1.stats;
            randPoten = GameManager.instance.batter1.poten;
            b++;
        }
        else
        {
            return;
        }
    }
    #endregion

    public void PickButton()
    {
        int rannum = Random.Range(0, 2);
        for (int a = 0; a<2 ; a++ )
        {
            if (rannum == 0 && p < 2)
            {
                string ranstr = null;

                SelectPitcher();

                for (int i = 0; i < randList.Count; i++)
                {
                    ranstr += randList[i] + "\n";
                }
                pitcher0.SetActive(true);
                pitcher1.SetActive(true);
                batter0.SetActive(false);
                batter1.SetActive(false);
                statText.text = ranstr;
                potenText.text = randPoten;
                break;
            }
            else { rannum = 1; }

            if (rannum == 1 && b < 2)
            {
                string ranstr = null;

                SelectBatter();

                for (int i = 0; i < randList.Count; i++)
                {
                    ranstr += randList[i] + "\n";
                }
                batter0.SetActive(true);
                batter1.SetActive(true);
                pitcher0.SetActive(false);
                pitcher1.SetActive(false);
                statText.text = ranstr;
                potenText.text = randPoten;
                break;
            }
            else { rannum = 0; }
        }
    }
}