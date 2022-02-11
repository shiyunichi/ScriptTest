using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int hp = 100; //体力
    private int power = 25;　//攻撃力
    private int mp = 53; //魔力

    //攻撃用の関数
    public void Attak()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
    }

    //魔法用の関数
    public void Magic()
    {
        if (this.mp > 5)
        {
            Debug.Log("魔法攻撃をした");
        }
        else
        {
            Debug.Log("mpが足りない");
        }

        //残りmpを減らす
        this.mp -= 5;
        
    }

}
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

        //Bossクラスの変数を宣言してインスタンスを代入
        Boss boss = new Boss();

        //攻撃用の関数を呼び出す
        boss.Attak();
        //防御用の関数を呼び出す
        boss.Defence(3);
        //魔法用の関数を呼び出す
        for (int i = 0; i < 11; i++)
        {
            boss.Magic();
        }
        

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
