using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{
    public InputField usernameInput;
    public static string username;

    void Start()
    {
        if (username != null)
            usernameInput.text = username;
    }

    public void SaveUsername(string newName)
    {
        username = newName;
    }
}
