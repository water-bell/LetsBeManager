using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using UnityEngine;

public class Meeting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayerMeeting()
    {
        float[] probs = new float[] { 1f, 2f, 8f, 9f, 10f, 15f, 15f, 20f, 20f }; // 케이스별 확률
        //float totalProbs = 100.0f;
        System.Random rand = new System.Random();
        float r = rand.Next(0, 101); // 랜덤 0~100
        int MeetingResult = 0; //초기화
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

        switch (MeetingResult)
        {
            case 0:
                Debug.Log("0");
                // 모든 선수 스탯 경험치 20 감소; 
                break;
            case 1:
                Debug.Log("1");
                // 선수 잠재력 한단계 상승;
                break;
            case 2:
                Debug.Log("2");
                //선수 가장 낮은 스탯 2가지 경험치 30 증가;
                break;
            case 3:
                Debug.Log("3");
                //선수 가장 높은 스탯 2가지 경험치 20 감소;
                break;
            case 4:
                Debug.Log("4");
                //선수 가장 높은 스탯 1가지 경험치 10 감소;
                break;
            case 5:
                Debug.Log("5");
                //선수 가장 높은 스탯 1가지 경험치 40 증가;
                break;
            case 6:
                Debug.Log("6");
                //선수 랜덤 스탯 1가지 경험치 10 감소;
                break;
            case 7:
                Debug.Log("7");
                //선수 가장 낮은 스탯 1가지 경험치 40 증가;
                break;
            case 8:
                Debug.Log("8");
                break;
        }
    }
}
