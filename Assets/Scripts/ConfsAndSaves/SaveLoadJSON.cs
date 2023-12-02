using System.IO;
using UnityEngine;
using System;
using System.Collections.Generic;

  
public class SaveLoadJSON : MonoBehaviour
{
    [SerializeField] private ButtonsConfig buttonsConfig;
    string saveFilePath;


    public void SaveGame(int id, double attack, int upgrades)
    {
        buttonsConfig.Btns[id].attack = attack;
        buttonsConfig.Btns[id].upgradesAmount = upgrades;
        saveFilePath = Application.persistentDataPath + "/BtnData.json";
        string saveBtnData = JsonHelper.ToJson(buttonsConfig.Btns.ToArray(), true);
        File.WriteAllText(saveFilePath, saveBtnData);
        Debug.Log("Save file created at: " + saveFilePath);
    }
  
    public BtnData LoadGame(int index)
    {
        saveFilePath = Application.persistentDataPath + "/BtnData.json";
        if (File.Exists(saveFilePath))
        {
                string loadBtnData = File.ReadAllText(saveFilePath);
                BtnData[] btnData = JsonHelper.FromJson<BtnData>(loadBtnData);
                Debug.Log("Data loaded");
                return btnData[index];
        }
        else
            Debug.Log("There is no save files to load!");
            return null;
    }
  
    public void DeleteSaveFile()
    {
        if (File.Exists(saveFilePath))
        {
            File.Delete(saveFilePath);
  
            Debug.Log("Save file deleted!");
        }
        else
            Debug.Log("There is nothing to delete!");
    }
}