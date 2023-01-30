using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

public class SaveManager : Singleton<SaveManager>
{
    private UIManager uIManager;
    private PlayerData playerData;
    private ScoreManager scoreManager;
    private CloudManager cloudManager;

    public void SaveGame(Player player)
    {
        uIManager = new UIManager();
        uIManager.DisplayIcon();

        playerData = new PlayerData();
        playerData.health = player.GetHealth();
        playerData.playerID = player.GetPlayerID();

        scoreManager = new ScoreManager();
        playerData.score = scoreManager.GetScore(player.GetPlayerID());

        SerializePlayerData(playerData, true);
    }

    private void SerializePlayerData(PlayerData playerData, bool isCloudSave)
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        FileStream fileStream = File.Create(Application.persistentDataPath + "/playerInfo.dat");
        binaryFormatter.Serialize(fileStream, playerData);
        fileStream.Close();

        if (isCloudSave)
        {
            cloudManager = new CloudManager();
            cloudManager.UploadSaveGame(Application.persistentDataPath + "/playerInfo.dat");
        }
    }
}
