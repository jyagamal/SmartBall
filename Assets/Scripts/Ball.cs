using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //�{�[���̑���
    [SerializeField, Range(1, 30)]
    private float m_speed;

    //���W�b�g�{�f�B
    private Rigidbody m_rb;

    void Start()
    {
        //���W�b�g�{�f�B���R���|�[�l���g����擾����
        m_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //�X�y�[�X�L�[�������ꂽ��
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //�{�[���ɗ͂�������
            m_rb.AddForce(new Vector3(0.0f, m_speed, 0.0f), ForceMode.Impulse);
        }
    }
}
