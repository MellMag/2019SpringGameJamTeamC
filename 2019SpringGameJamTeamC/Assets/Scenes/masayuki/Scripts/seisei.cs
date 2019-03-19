using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seisei : MonoBehaviour
{
    float x;
    float y;
    float z;
    float time;
    public float type;
    public GameObject Image;
    public GameObject Image1;
    public GameObject Image2;
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
            //z = Random.Range(0.0f, 360.0f);
            z = 180f;
            type = Random.Range(0.0f, 3.0f);
            type = Mathf.Floor(type);
            switch (type)
            {
                case 0:
                    Instantiate(Image, new Vector3(x, y, z), transform.rotation);
                    break;

                case 1:
                    Instantiate(Image1, new Vector3(x, y, z), transform.rotation);
                    break;
                case 2:
                    Instantiate(Image2, new Vector3(x, y, z), transform.rotation);
                    break;
            }
                    time = 0f;
        }
    }
}
