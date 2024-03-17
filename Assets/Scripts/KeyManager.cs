using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyManager : MonoBehaviour
{
    /// <summary>
    /// ���̌�
    /// </summary>
    private int keyCount;
    [SerializeField] TextMeshProUGUI tmpkeyCount;
    // Start is called before the first frame update
    void Start()
    {
        keyCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        keyCount = Mathf.Clamp(keyCount, 0, keyCount);
        tmpkeyCount.text = "Key " + keyCount.ToString();
    }

    // ���̌����Z�b�g����
    public int Set(int value)
    {
        keyCount = value;
        return keyCount;
    }
    
    // ���̐���ς���
    public int Change(KeyGateScript.KeyOperators op, int value)
    {
        switch (op)
        {
            // op��Add�������ꍇ
            case KeyGateScript.KeyOperators.Add:
                Add(value);
                break;
            // op��Subtract�������ꍇ
            case KeyGateScript.KeyOperators.Subtract:
                Subtract(value);
                break;
            // op��Multiply�������ꍇ
            case KeyGateScript.KeyOperators.Multiply:
                Multiply(value);
                break;
            // op��Divide�������ꍇ
            case KeyGateScript.KeyOperators.Divide:
                Divide(value);
                break;
        }
        return keyCount;
    }

    // ���̌��𑝂₷(�����Z����)
    private int Add(int value)
    {
        keyCount += value;
        return keyCount;
    }

    // ���̌������炷(�����Z����)
    private int Subtract(int value)
    {
        keyCount -= value;
        return keyCount;
    }

    // ���̌����|����(�|���Z����)
    private int Multiply(int value)
    {
        keyCount *= value;
        return keyCount;
    }

    // ���̌�������(����Z����)
    private int Divide(int value)
    {
        keyCount /= value;
        return keyCount;
    }
}
