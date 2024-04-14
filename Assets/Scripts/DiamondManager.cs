using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiamondManager : MonoBehaviour
{
    /// <summary>
    /// ダイヤモンドの個数
    /// </summary>
    public int diamondCount;
    [SerializeField] int diamondDefaultValue;
    [SerializeField] TextMeshProUGUI tmpDiamondCount;
    KeyManager keyManager;
    // Start is called before the first frame update
    void Start()
    {
        diamondCount = diamondDefaultValue;
    }

    // Update is called once per frame
    void Update()
    {
        diamondCount =  Mathf.Clamp(diamondCount, 0, diamondCount);
        tmpDiamondCount.text = "Diamond " + diamondCount.ToString();
    }

    // ダイヤモンドの個数をセットする
    public int Set(int value)
    {
        diamondCount = value;
        return diamondCount;
    }
    
    // ダイヤモンドの数を変える
    public int Change(DiamondGateScript.DiamondOperators op, int value)
    {
        switch (op)
        {
            // opがAddだった場合
            case DiamondGateScript.DiamondOperators.Add:
                Add(value);
                break;
            // opがSubtractだった場合
            case DiamondGateScript.DiamondOperators.Subtract:
                Subtract(value);
                break;
            // opがMultiplyだった場合
            case DiamondGateScript.DiamondOperators.Multiply:
                Multiply(value);
                break;
            // opがDivideだった場合
            case DiamondGateScript.DiamondOperators.Divide:
                Divide(value);
                break;
        }
        return diamondCount;
    }

    // ダイヤモンドの個数を増やす(足し算する)
    int Add(int value)
    {
        diamondCount += value;
        return diamondCount;
    }

    // ダイヤモンドの個数を減らす(引き算する)
    int Subtract(int value)
    {
        diamondCount -= value;
        return diamondCount;
    }

    // ダイヤモンドの個数を掛ける(掛け算する)
    int Multiply(int value)
    {
        diamondCount *= value;
        return diamondCount;
    }

    // ダイヤモンドの個数を割る(割り算する)
    int Divide(int value)
    {
        diamondCount /= value;
        return diamondCount;
    }

    public void DiamondAndKeyMultiplication(int value)
    {
        diamondCount *= value;
    }
}
