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

    //선수정보 투수2,타자2
    public PlayerData pitcher0 = new PlayerData();
    public PlayerData pitcher1 = new PlayerData();
    public PlayerData batter0 = new PlayerData();
    public PlayerData batter1 = new PlayerData();
}
