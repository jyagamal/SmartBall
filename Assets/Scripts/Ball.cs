using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //ボールの速さ
    [SerializeField, Range(1, 30)]
    private float m_speed;

    //リジットボディ
    private Rigidbody m_rb;

    //実行中かどうか
    private bool m_isPlay;

    void Start()
    {
        //リジットボディをコンポーネントから取得する
        m_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    //void Update()
    //{
    //    //スペースキーが押された時、且つ
    //    //まだ実行中ではなく、且つ
    //    //発射可能回数が1以上なら
    //    if (Input.GetKeyDown(KeyCode.Space) &&
    //        !m_isPlay &&
    //        GameManager.Instance.GetShotCount() >= 1)
    //    {
    //        //ボールを発射する
    //        Shot();
    //    }
    //}

    /*---------------------------------------------------------------------------------
    *	
    *	内容　 : ボールを発射する
    *	引数　 : なし
    *	戻り値 : なし
    *	 
    -----------------------------------------------------------------------------------*/
    public void Shot()
    {
        //実行中か
        //発射可能回数が0以下なら
        if (m_isPlay ||
            GameManager.Instance.GetShotCount() <= 0)
        {
            //これ以上処理しない
            return;
        }

        //ボールに力を加える
        m_rb.AddForce(new Vector3(0.0f, m_speed, 0.0f), ForceMode.Impulse);

        //発射可能回数を減らす
        GameManager.Instance.ReduceShotCount();

        //実行中にする
        m_isPlay = true;
    }

    /*---------------------------------------------------------------------------------
    *	
    *	内容　 : 実行状態を設定する
    *	引数　 : 実行中かどうか
    *	戻り値 : なし
    *	 
    -----------------------------------------------------------------------------------*/
    public void SetIsPlay(bool isPlay)
    {
        m_isPlay = isPlay;
    }

    /*---------------------------------------------------------------------------------
    *	
    *	内容　 : 実行状態を取得する
    *	引数　 : なし
    *	戻り値 : 実行中かどうか
    *	 
    -----------------------------------------------------------------------------------*/
    public bool GetIsPlay()
    {
        return m_isPlay;
    }
}
