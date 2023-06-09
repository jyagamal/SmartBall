using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreObject : MonoBehaviour
{
    //��ɓ���X�R�A
    [SerializeField]
    private int m_score = 0;

    //���Ɠ��������u�ԂɌĂяo�����֐�
    private void OnCollisionEnter(Collision collision)
    {
        //���������I�u�W�F�N�g�̖��O��Ball��������
        if (collision.transform.name == "Ball")
        {
            //���̃I�u�W�F�N�g�������Ă���X�R�A�����Z����
            GameManager.Instance.AddScore(m_score);

            //�{�[�����Ĕz�u����
            //GameManager.Instance.ReconfigurationBall();
        }
    }

}
