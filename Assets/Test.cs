using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Use this for inializaition
    void Start()
    {

        //要素数5の配列を初期化する
        int[] points = new int[5];

        //配列の各要素に値を代入する
        points[0] =  30;
        points[1] =  20;
        points[2] =  60;
        points[3] =   5;
        points[4] = 100;

        //配列の要素を順番に表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }
        //配列の要素を逆順に表示する
        for (int i = points.Length -1; 0 <= i; i--)
        {
            Debug.Log(points[i]);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}