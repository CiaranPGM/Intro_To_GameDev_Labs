using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpeedManager.CurrentSpeedState = (SpeedManager.CurrentSpeedState == SpeedManager.GameSpeed.Slow) ? SpeedManager.GameSpeed.Fast : SpeedManager.GameSpeed.Slow;
        }
        if(GameManager.currentGameState == GameManager.GameState.Start && Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(0);
            GameManager.currentGameState = GameManager.GameState.WalkingLevel;
        }
    }
}
