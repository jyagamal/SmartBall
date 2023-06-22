using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/*---------------------------------------------------------------------------------
*	
*	ゲームデータを管理する
*	 
-----------------------------------------------------------------------------------*/
public class GameManager : SingletonMonoBehaviour<GameManager>
{
    //発射可能回数
    [SerializeField]
    private int m_shotCount;

    //ボールオブジェクト
    [SerializeField]
    private GameObject m_ballObject;

    //スコアUI
    [SerializeField]
    private TMPro.TextMeshProUGUI m_scoreUi;

    //スコア
    private int m_score = 0;

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

        //UIのスコアも更新する
        m_scoreUi.text = "Score :" + m_score.ToString();
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

    /*---------------------------------------------------------------------------------
    *	
    *	内容　 : 発射可能回数を減らす
    *	引数　 : なし
    *	戻り値 : なし
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
    *	内容　 : 発射可能回数を取得する
    *	引数　 : なし
    *	戻り値 : 残りの発射可能回数
    *	 
    -----------------------------------------------------------------------------------*/
    public int GetShotCount()
    {
        return m_shotCount;
    }
}

