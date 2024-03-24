using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Diamondスクリプトを定義
    public DiamondManager diamond;
    // Keyスクリプトを定義
    public KeyManager key;
    // プレイヤーのスピード
    public float playerSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * playerSpeed;
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * playerSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * playerSpeed;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // DiamondGateタグのgameObjectに接触したら
        if (other.gameObject.CompareTag("DiamondGate"))
        {
            DiamondGateScript diamondGateScript = other.gameObject.GetComponent<DiamondGateScript>();
            // ダイヤモンドをどれくらい変えるかを取得する
            int diamondValue = diamondGateScript.valueChangingDiamond;
            DiamondGateScript.DiamondOperators diamondOp = diamondGateScript.diamondOperatorType;
            // ダイヤモンドの数を加える
            diamond.Change(diamondOp, diamondValue);
        }
        // KeyGateタグのgameObjectに接触したら
        if (other.gameObject.CompareTag("KeyGate"))
        {
            KeyGateScript keyGateScript = other.gameObject.GetComponent<KeyGateScript>();
            // 鍵をどれくらい変えるかを取得する
            int keyValue = keyGateScript.valueChangingKey;
            KeyGateScript.KeyOperators keyOp = keyGateScript.keyOperatorType;
            // 鍵の数を加える
            key.Change(keyOp, keyValue);
        }
        // GoalタグのgameObjectに接触したら
        if (other.gameObject.CompareTag("Goal"))
        {
            diamond.DiamondAndKeyMultiplication(key.keyCount);
        }
    }
}
