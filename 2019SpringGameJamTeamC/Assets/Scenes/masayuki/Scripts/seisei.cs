using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seisei : MonoBehaviour
{
    float x;
    float y;
    float z;
    float time;
    float ratetime;
    float overtime;
    public double rate;

    public float timeOut;//何秒間隔か？
    private float timeElapsed;
    public float type;
    public GameObject Image;
    public GameObject Image1;
    public GameObject Image2;
    public GameObject Image3;
    public GameObject Image4;
    public GameObject Image5;
    public GameObject Image6;
    public GameObject Image7;
    public GameObject Image8;
    public GameObject Image9;
    public GameObject Image10;
    public GameObject Image11;
    public GameObject Image12;
    public GameObject Image13;
    public GameObject Image14;
    public GameObject Image15;
    public GameObject Image16;
    public GameObject Image17;
    public GameObject Image18;
    public GameObject Image19;

    //public GameO


    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        rate = 2;
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        time += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
            rate *= 0.9;
            timeElapsed = 0.0f;
        }
            if (time >= rate)
            {
                x = Random.Range(-8.0f, -2.0f);
                y = Random.Range(15.0f, 15.0f);
                z = Random.Range(0.0f, 18.0f);

                type = Random.Range(0.0f, 20.0f);
                type = Mathf.Floor(type);
                switch (type)
                {
                    case 0:
                        Instantiate(Image, new Vector3(x, y, z), transform.rotation);
                        transform.Rotate(new Vector3(0, 0, z));
                        break;

                    case 1:
                        Instantiate(Image1, new Vector3(x, y, z), transform.rotation);
                        break;
                    case 2:
                        Instantiate(Image2, new Vector3(x, y, z), transform.rotation);
                        break;
                    case 3:
                        Instantiate(Image3, new Vector3(x, y, z), transform.rotation);
                        break;
                    case 4:
                        Instantiate(Image4, new Vector3(x, y, z), transform.rotation);
                        break;
                    case 5:
                        Instantiate(Image5, new Vector3(x, y, z), transform.rotation);
                        break;
                    case 6:
                        Instantiate(Image6, new Vector3(x, y, z), transform.rotation);
                        break;
                    case 7:
                        Instantiate(Image7, new Vector3(x, y, z), transform.rotation);
                        break;
                    case 8:
                        Instantiate(Image8, new Vector3(x, y, z), transform.rotation);
                        break;
                    case 9:
                        Instantiate(Image9, new Vector3(x, y, z), transform.rotation);
                        break;
                    case 10:
                        Instantiate(Image10, new Vector3(x, y, z), transform.rotation);
                        break;
                    case 11:
                        Instantiate(Image11, new Vector3(x, y, z), transform.rotation);
                        break;
                    case 12:
                        Instantiate(Image12, new Vector3(x, y, z), transform.rotation);
                        break;
                    case 13:
                        Instantiate(Image13, new Vector3(x, y, z), transform.rotation);
                        break;
                    case 14:
                        Instantiate(Image14, new Vector3(x, y, z), transform.rotation);
                        break;
                    case 15:
                        Instantiate(Image15, new Vector3(x, y, z), transform.rotation);
                        break;
                    case 16:
                        Instantiate(Image16, new Vector3(x, y, z), transform.rotation);
                        break;
                    case 17:
                        Instantiate(Image17, new Vector3(x, y, z), transform.rotation);
                        break;
                    case 18:
                        Instantiate(Image18, new Vector3(x, y, z), transform.rotation);
                        break;
                    case 19:
                        Instantiate(Image19, new Vector3(x, y, z), transform.rotation);
                        break;
                }

                time = 0f;

        }
    }
}
