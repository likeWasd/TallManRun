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
    public enum KeyOperators
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
    public KeyOperators keyOperatorType;
    [SerializeField] TextMeshProUGUI tmpGateKeyCount;
    // Start is called before the first frame update
    void Start()
    {
        switch (keyOperatorType)
        {
            case KeyOperators.Add:
                tmpGateKeyCount.text = $"+{valueChangingKey}";
                break;
            case KeyOperators.Subtract:
                tmpGateKeyCount.text = $"-{valueChangingKey}";
                break;
            case KeyOperators.Multiply:
                tmpGateKeyCount.text = $"�~{valueChangingKey}";
                break;
            case KeyOperators.Divide:
                tmpGateKeyCount.text = $"��{valueChangingKey}";
                break;
        }        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
