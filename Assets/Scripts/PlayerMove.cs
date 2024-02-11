using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Diamond�X�N���v�g���`
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
        // Gate�^�O��gameObject�ɐڐG������
        if (other.gameObject.CompareTag("Gate"))
        {
            // �_�C�������h���ǂꂭ�炢�ς��邩���擾����
            int value = other.gameObject.GetComponent<GateScript>().ValueChangingDiamond;
            GateScript.Operators op = other.gameObject.GetComponent<GateScript>().DiamondOperatorType;
            // �_�C�������h�̐���������
            diamond.Change(op, value);
        }
    }
}
