using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiamondGateScript : MonoBehaviour
{
    /// <summary>
    /// ダイヤモンドの個数を変える値
    /// </summary>
    public int valueChangingDiamond;
    /// <summary>
    /// ダイヤモンドの個数をどうやって変化させるか
    /// </summary>
    public enum Operators
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
    public Operators diamondOperatorType;
    [SerializeField] TextMeshProUGUI tmpGateDiamondCount;
    // Start is called before the first frame update
    void Start()
    {
        switch (diamondOperatorType)
        {
            case Operators.Add:
                tmpGateDiamondCount.text = $"+{valueChangingDiamond}";
                break;
            case Operators.Subtract:
                tmpGateDiamondCount.text = $"-{valueChangingDiamond}";
                break;
            case Operators.Multiply:
                tmpGateDiamondCount.text = $"×{valueChangingDiamond}";
                break;
            case Operators.Divide:
                tmpGateDiamondCount.text = $"÷{valueChangingDiamond}";
                break;
        }        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
