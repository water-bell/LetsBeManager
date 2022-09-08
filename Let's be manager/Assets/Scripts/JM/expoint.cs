using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



namespace Min
{
    
    public class expoint : MonoBehaviour
    {
        #region 변수 선언
        List<double> playerstat = new List<double>() { 0, 0, 0, 0, 0 }; //선수 능력치

        public List<double> adv = new List<double>() { 0, 0, 0, 0, 0 }; //선수 경험치

        private double p_result; //잠재력의 결과값을 수치로 변경할 값
        private double e_result; //훈련장비의 결과값을 수치로 변경할 값
        private double f_result; //훈련시설의 결과값을 수치로 변경할 값

        private string potential; //잠재력의 결과값을 수치로 변경할 값
        private string equipment; //훈련장비의 결과값을 수치로 변경할 값
        private string facility; //훈련시설의 결과값을 수치로 변경할 값

        private double exP = 0;
       

        #endregion

        #region
        public double potentResult()
        {
            p_result = 0;
            potential = "A";
            switch (potential)
            {
                case "A":
                    p_result = 1.4;
                    break;
                case "B":
                    p_result = 1.1;
                    break;
                case "C":
                    p_result = 1;
                    break;
                case "D":
                    p_result = 0.9;
                    break;
                case "E":
                    p_result = 0.78;
                    break;
                case "F":
                    p_result = 0.6;
                    break;
            }
            return p_result;

        }

        public double equipResult()
        {
            e_result = 0;
            equipment = "A";
            switch (equipment)
            {
                case "A":
                    e_result = 1.3;
                    break;
                case "B":
                    e_result = 1.18;
                    break;
                case "C":
                    e_result = 1.1;
                    break;
                case "D":
                    e_result = 1.06;
                    break;
                case "E":
                    e_result = 1;
                    break;

            }
            return e_result;
        }


        public double facilitResult()
            {
                f_result = 0;
                facility = "A";
                switch (facility)
                {
                    case "A":
                        f_result = 2;
                        break;
                    case "B":
                        f_result = 1.8;
                        break;
                    case "C":
                        f_result = 1.6;
                        break;
                    case "D":
                        f_result = 1.4;
                        break;
                    case "E":
                        f_result = 1.2;
                        break;

                }
                return f_result;
           

            }

        public double exPresult()
        {
            
            exP = 10* p_result * e_result * f_result;
            //
            return exP;
        }

        

        #endregion
        public void train1() //티배팅
        {
            playerstat[0] += exP;
            if (playerstat[0] == 100)
            {
                playerstat[0] = 0;
                adv[0] += 1;
            }

            Debug.Log("훈련1을 시작하겠습니다.");
            
        }

        public void train2() //타이어훈련
        {
            
        }

        public void train3() //달리기
        {
            
        }

        public void train4() //펑고
        {
           
        }

        public void train5() //쉐도우피칭
        {
            
        }

        public void train6() //타이어훈련
        {
            
        }

        public void train7() //악력훈련
        {

        }

        public void train8() //라이브피칭
        {

        } 
        public void train9() //명상
        {

        }
        public void train10() //웨이트 트레이닝
        {

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

