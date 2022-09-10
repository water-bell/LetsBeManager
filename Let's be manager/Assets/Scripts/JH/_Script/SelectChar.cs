using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectChar : MonoBehaviour
{
    //활성화 시킬 오브젝트 변수들
    [SerializeField] Text statText1;
    [SerializeField] Text statText2;
    [SerializeField] Text statText3;
    [SerializeField] Text statText4;
    [SerializeField] Text statText5;
    [SerializeField] Text potenText;

    //게임에 존재하는 선수의 수
    static int p = 0; //투수
    static int b = 0; //타자
    
    //임의로 저장할 변수들
    List<int> randList = new List<int>() { 0, 0, 0, 0, 0 };
    string randPoten;

    //투수 타자 정보창 이미지 변환 변수
    [SerializeField] Sprite change_imgP;
    [SerializeField] Sprite change_imgB;
    Image thisImg;


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

    /*
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
    */

    public void RerolllButton()
    {
        int r = Random.Range(0, 2); //투수와 타자를 정할 랜덤변수


        Character rPlayer = new Character();

        List<int> s = rPlayer.RandStat();  //랜덤한 스탯 변수
        string p = rPlayer.RandPoten(); //랜덤한 잠재력 변수

        GameManager.instance.yesBtn = false;  //선수영입 상태를 false로 초기화
        //리롤을 위해서 임의로 게임매니저에 저장
        GameManager.instance.rPick = r; // 선수의 종류 투수 0, 타자 1
        GameManager.instance.rStat = s;
        GameManager.instance.rPoten = p;

        statText1.text = s[0].ToString();
        statText2.text = s[1].ToString();
        statText3.text = s[2].ToString();
        statText4.text = s[3].ToString();
        statText5.text = s[4].ToString();
        potenText.text = p;


        if (r == 0) //투수일때 UI를 투수 정보창으로 변경
        {
            thisImg = GameObject.Find("TransferPlayer").GetComponent<Image>();
            thisImg.sprite = change_imgP;
        }
        if (r == 1) //타자일때 UI를 타자 정보창으로 변경
        {
            thisImg = GameObject.Find("TransferPlayer").GetComponent<Image>();
            thisImg.sprite = change_imgB;
        }
    }

    public void yesButton()
    {
        GameManager.instance.yesBtn = true; //선수 스탯 저장 시작

        if(GameManager.instance.rPick == 0) //투수일때 스탯저장
        {
            if(p == 0) //보유중인 투수가 0명일때
            {
                GameManager.instance.pitcher0.stats = GameManager.instance.rStat;
                GameManager.instance.pitcher0.poten = GameManager.instance.rPoten;
                p++; //보유중인 투수의 수 증가
            }
            else if(p == 1) //보유중인 투수가 1명일때
            {
                GameManager.instance.pitcher1.stats = GameManager.instance.rStat;
                GameManager.instance.pitcher1.poten = GameManager.instance.rPoten;
                p++;
            }
            else
            {
                Debug.Log("보유하고 있는 투수의 수를 초과하여 영입할 수 없습니다.");
            }
        }
        if(GameManager.instance.rPick == 1) //타자일때 스탯저장
        {
            if(b == 0) //보유중인 타자가 0명일때
            {
                GameManager.instance.batter0.stats = GameManager.instance.rStat;
                GameManager.instance.batter0.poten = GameManager.instance.rPoten;
                b++;
            }
            else if(b == 1) //보유중인 타자가 1명일때
            {
                GameManager.instance.batter1.stats = GameManager.instance.rStat;
                GameManager.instance.batter1.poten = GameManager.instance.rPoten;
                b++;
            }
            else
            {
                Debug.Log("보유하고 있는 타자의 수를 초과하여 영입할 수 없습니다.");
            }

        }

        GameManager.instance.yesBtn = false; //선수 스탯 저장 종료

    }
}