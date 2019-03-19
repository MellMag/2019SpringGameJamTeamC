using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public int HP;
    int endpos;
    // Start is called before the first frame update
    void Start()
    {
        endpos = 0;
        //HP = 5;
    }

    // Update is called once per frame
    void Update()
    {
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