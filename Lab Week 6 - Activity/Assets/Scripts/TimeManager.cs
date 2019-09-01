using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private int lastTime;
    private float timer;
    private const float moveWait = 2.0f;

    [SerializeField]
    private Transform[] transArray;
    // Start is called before the first frame update
    void Start()
    {
        Camera.main.orthographic = true;
        Camera.main.orthographicSize = 2.0f;
        InvokeRepeating("MoveObjects", 2.0f, 2.0f);
        ResetTime();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = 0;
            }
            Debug.Log("SPACEBAR IS PRESSED");
        }else if (Input.GetKeyDown(KeyCode.Return))
        {
            ResetTime();
        }

        timer += Time.deltaTime;

        if((int)timer >= lastTime)
        {
            Debug.Log((int)timer);
            lastTime++;
        }
    }

    private void ResetTime()
    {
        timer = 0;
        lastTime = 0;
    }

    private void MoveObjects()
    { 
        if (transArray[0].position.x == 2 && transArray[0].position.y == 1)
        {
            transArray[0].SetPositionAndRotation(new Vector3(2, -1, 0), new Quaternion());
            transArray[1].SetPositionAndRotation(new Vector3(-2, 1, 0), new Quaternion());

        }else if(transArray[0].position.x == 2 && transArray[0].position.y == -1)
        {
            transArray[0].SetPositionAndRotation(new Vector3(-2, -1, 0), new Quaternion());
            transArray[1].SetPositionAndRotation(new Vector3(2, 1, 0), new Quaternion());

        }else if(transArray[0].position.x == -2 && transArray[0].position.y == -1)
        {
            transArray[0].SetPositionAndRotation(new Vector3(-2, 1, 0), new Quaternion());
            transArray[1].SetPositionAndRotation(new Vector3(2, -1, 0), new Quaternion());
        }else if(transArray[0].position.x == -2 && transArray[0].position.y == 1)
        {
            transArray[0].SetPositionAndRotation(new Vector3(2, 1, 0), new Quaternion());
            transArray[1].SetPositionAndRotation(new Vector3(-2, -1, 0), new Quaternion());
        }
    }
}
