using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectChar : MonoBehaviour
{
    public void SelectPicher()
    {
        Character pitcher = new Character();
        pitcher.TestStat();
    }

    public void SelectBatter()
    {
        Character batter = new Character();
        batter.TestStat();
    }
}