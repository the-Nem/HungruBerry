using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace HongryBerry
{
    public static class SaveManager
    { 
        public static void SaveValues(Player player)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + "/player.fun";
            FileStream stream = new FileStream(path, FileMode.Create);
            PlayerData data = new PlayerData(player);
            formatter.Serialize(stream, data);
            stream.Close();

        }
        public static PlayerData LoadPlayer()
        {
            string path = Application.persistentDataPath + "/player.fun";
            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);
                PlayerData data = formatter.Deserialize(stream) as PlayerData;
                stream.Close();
                return data;

            }
            else
            {
                Debug.Log("File not found");
                return null;
            }
        }
    }    
}
