using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    GameObject clickedGameObject;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {

            clickedGameObject = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hit2d)
            {
                clickedGameObject = hit2d.transform.gameObject;
            }

            //Debug.Log(clickedGameObject);
            //Destroy(clickedGameObject);
            if (clickedGameObject != null)
            {
                if (clickedGameObject.GetComponent<Object>() != null)
                {
                    clickedGameObject.GetComponent<Object>().ClickeOnHit();

                }
            }
        }
    }
}