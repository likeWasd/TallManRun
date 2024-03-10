using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyGateScript : MonoBehaviour
{
    /// <summary>
    /// ���̌���ς���l
    /// </summary>
    public int valueChangingKey;
    /// <summary>
    /// ���̌����ǂ�����ĕω������邩
    /// </summary>
    public enum Operators
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
    public Operators KeyOperatorType;
    [SerializeField] TextMeshProUGUI tmpGateKeyCount;
    // Start is called before the first frame update
    void Start()
    {
        switch (KeyOperatorType)
        {
            case Operators.Add:
                tmpGateKeyCount.text = $"+{valueChangingKey}";
                break;
            case Operators.Subtract:
                tmpGateKeyCount.text = $"-{valueChangingKey}";
                break;
            case Operators.Multiply:
                tmpGateKeyCount.text = $"�~{valueChangingKey}";
                break;
            case Operators.Divide:
                tmpGateKeyCount.text = $"��{valueChangingKey}";
                break;
        }        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
