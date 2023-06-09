using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*---------------------------------------------------------------------------------
*	
*	ゲームデータを管理する
*	 
-----------------------------------------------------------------------------------*/
public class GameManager : SingletonMonoBehaviour<GameManager>
{
    //スコア
    private int m_score = 0;

    //ボールオブジェクト
    [SerializeField]
    private GameObject m_ballObject;

    //ボールを再配置する場所
    private Vector3 m_restartPoint;

    void Start()
    {
        //再配置する場所をボールの初期位置にする
        m_restartPoint = m_ballObject.transform.position;
    }

    /*---------------------------------------------------------------------------------
    *	
    *	内容　 : スコアを加算する
    *	引数　 : 加算するスコア
    *	戻り値 : なし
    *	 
    -----------------------------------------------------------------------------------*/
    public void AddScore(int score)
    {
        m_score += score;

        //デバッグ用にコンソールにスコアを表示する
        Debug.Log("Score : " + m_score);
    }

    /*---------------------------------------------------------------------------------
    *	
    *	内容　 : 現在のスコアを取得する
    *	引数　 : なし
    *	戻り値 : 現在のスコア
    *	 
    -----------------------------------------------------------------------------------*/
    public int GetScore()
    {
        return m_score;
    }

    /*---------------------------------------------------------------------------------
    *	
    *	内容　 : ボールを初期化し、再配置する
    *	引数　 : なし
    *	戻り値 : なし
    *	 
    -----------------------------------------------------------------------------------*/
    public void ReconfigurationBall()
    {
        //リジットボディの速度をリセットする
        m_ballObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

        //ボールを再配置する
        m_ballObject.transform.position = m_restartPoint;
    }
}

