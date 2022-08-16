using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using UnityEngine;

public class Meeting : MonoBehaviour
{
    List<int> PlayerStat = new List<int>() { }; // 선수 능력치 가져와서 리스트에 저장
    List<int> StatExp = new List<int>() { }; // 선수 능력치의 경험치 가져와서 리스트에 저장 -->>>>> 스탯 리스트의 인덱스가 경험치의 리스트의 인덱스와 일치해야함!!

    int MaxIndex;
    int Max2ndIndex;
    int MinIndex;
    int Min2ndIndex;
    int MeetingResult;
    
    void Start()
    {
          
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void FindStat() // 스탯 최대 최소값 찾기
    {  
        MaxIndex = PlayerStat.IndexOf(PlayerStat.Max());
        MinIndex = PlayerStat.IndexOf(PlayerStat.Min());
        if(MeetingResult == 2)// 2번째로 낮은 스탯 찾기
        {
            PlayerStat.RemoveAt(MinIndex);
            Min2ndIndex = PlayerStat.IndexOf(PlayerStat.Min());
        }
        else if(MeetingResult == 3)// 2번째로 높은 스탯 찾기
        {
            PlayerStat.RemoveAt(MaxIndex);
            Max2ndIndex = PlayerStat.IndexOf(PlayerStat.Max());
        }
    }
    public void PlayerMeeting()
    {
        float[] probs = new float[] { 1f, 2f, 8f, 9f, 10f, 15f, 15f, 20f, 20f }; // 케이스별 확률
        System.Random rand = new System.Random();
        float r = rand.Next(0, 101); // 랜덤 0~100

        float cumulative = 0.0f; // 가중치 초기값

        for (int i = 0; i < 9; i++) //케이스 수 만큼 가중치에 확률을 더해줌
        {
            cumulative += probs[i]; // 가중치
            if (r <= cumulative) // 가중치가 랜덤한 값을 넘어서면 그 케이스
            {
                MeetingResult = i;
                break;
            }
        }
        //FindStat(); // MeetingResult 값 받아와서 최대 최소 스탯 계산; ---> 리스트에 스탯 및 경험치 할당 후에 활성화
        switch (MeetingResult)
        {
            case 0:
                Debug.Log("모든 선수 스탯 경험치 20 감소");
                break;
            case 1:
                Debug.Log("선수 잠재력 한단계 상승");
                break;
            case 2:
                Debug.Log("선수 가장 낮은 스탯 2가지 경험치 30 증가");
                break;
            case 3:
                Debug.Log("선수 가장 높은 스탯 2가지 경험치 20 감소");
                break;
            case 4:
                Debug.Log("선수 가장 높은 스탯 1가지 경험치 10 감소");
                break;
            case 5:
                Debug.Log("선수 가장 높은 스탯 1가지 경험치 40 증가");
                break;
            case 6:
                Debug.Log("선수 랜덤 스탯 1가지 경험치 10 감소");
                break;
            case 7:
                Debug.Log("선수 가장 낮은 스탯 1가지 경험치 40 증가");
                break;
            case 8:
                Debug.Log("아무 일도 일어나지 않음");               
                break;
        }
    }
}
