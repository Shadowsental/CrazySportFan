using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLevel : MonoBehaviour
{
    public int level = 1;

    public int exp = 0;

    public int expToNextLevel = 20;

    //public Image expBar;

    private PlayerStats stats;

    private void Start()
    {
        stats = GetComponent<PlayerStats>();
    }

    public void Update()
    {
        //expBar.fillAmount = exp / expToNextLevel;

        if (exp == expToNextLevel )
        {
            LevelUp();
        }
    }

    void LevelUp()
    {
        level += 1;
        expToNextLevel += 10;
        exp = 0;
        stats.attack += 5;
        stats.maxHp += 15;
    }

    private void OnGUI()
    {
        
    }
}
