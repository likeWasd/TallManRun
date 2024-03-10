using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Diamondスクリプトを定義
    public KeyManager diamond;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * 0.1f;
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * 0.1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * 0.1f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // GateタグのgameObjectに接触したら
        if (other.gameObject.CompareTag("Gate"))
        {
            DiamondGateScript gateScript = other.gameObject.GetComponent<DiamondGateScript>();
            // ダイヤモンドをどれくらい変えるかを取得する
            int value = gateScript.valueChangingDiamond;
            DiamondGateScript.Operators op = gateScript.diamondOperatorType;
            // ダイヤモンドの数を加える
            diamond.Change(op, value);
        }
    }
}
