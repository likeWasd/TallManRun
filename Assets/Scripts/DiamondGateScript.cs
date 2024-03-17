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
                tmpGateDiamondCount.text = $"�~{valueChangingDiamond}";
                break;
            case DiamondOperators.Divide:
                tmpGateDiamondCount.text = $"��{valueChangingDiamond}";
                break;
        }        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
