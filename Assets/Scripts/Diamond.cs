using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    /// <summary>
    /// ダイヤモンドの個数
    /// </summary>
    private int diamondCount;
    // Start is called before the first frame update
    void Start()
    {
        diamondCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(diamondCount);
    }

    // ダイヤモンドの個数をセットする
    public int Set(int value)
    {
        diamondCount = value;
        return diamondCount;
    }
    
    // ダイヤモンドの数を変える
    public int Change(GateScript.Operators op, int value)
    {
        // opがAddだった場合
        if (op == GateScript.Operators.Add)
        {
            add(value);
        }
        // opがSubtractだった場合
        if (op == GateScript.Operators.Subtract)
        {
            subtract(value);
        }
        // opがMultiplyだった場合
        if (op == GateScript.Operators.Multiply)
        {
            multiply(value);
        }
        // opがDivideだった場合
        if (op == GateScript.Operators.Divide)
        {
            divide(value);
        }
        return diamondCount;
    }

    // ダイヤモンドの個数を増やす(足し算する)
    private int add(int value)
    {
        diamondCount += value;
        return diamondCount;
    }

    // ダイヤモンドの個数を減らす(引き算する)
    private int subtract(int value)
    {
        diamondCount -= value;
        return diamondCount;
    }

    // ダイヤモンドの個数を掛ける(掛け算する)
    private int multiply(int value)
    {
        diamondCount *= value;
        return diamondCount;
    }

    // ダイヤモンドの個数を割る(割り算する)
    private int divide(int value)
    {
        diamondCount /= value;
        return diamondCount;
    }
}
