using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/*---------------------------------------------------------------------------------
*	
*	�Q�[���f�[�^���Ǘ�����
*	 
-----------------------------------------------------------------------------------*/
public class GameManager : SingletonMonoBehaviour<GameManager>
{
    //���ˉ\��
    [SerializeField]
    private int m_shotCount;

    //�{�[���I�u�W�F�N�g
    [SerializeField]
    private GameObject m_ballObject;

    //�X�R�AUI
    [SerializeField]
    private TMPro.TextMeshProUGUI m_scoreUi;

    //�X�R�A
    private int m_score = 0;

    //�{�[�����Ĕz�u����ꏊ
    private Vector3 m_restartPoint;

    void Start()
    {
        //�Ĕz�u����ꏊ���{�[���̏����ʒu�ɂ���
        m_restartPoint = m_ballObject.transform.position;
    }

    /*---------------------------------------------------------------------------------
    *	
    *	���e�@ : �X�R�A�����Z����
    *	�����@ : ���Z����X�R�A
    *	�߂�l : �Ȃ�
    *	 
    -----------------------------------------------------------------------------------*/
    public void AddScore(int score)
    {
        m_score += score;

        //�f�o�b�O�p�ɃR���\�[���ɃX�R�A��\������
        Debug.Log("Score : " + m_score);

        //UI�̃X�R�A���X�V����
        m_scoreUi.text = "Score :" + m_score.ToString();
    }

    /*---------------------------------------------------------------------------------
    *	
    *	���e�@ : ���݂̃X�R�A���擾����
    *	�����@ : �Ȃ�
    *	�߂�l : ���݂̃X�R�A
    *	 
    -----------------------------------------------------------------------------------*/
    public int GetScore()
    {
        return m_score;
    }

    /*---------------------------------------------------------------------------------
    *	
    *	���e�@ : �{�[�������������A�Ĕz�u����
    *	�����@ : �Ȃ�
    *	�߂�l : �Ȃ�
    *	 
    -----------------------------------------------------------------------------------*/
    public void ReconfigurationBall()
    {
        //���W�b�g�{�f�B�̑��x�����Z�b�g����
        m_ballObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

        //�{�[�����Ĕz�u����
        m_ballObject.transform.position = m_restartPoint;
    }

    /*---------------------------------------------------------------------------------
    *	
    *	���e�@ : ���ˉ\�񐔂����炷
    *	�����@ : �Ȃ�
    *	�߂�l : �Ȃ�
    *	 
    -----------------------------------------------------------------------------------*/
    public void ReduceShotCount()
    {
        if (m_shotCount > 0)
        {
            m_shotCount--;
        }
    }

    /*---------------------------------------------------------------------------------
    *	
    *	���e�@ : ���ˉ\�񐔂��擾����
    *	�����@ : �Ȃ�
    *	�߂�l : �c��̔��ˉ\��
    *	 
    -----------------------------------------------------------------------------------*/
    public int GetShotCount()
    {
        return m_shotCount;
    }
}

