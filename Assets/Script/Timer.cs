using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float time;
    public bool gameOver;
    public Text timer;
    public float pointperSecond;
    public ShowResult skor;

    void Start()
    {
        time = 62f;
        gameOver = false;
    }

    void Update()
    {
        if (!gameOver)
        {
            time -= pointperSecond * Time.deltaTime;
            timer.text = "Timer : " + Mathf.Round(time);
        }

        if (time <= 0)
        {
            skor.hasil.gameObject.SetActive(true);
            skor.barang.gameObject.SetActive(false);
            gameOver = true;
        }
    }
}
