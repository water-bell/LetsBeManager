using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    [SerializeField] Image GuageBar;
    [SerializeField] Text LoadingText;
    float time;
    int num;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadGuage());
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        num = (int)time;
        switch (num%3)
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
    IEnumerator LoadGuage()
    {
        float timer = 0.0f;
        while (timer != 10.0f)
        {
            timer += Time.deltaTime;
            if (timer < 10.0f)
            {
                GuageBar.fillAmount = Mathf.Lerp(GuageBar.fillAmount, 1.0f, timer);
                if (GuageBar.fillAmount == 1.0f)
                {
                    yield break;
                }
            }
            else
            {
                if (GuageBar.fillAmount == 1.0f)
                {
                    yield break;
                }
            }
        }
    }
}
