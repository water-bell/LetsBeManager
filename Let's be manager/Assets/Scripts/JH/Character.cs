using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    #region 변수 선언
    // 투수의 능력치 제구/구속/변화/구위/멘탈/잠재력
    // 타자의 능력치 정확/힘/주루/수비/멘탈/잠재력

    static int sum = 150; //능력치의 합이 150으로 일정

    public int hap; //합을 검사할 변수
    public int result; //잠재력 결과
    public float probs; //잠재력 랜덤 확률 뽑기
    public float cumulative; //가중치
    public float[] weights = { 0f, 2f, 7f, 21f, 40f, 30f }; //확률
    public string Potential; //잠재력을 저장할 변수
    
    int[] stats = new int[5];

    #endregion

    #region 능력치 뽑기 메서드
    public void RandStat()
    {
        // 변수 초기화
        hap = 0;
        probs = 0;
        cumulative = 0;
        result = 0;
        Potential = "";

        // 잠재력을 제외한 5개의 능력치 뽑기
        for (int i = 0; i < 5; i++)
        {
            stats[i] = Random.Range(20, 41); //20~40 랜덤 값
            hap += stats[i];
        }

        // 잠재력 뽑기
        probs = Random.Range(0f, 101f);
        for(int a = 0; a  < 6; a++)
        {
            cumulative += weights[a]; //가중치 더하기

            if(probs <= cumulative)
            {
                result = a;
                break;
            }
        }
        switch(result)
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
    }
    #endregion

    //합이 150이 되는지 검사
    public void TestStat()
    {
        while(hap != sum)
        {
            RandStat();
        }
        Debug.Log($"{ stats[0]}, {stats[1]}, {stats[2]}, {stats[3]}, {stats[4]}, {Potential}");
    }

}