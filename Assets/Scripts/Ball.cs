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

    void Start()
    {
        //リジットボディをコンポーネントから取得する
        m_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //スペースキーが押された時
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //ボールに力を加える
            m_rb.AddForce(new Vector3(0.0f, m_speed, 0.0f), ForceMode.Impulse);
        }
    }
}
