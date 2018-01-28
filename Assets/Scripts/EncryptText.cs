using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

public class EncryptText : MonoBehaviour {

    public Text encryptedText;
    public Text decryptedText;
    public InputField inputField;


    string myString;
    const string glyphs = "abcdefghijklmnopqrstuvwxyz0123456789";
    int j = 0;

    void Start()
    {
        TextAsset textFile = (TextAsset)Resources.Load("storystring");
        string story = textFile.ToString();

        string[] storyArray = story.Split("\n"[0]);

    }

    void generateText(string[] sA)
    {
       
            while (j < sA.Length)
        {
            int charAmount = sA[j].Length;
            for (int i = 0; i < charAmount; i++)
            {
                myString += glyphs[UnityEngine.Random.Range(0, glyphs.Length)];
            }
            encryptedText.text = myString; 
        }
    }
 
int charAmount = storyArray[j]; 
    int 
 for(int i=0; i<charAmount; i++)
 {
     myString += glyphs[Random.Range(0, glyphs.Length)];
 }

// Update is called once per frame
void Update ()
    {
		if(j <= storyArray.Length)
    {
        CanvasManager.NextScreen("Conclusion");
    }

	}

}
