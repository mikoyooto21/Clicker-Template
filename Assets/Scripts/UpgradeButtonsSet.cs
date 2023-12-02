using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class UpgradeButtonsSet : MonoBehaviour
{
    [SerializeField] private ButtonsConfig buttonsConfig;
    private ButtonData btn;

    public void SetButton(int i, BtnData loadedData)
    {
        Debug.Log(loadedData);
        btn = transform.GetComponent<ButtonData>();
        TextMeshProUGUI btnText = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        Image btnImage = transform.GetComponent<Image>();

        if(loadedData == null){
            btn.DataGetter(buttonsConfig.Btns[i].buttonId-1, buttonsConfig.Btns[i].attack, buttonsConfig.Btns[i].upgradePriceStart, buttonsConfig.Btns[i].upgradesAmount);
            btn.SetPriceText();
        }
        else{
            btn.DataGetter(loadedData.buttonId-1, loadedData.attack, loadedData.upgradePriceStart, loadedData.upgradesAmount);
            btn.SetPrice();
        }
        btn.SetAttackText();
        btnText.text = buttonsConfig.Btns[i].mainText;
        btnImage.sprite = buttonsConfig.Btns[i].buttonImage;
    }
}