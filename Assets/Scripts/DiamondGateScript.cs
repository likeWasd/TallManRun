using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiamondGateScript : MonoBehaviour
{
    /// <summary>
    /// �_�C�������h�̌���ς���l
    /// </summary>
    public int valueChangingDiamond;
    /// <summary>
    /// �_�C�������h�̌����ǂ�����ĕω������邩
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
                tmpGateDiamondCount.text = $"�~{valueChangingDiamond}";
                break;
            case Operators.Divide:
                tmpGateDiamondCount.text = $"��{valueChangingDiamond}";
                break;
        }        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
