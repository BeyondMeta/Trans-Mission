using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour {

    private static CanvasManager instance = null;

    public static CanvasManager Instance
    {
        get
        {
            return instance;
        }
    }

    public GameObject mainMenu;
    public GameObject options;
    public GameObject credits;
    public GameObject gameScreen;
    public GameObject introduction;
    public GameObject conclusion;
    public GameObject decryptedMessages;
    public GameObject nameEntryWindow;
    private object instance;

    private void Awake()
    {
        // if the singleton hasn't been initialized yet
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;//Avoid doing anything else
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void NextScreen(string screenName)
    {
        deactivateCanvas();
        switch (screenName)
        {
            case "mainMenu":

               // mainMenu.GetComponent<Canvas>().enabled = true;
                mainMenu.SetActive(true);
                
                break;
            case "options":
                //options.GetComponent<Canvas>().enabled = true;
               
                options.SetActive(true);
                
                break;
            case "credits":
                //credits.GetComponent<Canvas>().enabled = true;
                
                credits.SetActive(true);
                
                break;
            case "gameScreen":
                //gameScreen.GetComponent<Canvas>().enabled = true;
                
                gameScreen.SetActive(true);
                
                break;
            case "introduction":
                //introduction.GetComponent<Canvas>().enabled = true;
               
                introduction.SetActive(true);
              
                break;
            case "conclusion":
                // conclusion.GetComponent<Canvas>().enabled = true;
               
                conclusion.SetActive(true);
               
                break;
            case "decryptedMessages":
                //decryptedMessages.GetComponent<Canvas>().enabled = true;
               
                decryptedMessages.SetActive(true);
              
                break;
            case "nameEntryWindow":
                //nameEntryWindow.GetComponent<Canvas>().enabled = true;
                
                nameEntryWindow.SetActive(true);
                break;
        }
    }

    void deactivateCanvas()
    {
        mainMenu.SetActive(false);
        options.SetActive(false);
        credits.SetActive(false);
        gameScreen.SetActive(false);
        introduction.SetActive(false);
        conclusion.SetActive(false);
        decryptedMessages.SetActive(false);
        nameEntryWindow.SetActive(false);

        /*
        mainMenu.GetComponent<Canvas>().enabled = false;
    options.GetComponent<Canvas>().enabled = false;
    credits.GetComponent<Canvas>().enabled = false;
    gameScreen.GetComponent<Canvas>().enabled = false;
    introduction.GetComponent<Canvas>().enabled = false; 
    conclusion.GetComponent<Canvas>().enabled = false; 
    decryptedMessages.GetComponent<Canvas>().enabled = false;
    nameEntryWindow.GetComponent<Canvas>().enabled = false;
    */
    }

}
