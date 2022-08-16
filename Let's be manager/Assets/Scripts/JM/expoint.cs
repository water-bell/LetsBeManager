using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Min
{
    public class expoint : MonoBehaviour
    {
        public int stat;
        public int advant;

    // Start is called before the first frame update
    void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        private void stats()
        {
            if(advant <= 99)
            {
                advant += 1;
            }
            else
            {
                advant = 0;
                stat += 1;
            }
            //자세하게 나오면 이후 수정예정
        }
    }

}

