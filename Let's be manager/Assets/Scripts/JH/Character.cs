using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    #region 변수 선언

    static int sum = 150; //능력치의 합이 150으로 일정

    private int hap; //합을 검사할 변수
    private int result; //잠재력 결과
    private float probs; //잠재력 랜덤 확률 뽑기
    private float cumulative; //가중치
    private float[] weights = { 0f, 2f, 7f, 21f, 40f, 30f }; //확률
    private string Potential; //잠재력을 저장할 변수
    public List<int> stats = new List<int>();

    #endregion

    #region 능력치 뽑기 메서드
    public List<int> RandStat()
    {
        // 변수 초기화
        hap = 0;
        stats = new List<int>() { 0, 0, 0, 0, 0 };

        // 잠재력을 제외한 5개의 능력치 뽑기
        while (hap != sum)
        {
            hap = 0;
            for (int i = 0; i < 5; i++)
            {
                stats[i] = Random.Range(20, 41); //20~40 랜덤 값
                hap += stats[i];
            }
            if (hap == sum)
            {
                break;
            }
        }
        return stats;
    }
    #endregion

    #region 잠재력 뽑기 메서드
    public string RandPoten()
    {
        // 변수 초기화
        probs = 0;
        cumulative = 0;
        result = 0;
        Potential = "";
        
        probs = Random.Range(0f, 101f); //랜덤한 확률

        for (int a = 0; a < 6; a++)
        {
            cumulative += weights[a]; //가중치 더하기

            if (probs <= cumulative)
            {
                result = a;
                break;
            }
        }
        switch (result)  //확률 별로 분류
        {
            case 0:
                Potential = "A";
                break;
            case 1:
                Potential = "B";
                break;
            case 2:
                Potential = "C";
                break;
            case 3:
                Potential = "D";
                break;
            case 4:
                Potential = "E";
                break;
            case 5:
                Potential = "F";
                break;
        }
        return Potential;
    }
    #endregion
}