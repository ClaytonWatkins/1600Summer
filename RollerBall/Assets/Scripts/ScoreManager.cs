﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {

public static int score;
public static int winScore;

Text text;

void Start(){
    text = GetComponent<Text>();
        score = 0;}

void Update()
{
    if (score < 0 )
        score =0;

    text.text = " " + score;
}
public static void AddPoints(int pointsToAdd){
    score += pointsToAdd;
}    

public void Reset(){
    score=0;
}
void FixedUpdate(){
    if (score > 100)
    	SceneManager.LoadScene(3);
}
}