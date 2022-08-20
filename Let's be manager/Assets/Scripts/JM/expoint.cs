using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Min
{
    public class expoint : MonoBehaviour
    {
        List<int> playerstat = new List<int>() { 0, 0, 0, 0, 0 } ; //선수 능력치

        public List<int> adv = new List<int>() { 0, 0, 0, 0, 0 }; //선수 능력치의 경험치
        

        public void train1()
        {
            playerstat[0] += 1;
            if(playerstat[0]==100)
            {
                playerstat[0] = 0;
                adv[0] += 1;
            }
            Debug.Log("훈련1을 시작하겠습니다.");
            
        }

        public void train2()
        {
            playerstat[1] += 1;
            if (playerstat[1] == 100)
            {
                playerstat[1] = 0;
                adv[1] += 1;
            }
        }

        public void train3()
        {
            playerstat[2] += 1;
            if (playerstat[2] == 100)
            {
                playerstat[2] = 0;
                adv[2] += 1;
            }
        }

        public void train4()
        {
            playerstat[3] += 1;
            if (playerstat[3] == 100)
            {
                playerstat[3] = 0;
                adv[3] += 1;
            }
        }

        public void train5()
        {
            playerstat[4] += 1;
            if (playerstat[4] == 100)
            {
                playerstat[4] = 0;
                adv[4] += 1;
            }
        }

        public void train6()
        {
            playerstat[5] += 1;
            if (playerstat[5] == 100)
            {
                playerstat[5] = 0;
                adv[5] += 1;
            }
        }

        
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

        }
        
    }

}

