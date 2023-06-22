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

    //���s�����ǂ���
    private bool m_isPlay;

    void Start()
    {
        //���W�b�g�{�f�B���R���|�[�l���g����擾����
        m_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    //void Update()
    //{
    //    //�X�y�[�X�L�[�������ꂽ���A����
    //    //�܂����s���ł͂Ȃ��A����
    //    //���ˉ\�񐔂�1�ȏ�Ȃ�
    //    if (Input.GetKeyDown(KeyCode.Space) &&
    //        !m_isPlay &&
    //        GameManager.Instance.GetShotCount() >= 1)
    //    {
    //        //�{�[���𔭎˂���
    //        Shot();
    //    }
    //}

    /*---------------------------------------------------------------------------------
    *	
    *	���e�@ : �{�[���𔭎˂���
    *	�����@ : �Ȃ�
    *	�߂�l : �Ȃ�
    *	 
    -----------------------------------------------------------------------------------*/
    public void Shot()
    {
        //���s����
        //���ˉ\�񐔂�0�ȉ��Ȃ�
        if (m_isPlay ||
            GameManager.Instance.GetShotCount() <= 0)
        {
            //����ȏ㏈�����Ȃ�
            return;
        }

        //�{�[���ɗ͂�������
        m_rb.AddForce(new Vector3(0.0f, m_speed, 0.0f), ForceMode.Impulse);

        //���ˉ\�񐔂����炷
        GameManager.Instance.ReduceShotCount();

        //���s���ɂ���
        m_isPlay = true;
    }

    /*---------------------------------------------------------------------------------
    *	
    *	���e�@ : ���s��Ԃ�ݒ肷��
    *	�����@ : ���s�����ǂ���
    *	�߂�l : �Ȃ�
    *	 
    -----------------------------------------------------------------------------------*/
    public void SetIsPlay(bool isPlay)
    {
        m_isPlay = isPlay;
    }

    /*---------------------------------------------------------------------------------
    *	
    *	���e�@ : ���s��Ԃ��擾����
    *	�����@ : �Ȃ�
    *	�߂�l : ���s�����ǂ���
    *	 
    -----------------------------------------------------------------------------------*/
    public bool GetIsPlay()
    {
        return m_isPlay;
    }
}
