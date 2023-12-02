using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BtnData
{
    public int buttonId;
    public string mainText;    
    public GameObject ButtonPrefab;
    public Sprite buttonImage;
    public double attack;    
    public double upgradePriceStart;
    public int upgradesAmount;
}

[CreateAssetMenu(fileName = "ButtonConfig", menuName = "New Buttons Config")]
public class ButtonsConfig : ScriptableObject
{
    [SerializeField] private List<BtnData> _btns = new List<BtnData>();

    public List<BtnData> Btns => _btns;
}