using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomEnemy : MonoBehaviour
{
    [SerializeField] private EnemiesConfig enemyConf;
    private Image enemyImage;

    private void OnEnable() {
        enemyImage = gameObject.GetComponent<Image>();
        KilledEnemy();
    }

    public void KilledEnemy(){
        enemyImage.sprite = enemyConf.Enemies[Random.Range(0,enemyConf.Enemies.Count)].enemyImg;
    }
}
