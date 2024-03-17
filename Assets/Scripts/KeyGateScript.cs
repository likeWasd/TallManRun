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
                tmpGateKeyCount.text = $"~{valueChangingKey}";
                break;
            case KeyOperators.Divide:
                tmpGateKeyCount.text = $"€{valueChangingKey}";
                break;
        }        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
