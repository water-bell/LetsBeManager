using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    [SerializeField] Image GuageBar;
    [SerializeField] Text LoadingText;
    private float time;
    private int num;
    private bool isEnded = true;
    private float time_loading = 3;
    private float time_current;
    private float time_start;
    // Start is called before the first frame update
    void Start()
    {
        Reset_Loading();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        num = (int)time;
        if (!isEnded)
        {
            switch (num % 3)
            {
                case 0:
                    {
                        LoadingText.text = "면담을 진행중입니다.";
                        break;
                    }
                case 1:
                    {
                        LoadingText.text = "면담을 진행중입니다..";
                        break;
                    }
                case 2:
                    {
                        LoadingText.text = "면담을 진행중입니다...";
                        break;
                    }
            }
        }
        if (isEnded)
            return;
        Check_Loading();
    }
    private void Check_Loading() //로딩 완료 때까지 게이지 진행
    {
        time_current = Time.time - time_start;
        if (time_current < time_loading)
        {
            GuageBar.fillAmount = time_current / time_loading;
        }
        else if (!isEnded)
        {
            End_Loading();
        }
    }
    private void End_Loading() // 로딩 완료
    {
        GuageBar.fillAmount = 1.0f;
        isEnded = true;
    }

    private void Reset_Loading() //초기화
    {
        time_current = time_loading;
        time_start = Time.time;
        GuageBar.fillAmount = 0.0f;
        isEnded = false;
    }
}