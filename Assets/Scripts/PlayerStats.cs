using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int attack;
    public int currentHp;
    public int maxHp = 100;

    //public Image healthBar;

    private float timer = 0f;
    public float delayAmount = 2f;

    private void Start()
    {
        currentHp = maxHp;
    }
    void Update()
    {
        if(currentHp <= maxHp)
        {
            timer += Time.deltaTime;

            if(timer >= delayAmount)
            {
                timer = 0f;
                currentHp++;
            }
        }

        //healthBar.fillAmount = currentHp = maxHp;

        if(currentHp <= 0)
        {
            Debug.Log("Game Over");
        }

    }
}
