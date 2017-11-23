using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComFunc {

    float currentTime = 0;

	public float LerpForTime(float x, float y, float forTime)
    {
        return Mathf.Lerp(x, y, currentTime/forTime);
    }
}
