using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectChar : MonoBehaviour
{
    //게임에 존재하는 선수의 수
    static int p = 0; //투수
    static int b = 0; //타자

    #region 투수 능력치 뽑기
    public void SelectPitcher()
    {
        Character pitcher = new Character();

        if (p == 0)  //기존 선수가 0명일때
        {
            GameManager.instance.pitcher0.stats = pitcher.RandStat();
            GameManager.instance.pitcher0.poten = pitcher.RandPoten();
            p++;
        }
        else if (p == 1) //기존 선수가 1명일때
        {
            GameManager.instance.pitcher1.stats = pitcher.RandStat();
            GameManager.instance.pitcher1.poten = pitcher.RandPoten();
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
            b++;
        }
        else if (b == 1)
        {
            GameManager.instance.batter1.stats = batter.RandStat();
            GameManager.instance.batter1.poten = batter.RandPoten();
            p++;
        }
        else
        {
            return;
        }
    }
    #endregion
}