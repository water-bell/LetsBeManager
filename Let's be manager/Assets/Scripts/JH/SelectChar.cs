using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectChar : MonoBehaviour
{
    #region 투수, 타자 능력치 변수선언
    //게임에 존재하는 선수의 수
    static int p = 0;
    static int b = 0;

    //잠재력
    string pitcherP0 = "";
    string pitcherP1 = "";
    string batterP0 = "";
    string batterP1 = "";

    //잠재력을 제외한 능력치
    List<int> pitcher0 = new List<int>() { 0, 0, 0, 0, 0 };
    List<int> pitcher1 = new List<int>() { 0, 0, 0, 0, 0 };
    List<int> batter0 = new List<int>() { 0, 0, 0, 0, 0 };
    List<int> batter1 = new List<int>() { 0, 0, 0, 0, 0 };
    #endregion

    #region 투수 능력치 뽑기
    public void SelectPitcher()
    {
        Character pitcher = new Character();

        if (p == 0)  //기존 선수가 0명일때
        {
            pitcher0 = pitcher.RandStat();
            pitcherP0 = pitcher.RandPoten();
            p++;
        }
        else if (p == 1) //기존 선수가 1명일때
        {
            pitcher1 = pitcher.RandStat();
            pitcherP1 = pitcher.RandPoten();
            p++;
        }

        Debug.Log($"{pitcher0[0]},{pitcher0[1]},{pitcher0[2]},{pitcher0[3]},{pitcher0[4]},{pitcherP0}");
        Debug.Log($"{pitcher1[0]},{pitcher1[1]},{pitcher1[2]},{pitcher1[3]},{pitcher1[4]},{pitcherP1}");

    }
    #endregion

    #region 타자 능력치 뽑기
    public void SelectBatter()
    {
        Character batter = new Character();
        if (b == 0)
        {
            batter0 = batter.RandStat();
            batterP0 = batter.RandPoten();
            b++;
        }
        else if (b == 1)
        {
            batter1 = batter.RandStat();
            batterP1 = batter.RandPoten();
            p++;
        }
        else
        {
            return;
        }
    }
    #endregion
}