using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public bool YesActive;
    public int cnt;
    // Start is called before the first frame update
    void Start()
    {
        YesActive = false;
        cnt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (YesActive == true)
        {
            cnt += 1;
        }
        if (cnt >= 300)
        {
            SceneManager.LoadScene("Result");
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            YesActive = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            YesActive = false;
            cnt = 0;
        }
    }

}
