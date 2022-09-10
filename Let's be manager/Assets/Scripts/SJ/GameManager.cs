using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance != this)
                Destroy(this.gameObject);
        }

    }
    public int Gold = 0;
    public int Popularity = 0;
    public int Year = 0;
    public int Week = 1;

    #region 선수정보 투수2,타자2
    public PlayerData pitcher0 = new PlayerData();
    public PlayerData pitcher1 = new PlayerData();
    public PlayerData batter0 = new PlayerData();
    public PlayerData batter1 = new PlayerData();

    #endregion

    #region 선수 영입시 필요한 변수
    public bool yesBtn; //선수영입시 사용할 확인 값
    public List<int> rStat = new List<int>() { 0, 0, 0, 0, 0 }; //랜덤스탯을 저장할 임의의 변수
    public string rPoten = null; //랜덤 잠재력을 저장할 임의의 변수
    public int rPick; //선수의 종류 투수 0, 타자 1

    #endregion

}