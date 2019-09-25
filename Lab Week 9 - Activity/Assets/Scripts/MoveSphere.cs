using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    private Vector3 target = new Vector3(-3, 1, 0);
    public float duration = 1.5f;
    public Tweener tw;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!tw.TweenExists(transform))
        {
            if(target.x < 0)
            {
                target.x = 3;
            }else if (target.x > 0)
            {
                target.x = -3;
            }
            tw.AddTween(transform, transform.position, target, duration / SpeedManager.SpeedModifier);
        }
    }
}
