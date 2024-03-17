using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyManager : MonoBehaviour
{
    /// <summary>
    /// Œ®‚ÌŒÂ”
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

    // Œ®‚ÌŒÂ”‚ğƒZƒbƒg‚·‚é
    public int Set(int value)
    {
        keyCount = value;
        return keyCount;
    }
    
    // Œ®‚Ì”‚ğ•Ï‚¦‚é
    public int Change(KeyGateScript.KeyOperators op, int value)
    {
        switch (op)
        {
            // op‚ªAdd‚¾‚Á‚½ê‡
            case KeyGateScript.KeyOperators.Add:
                Add(value);
                break;
            // op‚ªSubtract‚¾‚Á‚½ê‡
            case KeyGateScript.KeyOperators.Subtract:
                Subtract(value);
                break;
            // op‚ªMultiply‚¾‚Á‚½ê‡
            case KeyGateScript.KeyOperators.Multiply:
                Multiply(value);
                break;
            // op‚ªDivide‚¾‚Á‚½ê‡
            case KeyGateScript.KeyOperators.Divide:
                Divide(value);
                break;
        }
        return keyCount;
    }

    // Œ®‚ÌŒÂ”‚ğ‘‚â‚·(‘«‚µZ‚·‚é)
    private int Add(int value)
    {
        keyCount += value;
        return keyCount;
    }

    // Œ®‚ÌŒÂ”‚ğŒ¸‚ç‚·(ˆø‚«Z‚·‚é)
    private int Subtract(int value)
    {
        keyCount -= value;
        return keyCount;
    }

    // Œ®‚ÌŒÂ”‚ğŠ|‚¯‚é(Š|‚¯Z‚·‚é)
    private int Multiply(int value)
    {
        keyCount *= value;
        return keyCount;
    }

    // Œ®‚ÌŒÂ”‚ğŠ„‚é(Š„‚èZ‚·‚é)
    private int Divide(int value)
    {
        keyCount /= value;
        return keyCount;
    }
}
