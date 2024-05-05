using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyManager : MonoBehaviour
{
    /// <summary>
    /// 鍵の個数
    /// </summary>
    public int keyCount;
    [SerializeField] int keyDefaultValue;
    [SerializeField] TextMeshProUGUI tmpkeyCount;
    // Start is called before the first frame update
    void Start()
    {
        keyCount = keyDefaultValue;
    }

    // Update is called once per frame
    void Update()
    {
        keyCount = Mathf.Clamp(keyCount, 0, keyCount);
        tmpkeyCount.text = "Key " + keyCount.ToString();
    }

    // 鍵の個数をセットする
    public int Set(int value)
    {
        keyCount = value;
        return keyCount;
    }
    
    // 鍵の数を変える
    public int Change(KeyGateScript.KeyOperators op, int value)
    {
        switch (op)
        {
            // opがAddだった場合
            case KeyGateScript.KeyOperators.Add:
                Add(value);
                break;
            // opがSubtractだった場合
            case KeyGateScript.KeyOperators.Subtract:
                Subtract(value);
                break;
            // opがMultiplyだった場合
            case KeyGateScript.KeyOperators.Multiply:
                Multiply(value);
                break;
            // opがDivideだった場合
            case KeyGateScript.KeyOperators.Divide:
                Divide(value);
                break;
        }
        return keyCount;
    }

    // 鍵の個数を増やす(足し算する)
    int Add(int value)
    {
        keyCount += value;
        return keyCount;
    }

    // 鍵の個数を減らす(引き算する)
    int Subtract(int value)
    {
        keyCount -= value;
        return keyCount;
    }

    // 鍵の個数を掛ける(掛け算する)
    int Multiply(int value)
    {
        keyCount *= value;
        return keyCount;
    }

    // 鍵の個数を割る(割り算する)
    int Divide(int value)
    {
        keyCount /= value;
        return keyCount;
    }
}
