using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    Text m_Text;
    RectTransform m_RectTransform;
    public static int point = 100;

    // 初期化
    void Start()
    {
        m_Text = GetComponent<Text>();
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
        //スコアテキスト表示
        score_text.text = "Score:" + point;

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