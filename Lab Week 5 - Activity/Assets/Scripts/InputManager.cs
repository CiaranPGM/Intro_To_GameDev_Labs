using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Transform[] transArray;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        transArray = new Transform[2];
        transArray[0] = GameObject.FindWithTag("Red").transform;
        transArray[1] = GameObject.FindWithTag("Blue").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            transArray[0].Rotate(0,0,45);
            transArray[1].Rotate(0, 0, -45);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            float temp = transArray[0].position.y;
            float temp1 = transArray[1].position.y;
            transArray[1].position = new Vector3(transArray[1].position.x, temp, transArray[1].position.z);
            transArray[0].position = new Vector3(transArray[0].position.x, temp1, transArray[0].position.z);

        }
        if (Input.GetButtonUp("Fire1"))
        {
            //GameObject go = GameObject.FindWithTag("Red");
            //PrintAndHide script = go.GetComponent<PrintAndHide>();
            rend = GameObject.FindWithTag("Red").GetComponent<PrintAndHide>().rend;
            //rend.GetComponent<Color>().Equals(new Color(Random.Range(51, 255), 0, 0));
            //Debug.Log(rend.GetComponent<Color>.ToString());
        }
    }
}
