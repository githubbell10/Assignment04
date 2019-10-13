﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int PinCount = 0;
    public Text text;
    public void Start()
    {
        PinCount = 0;
    }

    public void Update()
    {
        KeepData.PlayerScore = PinCount;
        text.text = PinCount.ToString();
    }
}
