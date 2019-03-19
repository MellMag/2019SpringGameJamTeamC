using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seisei : MonoBehaviour
{
    float x;
    float y;
    float z;
    float time;
    public GameObject Image;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 2)
        {
            x = Random.Range(-9.0f, -2.0f);
            y = Random.Range(5.0f, 5.0f);
            z = Random.Range(0.0f, 0.0f);

            Instantiate(Image, new Vector3(x,y,z), transform.rotation);
            time = 0f;
        }
    }
}
