using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public int HP;
    int endpos;
    float angle;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        angle = Random.Range(0.0f, 180f);
        endpos = 0;
        //HP = 5;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time < 1)
        {
            transform.Rotate(new Vector3(0, 0, angle));
        }
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;
        pos.x = endpos;
    }


    public void ClickeOnHit()
    {
        HP--;
        if (HP == 0)
        {
            Destroy(gameObject);
        }
    }

}