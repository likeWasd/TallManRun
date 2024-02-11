using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Diamondスクリプトを定義
    public Diamond diamond;
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
            // ダイヤモンドをどれくらい変えるかを取得する
            int value = other.gameObject.GetComponent<GateScript>().ValueChangingDiamond;
            GateScript.Operators op = other.gameObject.GetComponent<GateScript>().DiamondOperatorType;
            // ダイヤモンドの数を加える
            diamond.Change(op, value);
        }
    }
}
