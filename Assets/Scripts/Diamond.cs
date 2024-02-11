using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    /// <summary>
    /// �_�C�������h�̌�
    /// </summary>
    private int diamondCount;
    // Start is called before the first frame update
    void Start()
    {
        diamondCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(diamondCount);
    }

    // �_�C�������h�̌����Z�b�g����
    public int Set(int value)
    {
        diamondCount = value;
        return diamondCount;
    }
    
    // �_�C�������h�̐���ς���
    public int Change(GateScript.Operators op, int value)
    {
        // op��Add�������ꍇ
        if (op == GateScript.Operators.Add)
        {
            add(value);
        }
        // op��Subtract�������ꍇ
        if (op == GateScript.Operators.Subtract)
        {
            subtract(value);
        }
        // op��Multiply�������ꍇ
        if (op == GateScript.Operators.Multiply)
        {
            multiply(value);
        }
        // op��Divide�������ꍇ
        if (op == GateScript.Operators.Divide)
        {
            divide(value);
        }
        return diamondCount;
    }

    // �_�C�������h�̌��𑝂₷(�����Z����)
    private int add(int value)
    {
        diamondCount += value;
        return diamondCount;
    }

    // �_�C�������h�̌������炷(�����Z����)
    private int subtract(int value)
    {
        diamondCount -= value;
        return diamondCount;
    }

    // �_�C�������h�̌����|����(�|���Z����)
    private int multiply(int value)
    {
        diamondCount *= value;
        return diamondCount;
    }

    // �_�C�������h�̌�������(����Z����)
    private int divide(int value)
    {
        diamondCount /= value;
        return diamondCount;
    }
}
