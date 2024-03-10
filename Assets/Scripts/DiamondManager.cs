using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiamondManager : MonoBehaviour
{
    /// <summary>
    /// �_�C�������h�̌�
    /// </summary>
    private int diamondCount;
    [SerializeField] TextMeshProUGUI tmpDiamondCount;
    // Start is called before the first frame update
    void Start()
    {
        diamondCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(diamondCount);
        tmpDiamondCount.text = "Diamond " + diamondCount.ToString();
    }

    // �_�C�������h�̌����Z�b�g����
    public int Set(int value)
    {
        diamondCount = value;
        return diamondCount;
    }
    
    // �_�C�������h�̐���ς���
    public int Change(DiamondGateScript.Operators op, int value)
    {
        switch (op)
        {
            // op��Add�������ꍇ
            case DiamondGateScript.Operators.Add:
                Add(value);
                break;
            // op��Subtract�������ꍇ
            case DiamondGateScript.Operators.Subtract:
                Subtract(value);
                break;
            // op��Multiply�������ꍇ
            case DiamondGateScript.Operators.Multiply:
                Multiply(value);
                break;
            // op��Divide�������ꍇ
            case DiamondGateScript.Operators.Divide:
                Divide(value);
                break;
        }
        return diamondCount;
    }

    // �_�C�������h�̌��𑝂₷(�����Z����)
    private int Add(int value)
    {
        diamondCount += value;
        return diamondCount;
    }

    // �_�C�������h�̌������炷(�����Z����)
    private int Subtract(int value)
    {
        diamondCount -= value;
        return diamondCount;
    }

    // �_�C�������h�̌����|����(�|���Z����)
    private int Multiply(int value)
    {
        diamondCount *= value;
        return diamondCount;
    }

    // �_�C�������h�̌�������(����Z����)
    private int Divide(int value)
    {
        diamondCount /= value;
        return diamondCount;
    }
}
