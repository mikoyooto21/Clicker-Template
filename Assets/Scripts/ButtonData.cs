using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BtnDataMono : MonoBehaviour{
    
}

public class ButtonData : MonoBehaviour
{
    public int id;
    public double attack;
    public double upgradePriceStart;
    public int upgradesAmount;
    
    public void DataGetter(int get_id, double get_attack, double get_upgradePriceStart, int get_upgradesAmount){
        id = get_id;
        attack = get_attack;
        upgradePriceStart = get_upgradePriceStart;
        upgradesAmount = get_upgradesAmount;
    }

    public void DataSaver(){
        FindAnyObjectByType<SaveLoadJSON>().SaveGame(id, attack, upgradesAmount);
    }

    public int SetId(){
        return id;
    }

    public void SetAttackText(){
        TextMeshProUGUI attackText = transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        attackText.text = attack.ToString();
    }
    
    public void SetAttack(){
        attack = Upgrades.AttackIncreaser(attack, upgradesAmount);
        SetAttackText();
    }

    public void SetPriceText(){
        TextMeshProUGUI priceText = transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        priceText.text = upgradePriceStart.ToString();
    }
    
    public void SetPrice(){
        TextMeshProUGUI priceText = transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        priceText.text = Upgrades.PriceIncreaser(upgradePriceStart, upgradesAmount).ToString();
    }
    
    public void SetUpgradesAmount(){
        upgradesAmount++;
    }
}
