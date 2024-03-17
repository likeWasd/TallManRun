using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Diamond�X�N���v�g���`
    public DiamondManager diamond;
    // Key�X�N���v�g���`
    public KeyManager key;
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
        // DiamondGate�^�O��gameObject�ɐڐG������
        if (other.gameObject.CompareTag("DiamondGate"))
        {
            DiamondGateScript diamondGateScript = other.gameObject.GetComponent<DiamondGateScript>();
            // �_�C�������h���ǂꂭ�炢�ς��邩���擾����
            int diamondValue = diamondGateScript.valueChangingDiamond;
            DiamondGateScript.DiamondOperators diamondOp = diamondGateScript.diamondOperatorType;
            // �_�C�������h�̐���������
            diamond.Change(diamondOp, diamondValue);
        }
        // KeyGate�^�O��gameObject�ɐڐG������
        if (other.gameObject.CompareTag("KeyGate"))
        {
            KeyGateScript keyGateScript = other.gameObject.GetComponent<KeyGateScript>();
            // �����ǂꂭ�炢�ς��邩���擾����
            int keyValue = keyGateScript.valueChangingKey;
            KeyGateScript.KeyOperators keyOp = keyGateScript.keyOperatorType;
            // ���̐���������
            key.Change(keyOp, keyValue);
        }
    }
}
