using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace HongryBerry
{
    public class SaverBase
    {
        public static void SaveValues(CollectValues player)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + "/Berry.fun";
            FileStream stream = new FileStream(path, FileMode.Create);
            SaveData data = new SaveData(player);
            formatter.Serialize(stream, data);
            stream.Close();

        }
        public static SaveData LoadPlayer()
        {
            string path = Application.persistentDataPath + "/Berry.fun";
            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);
                SaveData data = formatter.Deserialize(stream) as SaveData;
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
