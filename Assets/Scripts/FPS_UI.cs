using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS_UI : MonoBehaviour
{
    public Text fpsCounter;

    private void Update()
    {
        //minimum fps of 30
        fpsCounter.text = "" + 1 / Time.deltaTime;
    }
}
