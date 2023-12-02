using UnityEngine;
using TMPro;

public class Clicks : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinsText;

    private void Awake() {
        if (PlayerPrefs.HasKey("Coins") == false) {PlayerPrefs.SetInt("Coins", 0);}
        else {coinsText.text = PlayerPrefs.GetInt("Coins").ToString();}
    }
    public void GetCoin(){
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins")+1);
        coinsText.text = PlayerPrefs.GetInt("Coins").ToString();
    }
}
