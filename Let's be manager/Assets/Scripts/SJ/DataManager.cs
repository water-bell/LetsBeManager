using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveData // 저장할 데이터의 Class 정의, 추후 더 추가될 예정 ( 아카데미 정보, 선수 정보 )
{
    public int gold;
    public int popularity;
    public int year;
    public int week;
    public string academyname;
    public string managername;
}

public class DataManager : MonoBehaviour
{
    string path;
    // Start is called before the first frame update
    void Start()
    {
        path = Path.Combine(Application.dataPath, "database.json");
        JsonLoad();
    }
    
    public void JsonLoad()
    {
        SaveData saveData = new SaveData();
        if (!File.Exists(path)) // Path에 저장된 데이터 없으면 초기화
        {
            GameManager.instance.Gold = 0;
            GameManager.instance.Popularity = 0;
            GameManager.instance.Year = 0;
            GameManager.instance.Week = 1;
            GameManager.instance.AcademyName = "활빈당";
            GameManager.instance.ManagerName = "홍길동";
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
                GameManager.instance.Year = saveData.year;
                GameManager.instance.Week = saveData.week;
                GameManager.instance.AcademyName = saveData.academyname;
                GameManager.instance.ManagerName = saveData.managername;
            }

        }
    }
    public void JsonSave()
    {
        SaveData saveData = new SaveData();

        saveData.gold = GameManager.instance.Gold;
        saveData.popularity = GameManager.instance.Popularity;
        saveData.year = GameManager.instance.Year;
        saveData.week = GameManager.instance.Week;
        saveData.academyname = GameManager.instance.AcademyName;
        saveData.managername = GameManager.instance.ManagerName;

        string json = JsonUtility.ToJson(saveData, true); // json으로 변환

        File.WriteAllText(path, json); //json 데이터를 path에 파일로 저장
    }
    public void JsonDelete()
    {
        File.Delete(path);
    }
}
