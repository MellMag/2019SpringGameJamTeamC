using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    /*
   // GameObject clickedGameObject;

    //何回クリックしたら消えるか
    private int HP;
   // public GameObject prefab;

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
       HP = 5;
    }

    void Update()
    {
        //GameObject prefab = getClickObject();
        //クリック取得
        if (getClickObject() != null)
        {
            HP--;
        }
        if(HP == 0)
        {
            //オブジェクト削除
            Destroy(all.gameObject);
        }
    }
}*/
    GameObject clickedGameObject;
    private int HP;
    void Start()
    {
        HP = 10;
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            clickedGameObject = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hit2d)
            {
                clickedGameObject = hit2d.transform.gameObject;
            }
            HP--;
            if (HP == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
