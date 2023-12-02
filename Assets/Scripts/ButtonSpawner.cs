using UnityEngine;

public class ButtonSpawner : MonoBehaviour
{
    [SerializeField] private SaveLoadJSON saveLoadJSON;
    [SerializeField] private GameObject buttonPrefab;
    [SerializeField] private Transform buttonContainer;
    [SerializeField] private ButtonsConfig buttonsConfig; 
    private void Start()
    {
        for (int i = 0; i <= buttonsConfig.Btns.Count - 1; i++)
        {
            BtnData loadedData = saveLoadJSON.LoadGame(i);
            Debug.Log(i);
            GameObject newButtonGameObject = Instantiate(buttonPrefab, buttonContainer);
            UpgradeButtonsSet buttonsSet = newButtonGameObject.GetComponent<UpgradeButtonsSet>();
            buttonsSet.SetButton(i, loadedData);
            Debug.Log("Data loaded BTNSPAWNER");
        }
    }
}