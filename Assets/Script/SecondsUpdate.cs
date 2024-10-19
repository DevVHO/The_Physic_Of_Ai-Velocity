using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondsUpdate : MonoBehaviour
{
    float TimeStartOffset = 0;
    bool gotStartTime = false;
    float speed = 0.5f;
    void Update()
    {
        if(!gotStartTime)
        {
            TimeStartOffset = Time.realtimeSinceStartup;
            gotStartTime = true;
        }
        this.transform.position = new Vector3(this.transform.position.x,
                                              this.transform.position.y,
                                              (Time.realtimeSinceStartup - TimeStartOffset) * speed);
    }
}
