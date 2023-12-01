using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameSaver : MonoBehaviour
{
    public static NameSaver Instance;
    public InputField Name;
    public static string EnteredName;
private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

public void SaveName()
{
    EnteredName = Name.text;
} 

}
