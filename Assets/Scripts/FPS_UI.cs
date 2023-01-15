using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS_UI : MonoBehaviour
{
    int fps;
    public Text fpsCounter;

    private void Start()
    {
        QualitySettings.vSyncCount = 0;

        //a minimum of 30 FPS --> greater than 30
        Application.targetFrameRate = 60;
    }
    private void Update()
    {
        fps = (int)(1f / Time.unscaledDeltaTime);
        //minimum fps of 30
        fpsCounter.text = "FPS : " + fps;
    }
}
