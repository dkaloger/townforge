﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class fooddisplay : MonoBehaviour
{
    public int food;
    private TextMeshProUGUI textMesH;

    // Start is called before the first frame update
    void Start()
    {
        textMesH = GetComponent<TextMeshProUGUI>();
        food = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textMesH.text = food.ToString();

    }
}