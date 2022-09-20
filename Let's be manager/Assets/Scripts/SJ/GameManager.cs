using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    #region 아카데미 및 게임 정보
    public int Gold = 0; 
    public int Popularity = 0;
    public char PopularityGrade = 'C'; //인지도 등급
    public int Year = 0;
    public int Week = 1;
    public string AcademyName = "활빈당"; 
    public string ManagerName = "홍길동";
    public int CurrentPlayerNum = 0; //현재 인원 수
    public int GraduatedPlayerNum = 0; // 졸업 인원 수 
    public int SuccessPlayerNum = 0; // 대학/프로 진출 인원 수


    #endregion

    #region 선수 정보
    public List<Player> PlayerList = new List<Player>();

    public class Player
    {
        public string name;  
        public int age;

        //투수인지 타자인지
        bool isPitcher = false;
        bool isHitter = false;

        //Hitter stats
        public int contact = 0; //정확
        public int power = 0; //힘
        public int speed = 0; //주루
        public int field = 0; //수비

        //Pitcher stats
        public int control = 0; //제구
        public int velocity = 0; //구속
        public int breaking = 0; //변화
        public int stuff = 0; //구위

        //Common stats
        public int mental = 0; //멘탈
        public char potential = 'D'; //잠재력

        Image playerimage; //선수 이미지
    }
    #endregion

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