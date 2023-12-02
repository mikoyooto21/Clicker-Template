using UnityEngine;

public class GameDataManager : MonoBehaviour
{
    public static GameDataManager Instance { private set; get; }

    [SerializeField] private ButtonsConfig _buttonsConfig;

    public ButtonsConfig ButtonsConfig => _buttonsConfig;

    private void OnDestroy()
    {
        if (Instance == this)
            Instance = null;
    }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        else if (Instance != this)
            Destroy(gameObject);

        
    }

    private void OnEnable() {
        //UpgradeButtonsSet.OnClicked += this;
    }

    private void OnDisable() {
        //UpgradeButtonsSet.OnClicked -= this;
    }
}