using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreText;
    public int score;
    public ShowResult hasil;

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        scoreText.text = "Score : " + score;
        hasil.tulis.text = "Score : " + score;
    }
}
