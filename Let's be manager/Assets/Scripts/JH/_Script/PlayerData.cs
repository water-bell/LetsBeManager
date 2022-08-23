using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData
{
    // 투수의 능력치 제구/구속/변화/구위/멘탈/잠재력
    // 타자의 능력치 정확/힘/주루/수비/멘탈/잠재력

    public Image playerImage; //선수 사진
    public List<int> stats; //능력치
    public List<int> exp; //능력치의 경험치
    public string poten; //잠재력
    public string name; //선수이름
}
