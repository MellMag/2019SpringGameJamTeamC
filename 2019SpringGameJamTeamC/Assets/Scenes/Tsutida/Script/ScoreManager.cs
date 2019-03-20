using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    GameObject semanager;
    private AudioSource sound01;
    Text m_Text;
    Text m_Text2;
    RectTransform m_RectTransform;
    public static int point= 0;
    public static int clikcnt = 0;
    //public static int endpoint = 0;

    // 初期化
    void Start()
    {
        
        semanager = GameObject.Find("SEManager"); //HPManagerをシーンから探す
        sound01 = GetComponent<AudioSource>();
        //endpoint = 0;
        m_Text = GetComponent<Text>();
        //m_Text2 = GetComponent<Text>();
        m_RectTransform = GetComponent<RectTransform>();
    }

    // 更新
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Space))
        {
            changeFontSize();
        }
        // オブジェクトからTextコンポーネントを取得
        Text score_text = m_Text.GetComponent<Text>();
        //Text score_text2 = m_Text2.GetComponent<Text>();
        //スコアテキスト表示
        score_text.text = "Score:" + point;
        //score_text2.text = "ClickCount" + clikcnt;




    }
    void changeFontSize()
    {
        //Change the Font Size to 16
        m_Text.fontSize = 30;

        //Change the RectTransform size to allow larger fonts and sentences
        m_RectTransform.sizeDelta = new Vector2(m_Text.fontSize * 10, 100);

        //Change the m_Text text to the message below
        m_Text.text = "I changed my Font size!";
    
    }
    
}