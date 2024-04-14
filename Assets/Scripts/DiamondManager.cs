using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiamondManager : MonoBehaviour
{
    /// <summary>
    /// �_�C�������h�̌�
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

    // �_�C�������h�̌����Z�b�g����
    public int Set(int value)
    {
        diamondCount = value;
        return diamondCount;
    }
    
    // �_�C�������h�̐���ς���
    public int Change(DiamondGateScript.DiamondOperators op, int value)
    {
        switch (op)
        {
            // op��Add�������ꍇ
            case DiamondGateScript.DiamondOperators.Add:
                Add(value);
                break;
            // op��Subtract�������ꍇ
            case DiamondGateScript.DiamondOperators.Subtract:
                Subtract(value);
                break;
            // op��Multiply�������ꍇ
            case DiamondGateScript.DiamondOperators.Multiply:
                Multiply(value);
                break;
            // op��Divide�������ꍇ
            case DiamondGateScript.DiamondOperators.Divide:
                Divide(value);
                break;
        }
        return diamondCount;
    }

    // �_�C�������h�̌��𑝂₷(�����Z����)
    int Add(int value)
    {
        diamondCount += value;
        return diamondCount;
    }

    // �_�C�������h�̌������炷(�����Z����)
    int Subtract(int value)
    {
        diamondCount -= value;
        return diamondCount;
    }

    // �_�C�������h�̌����|����(�|���Z����)
    int Multiply(int value)
    {
        diamondCount *= value;
        return diamondCount;
    }

    // �_�C�������h�̌�������(����Z����)
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
