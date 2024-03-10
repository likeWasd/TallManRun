using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyManager : MonoBehaviour
{
    /// <summary>
    /// 鍵の個数
    /// </summary>
    private int keyCount;
    [SerializeField] TextMeshProUGUI tmpkeyCount;
    // Start is called before the first frame update
    void Start()
    {
        keyCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(keyCount);
        tmpkeyCount.text = "Key " + keyCount.ToString();
    }

    // 鍵の個数をセットする
    public int Set(int value)
    {
        keyCount = value;
        return keyCount;
    }
    
    // 鍵の数を変える
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
        return keyCount;
    }

    // 鍵の個数を増やす(足し算する)
    private int Add(int value)
    {
        keyCount += value;
        return keyCount;
    }

    // 鍵の個数を減らす(引き算する)
    private int Subtract(int value)
    {
        keyCount -= value;
        return keyCount;
    }

    // 鍵の個数を掛ける(掛け算する)
    private int Multiply(int value)
    {
        keyCount *= value;
        return keyCount;
    }

    // 鍵の個数を割る(割り算する)
    private int Divide(int value)
    {
        keyCount /= value;
        return keyCount;
    }
}
