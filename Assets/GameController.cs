using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private int count = 10000;

    public void ClickStartButton()
    {
        var startTime = DateTime.Now;

        GameObject.Find("Total").GetComponent<Text>().text = CalcPrime().ToString();
        GameObject.Find("Time").GetComponent<Text>().text = (DateTime.Now - startTime).ToString();
    }

    private long CalcPrime()
    {
        long total = 0;

        for (int i = 1; i <= count; i++)
        {
            total += i;
        }

        return total;
    }
}
