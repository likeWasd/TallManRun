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
    public enum DiamondOperators
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
    public DiamondOperators diamondOperatorType;
    [SerializeField] TextMeshProUGUI tmpGateDiamondCount;
    // Start is called before the first frame update
    void Start()
    {
        switch (diamondOperatorType)
        {
            case DiamondOperators.Add:
                tmpGateDiamondCount.text = $"+{valueChangingDiamond}";
                break;
            case DiamondOperators.Subtract:
                tmpGateDiamondCount.text = $"-{valueChangingDiamond}";
                break;
            case DiamondOperators.Multiply:
                tmpGateDiamondCount.text = $"×{valueChangingDiamond}";
                break;
            case DiamondOperators.Divide:
                tmpGateDiamondCount.text = $"÷{valueChangingDiamond}";
                break;
        }        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
