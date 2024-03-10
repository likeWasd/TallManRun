using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiamondManager : MonoBehaviour
{
    /// <summary>
    /// ダイヤモンドの個数
    /// </summary>
    private int diamondCount;
    [SerializeField] TextMeshProUGUI tmpDiamondCount;
    // Start is called before the first frame update
    void Start()
    {
        diamondCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(diamondCount);
        tmpDiamondCount.text = "Diamond " + diamondCount.ToString();
    }

    // ダイヤモンドの個数をセットする
    public int Set(int value)
    {
        diamondCount = value;
        return diamondCount;
    }
    
    // ダイヤモンドの数を変える
    public int Change(DiamondGateScript.Operators op, int value)
    {
        switch (op)
        {
            // opがAddだった場合
            case DiamondGateScript.Operators.Add:
                Add(value);
                break;
            // opがSubtractだった場合
            case DiamondGateScript.Operators.Subtract:
                Subtract(value);
                break;
            // opがMultiplyだった場合
            case DiamondGateScript.Operators.Multiply:
                Multiply(value);
                break;
            // opがDivideだった場合
            case DiamondGateScript.Operators.Divide:
                Divide(value);
                break;
        }
        return diamondCount;
    }

    // ダイヤモンドの個数を増やす(足し算する)
    private int Add(int value)
    {
        diamondCount += value;
        return diamondCount;
    }

    // ダイヤモンドの個数を減らす(引き算する)
    private int Subtract(int value)
    {
        diamondCount -= value;
        return diamondCount;
    }

    // ダイヤモンドの個数を掛ける(掛け算する)
    private int Multiply(int value)
    {
        diamondCount *= value;
        return diamondCount;
    }

    // ダイヤモンドの個数を割る(割り算する)
    private int Divide(int value)
    {
        diamondCount /= value;
        return diamondCount;
    }
}
