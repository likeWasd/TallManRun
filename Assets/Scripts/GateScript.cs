using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{
    /// <summary>
    /// ダイヤモンドの個数を変える値
    /// </summary>
    public int ValueChangingDiamond;
    /// <summary>
    /// ダイヤモンドの個数をどうやって変化させるか
    /// </summary>
    public enum Operators
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
    public Operators DiamondOperatorType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
