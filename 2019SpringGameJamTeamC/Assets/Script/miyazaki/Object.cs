using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public int HP;
    // Start is called before the first frame update
    void Start()
    {
        //HP = 5;
    }

    // Update is called once per frame
    void Update()
    {

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