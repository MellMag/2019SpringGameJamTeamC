using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class attention : MonoBehaviour
{

    float countTime = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime; //スタートしてからの秒数を格納

        if (countTime > 5)
        {
            Destroy(gameObject);
        }
    }
}
