using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    int lastTime;
    // Start is called before the first frame update
    void Start()
    {
        lastTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            Debug.Log("SPACEBAR IS PRESSED");
        }

        if (Time.time > lastTime)
            Debug.Log(lastTime++);
    }
}
