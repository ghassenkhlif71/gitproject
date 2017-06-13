using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    Touch mytTouch;
    Vector2 a;
    // Update is called once per frame


    void Update()
    {

        Debug.Log(Screen.width);
        if (Input.touchCount > 0)
        {
            mytTouch = Input.GetTouch(0);
            a = mytTouch.position;



            if (a.x > Screen.width / 2)
            {
                transform.position += new Vector3(0.2f, 0, 0);
            }
            if (a.x < Screen.width / 2)

            {
                transform.position += new Vector3(-0.2f, 0, 0);
            }
        }
    }
}
