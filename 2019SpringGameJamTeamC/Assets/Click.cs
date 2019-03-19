using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    GameObject clickedGameObject;

    //何回クリックしたら消えるか
    public int HP;

    // クリックを判定する関数 
    private GameObject getClickObject()
    {
        GameObject result = null;
        // 左クリックされた場所のオブジェクトを取得
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 tapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D collition2d = Physics2D.OverlapPoint(tapPoint);
            if (collition2d)
            {
                result = collition2d.transform.gameObject;
            }
        }
        return result;
    }
    void Start()
    {
        
    }

    void Update()
    {
        GameObject obj = getClickObject();
        if (obj != null)
        {
            HP--;
        }
        if(HP == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
