using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyGateScript : MonoBehaviour
{
    /// <summary>
    /// Œ®‚ÌŒÂ”‚ğ•Ï‚¦‚é’l
    /// </summary>
    public int valueChangingKey;
    /// <summary>
    /// Œ®‚ÌŒÂ”‚ğ‚Ç‚¤‚â‚Á‚Ä•Ï‰»‚³‚¹‚é‚©
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
                tmpGateKeyCount.text = $"~{valueChangingKey}";
                break;
            case Operators.Divide:
                tmpGateKeyCount.text = $"€{valueChangingKey}";
                break;
        }        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
