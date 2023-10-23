using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManeger : MonoBehaviour
{
    public int kills;
    public int score;
    public int tickets;


    public float minutes;
    public float seconds;
    public float timer;

    public TMP_Text ticketText;
    public TMP_Text killCount;
    public TMP_Text timeDisplay;
    public TMP_Text scoreDisplay;

    private void Start()
    {
  
    }

    void Update()
    {
        timer += Time.deltaTime;

        minutes = Mathf.FloorToInt(timer / 60f);
        seconds = Mathf.FloorToInt(timer - minutes * 60);

        string displayTime = string.Format("{0:00}:{1:00}", minutes, seconds);



        scoreDisplay.text = "Score: " + score.ToString();

        timeDisplay.text = displayTime;

        ticketText.text = tickets.ToString();

        killCount.text = killCount.ToString();
    }
}
