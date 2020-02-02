﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class cost : MonoBehaviour
{
    [SerializeField]
    placebuildings placeb;
    [SerializeField]
    GameObject slot1im;
    [SerializeField]
    GameObject slot2im;
    [SerializeField]
    int slot1int;
    [SerializeField]
    int slot2int;
    [SerializeField]
    TextMeshProUGUI slot1t;
    [SerializeField]
    TextMeshProUGUI slot2t;
    [SerializeField]
    GameObject fire;
    [SerializeField]
    GameObject stone;
    [SerializeField]
    GameObject wood;

    public bool canafford;
    [SerializeField]
    stonedisplay stony;
    [SerializeField]
    wooddisplay woody;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        slot1t.text = slot1int.ToString();
        slot2t.text = slot2int.ToString();
        if (placeb.testbuilding == fire )
        {
            slot1im = stone;
            slot1int = 1;
            slot2im = wood;
            slot2int = 10;
            if(stony.stone >= slot1int&& woody.wood >= slot2int)
            {
                canafford = true;
            }
            if(placeb.justplaced == true)
            {
                stony.stone -= slot1int;
                woody.wood -= slot2int;
            }
          
        }
    }
}
