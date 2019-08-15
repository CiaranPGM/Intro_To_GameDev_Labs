using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i = 0;
    int randomNum;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        randomNum = Random.Range(200, 250);
    }

    // Update is called once per frame
    void Update()
    {
        if (tag == "Blue" && i == randomNum)
        {
            rend.enabled = !rend.enabled;
            Debug.Log("Blue died at" + i);
        }
        else if (tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
            Debug.Log("Red died at" + i);
        }

        Debug.Log(name + ": " + i);
        i++;
    }
}
