using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class EnemyData
{
    public int enemyId;
    public Sprite enemyImg;
    public int classBossOrNot;
}

[CreateAssetMenu(fileName = "EnemyConfig", menuName = "New Enemies Config")]
public class EnemiesConfig : ScriptableObject
{
    [SerializeField] private List<EnemyData> _enemies = new List<EnemyData>();

    public List<EnemyData> Enemies => _enemies;
}