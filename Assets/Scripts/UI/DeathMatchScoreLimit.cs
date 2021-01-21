﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathMatchScoreLimit : MonoBehaviour
{
    TextMeshPro scoreLimitText;

    void Start()
    {
        scoreLimitText = GetComponent<TextMeshPro>();
        if(ModeDeathMatch.Instance != null)
        {
            scoreLimitText.text = ModeDeathMatch.Instance.GetScoreLimit().ToString();

        }
    }
}
