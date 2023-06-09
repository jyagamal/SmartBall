using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreObject : MonoBehaviour
{
    //手に入るスコア
    [SerializeField]
    private int m_score = 0;

    //物と当たった瞬間に呼び出される関数
    private void OnCollisionEnter(Collision collision)
    {
        //当たったオブジェクトの名前がBallだったら
        if (collision.transform.name == "Ball")
        {
            //このオブジェクトが持っているスコアを加算する
            GameManager.Instance.AddScore(m_score);

            //ボールを再配置する
            //GameManager.Instance.ReconfigurationBall();
        }
    }

}
