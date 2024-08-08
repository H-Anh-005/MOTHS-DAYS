using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class ReadWriteSystem : MonoBehaviour
{
    public InputField Email;
    public InputField Password;

    public void Save()
    {
        Login data = new Login();

        data.Email = Email.text;
        data.Password = Password.text;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.dataPath + "/Login.json", json);
    }

    public void Load()
    {
        string json = File.ReadAllText(Application.dataPath + "/Login.json");

        Login daata = JsonUtility.FromJson<Login>(json);
        Email.text = daata.Email;
        Password.text = daata.Password;
    }
}
