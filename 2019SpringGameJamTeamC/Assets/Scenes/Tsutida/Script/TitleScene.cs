﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class TitleScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("ChangeScene", 3.0f);
    }
    void ChangeScene()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("poiful");
            ScoreManager.point = 0;
        }
    }
}
