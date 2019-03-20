using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    GameObject semanager;
    private AudioSource sound01;
    public int HP;
    float angle;
    float time;
    int cnt;


    // Start is called before the first frame update
    void Start()
    {
        semanager = GameObject.Find("SEManager"); //HPManagerをシーンから探す
        sound01 = GetComponent<AudioSource>();
        angle = Random.Range(0.0f, 180f);
        //endpos = 0;
        cnt = 0;
        //HP = 5;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time < 0.1)
        {
            transform.Rotate(new Vector3(0, 0, angle));
        }
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;
        //pos.x = endpos;
    }

    public void ClickeOnHit()
    {
        ScoreManager.clikcnt++;
        HP--;
        cnt++;
        if (HP == 0)
        {
            semanager.GetComponent<SEManager>().SendMessage("SE");
            sound01.PlayOneShot(sound01.clip);
            ScoreManager.point += 10 * cnt;
            //ScoreManager.point = ScoreManager.endpoint;
            Destroy(gameObject);  
        }
    }

}