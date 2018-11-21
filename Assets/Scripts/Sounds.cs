﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public static Sounds instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }
    public void ClickSoundFX()
    {
        GameObject instance = Instantiate(GameManager.instance.clickSoundFX, transform.position, Quaternion.identity);
        Destroy(instance, 0.3f);
    }



}
