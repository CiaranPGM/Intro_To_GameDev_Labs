using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Transform[] transArray;
    public Renderer rend;
    public GameObject redObj, blueObj;

    // Start is called before the first frame update
    void Start()
    {
        redObj = GameObject.FindWithTag("Red");
        blueObj = GameObject.FindWithTag("Blue");

        transArray = new Transform[2];
        transArray[0] = redObj.transform;
        transArray[1] = blueObj.transform;
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
            //Red Prefab
            if (redObj.GetComponent<PrintAndHide>() != null)
            {
                rend = redObj.GetComponent<PrintAndHide>().rend;
                rend.material.color = new Color(Random.Range(0.2f, 1.0f), 0, 0);
                Debug.Log("Red: <" + rend.material.color.ToString() + ">");
            }

            //Blue Prefab
            if (blueObj.GetComponent<PrintAndHide>() != null)
            {
                rend = blueObj.GetComponent<PrintAndHide>().rend;
                rend.material.color = new Color(0, 0, Random.Range(0.2f, 1.0f));
                Debug.Log("Blue: <" + rend.material.color.ToString() + ">");
            }

        }
        if (Input.GetKeyDown("e"))
        {
            if(redObj.GetComponent<PrintAndHide>() != null || blueObj.GetComponent<PrintAndHide>() != null)
            {
                GameObject.Destroy(redObj.GetComponent<PrintAndHide>());
                GameObject.Destroy(blueObj.GetComponent<PrintAndHide>());
            }
            if(redObj.GetComponent<PrintAndHide>() == null || blueObj.GetComponent<PrintAndHide>() == null)
            {
                if (redObj.active)
                {
                    redObj.AddComponent<PrintAndHide>();
                }
                if (blueObj.GetComponentInChildren<Renderer>().enabled)
                {
                    blueObj.AddComponent<PrintAndHide>();
                }
            }
        }
    }
}
