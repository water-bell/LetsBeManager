using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class SaveData // 저장할 데이터의 Class 정의
{
    public int gold;
    public int popularity;
    public char popularitygrade;
    public int year;
    public int week;
    public string academyname;
    public string managername;
    public int currentplayernum;
    public int graduatedplayernum;
    public int successplayernum;
    public List<GameManager.Player> playerlist = new List<GameManager.Player>(); 
}

public class DataManager : MonoBehaviour
{
    string path;
    // Start is called before the first frame update
    void Start()
    {
        path = Path.Combine(Application.persistentDataPath, "database.json"); //경로설정
        JsonLoad();
    }
    
    public void JsonLoad()
    {
        SaveData saveData = new SaveData();
        if (!File.Exists(path)) // Path에 저장된 데이터 없으면 초기화
        {
            GameManager.instance.Gold = 0;
            GameManager.instance.Popularity = 0;
            GameManager.instance.PopularityGrade = 'C';
            GameManager.instance.Year = 0;
            GameManager.instance.Week = 1;
            GameManager.instance.AcademyName = "활빈당";
            GameManager.instance.ManagerName = "홍길동";
            GameManager.instance.CurrentPlayerNum = 0;
            GameManager.instance.GraduatedPlayerNum = 0;
            GameManager.instance.SuccessPlayerNum = 0;
            JsonSave();
        }
        else
        {
            string loadJson = File.ReadAllText(path);
            saveData = JsonUtility.FromJson<SaveData>(loadJson);

            if (saveData != null) // 저장된 데이터 불러오기
            {
                GameManager.instance.Gold = saveData.gold;
                GameManager.instance.Popularity = saveData.popularity;
                GameManager.instance.PopularityGrade = saveData.popularitygrade;
                GameManager.instance.Year = saveData.year;
                GameManager.instance.Week = saveData.week;
                GameManager.instance.AcademyName = saveData.academyname;
                GameManager.instance.ManagerName = saveData.managername;
                GameManager.instance.CurrentPlayerNum = saveData.currentplayernum;
                GameManager.instance.GraduatedPlayerNum = saveData.graduatedplayernum;
                GameManager.instance.SuccessPlayerNum = saveData.successplayernum;

                for (int i = 0; i < saveData.playerlist.Count; i++)
                {
                    GameManager.instance.PlayerList.Add(saveData.playerlist[i]);
                }
            }

        }
    }
    public void JsonSave()
    {
        SaveData saveData = new SaveData();

        saveData.gold = GameManager.instance.Gold;
        saveData.popularity = GameManager.instance.Popularity;
        saveData.popularitygrade = GameManager.instance.PopularityGrade;
        saveData.year = GameManager.instance.Year;
        saveData.week = GameManager.instance.Week;
        saveData.academyname = GameManager.instance.AcademyName;
        saveData.managername = GameManager.instance.ManagerName;
        saveData.currentplayernum = GameManager.instance.CurrentPlayerNum;
        saveData.graduatedplayernum = GameManager.instance.GraduatedPlayerNum;
        saveData.successplayernum = GameManager.instance.SuccessPlayerNum;

        for(int i=0; i<saveData.playerlist.Count; i++)
        {
            saveData.playerlist.Add(GameManager.instance.PlayerList[i]);
        }

        string json = JsonUtility.ToJson(saveData, true); // json으로 변환

        File.WriteAllText(path, json); //json 데이터를 path에 파일로 저장
    }
    public void JsonDelete()
    {
        File.Delete(path);
    }
}
