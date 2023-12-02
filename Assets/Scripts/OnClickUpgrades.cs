using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class OnClickUpgrades : MonoBehaviour
{
    private ButtonData _btn;
    private void Start(){
        _btn = transform.GetComponent<ButtonData>();
    }
    public void OnClicked(){
        _btn.SetUpgradesAmount();
        _btn.SetAttack();
        _btn.SetPrice();
        _btn.DataSaver();
    }
}
