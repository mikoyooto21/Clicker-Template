using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Data.Common;

public class EnemySystem : MonoBehaviour
{
    public double hp = 10;
    public double enemyNext = 1;
    [SerializeField] private float multiplier = 1.055f;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Image enemyImg;
    [SerializeField] private Button enemyBtn;
    [SerializeField] private EnemiesConfig enemiesConfig;

    private void Start() {
        //load last HP and Image
        text.text = hp.ToString();
    }
    
    private void NextHPCalculating(){
        hp = Math.Round(Math.Pow(hp * enemyNext, multiplier), 0);
    }

    private void NextEnemyImage(){
        
        int idRand = UnityEngine.Random.Range(0, enemiesConfig.Enemies.Count-1);
        enemyImg.sprite = enemiesConfig.Enemies[idRand].enemyImg;
    }

    private void NextEnemy(){
        NextHPCalculating();
        NextEnemyImage();
        text.text = hp.ToString();
    }

    public void EnemyDmg(){
        hp--;
        text.text = hp.ToString();
        if(hp<=0){
            hp = 10;
            enemyNext++;
            NextEnemy();
        }
    }
}