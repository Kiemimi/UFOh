using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string LevelOne;

    public GameObject controlscreen;
    public GameObject DankMemesScreen;

    public void PlayGame()
    {
        SceneManager.LoadScene(LevelOne);
    }

    public void OpenControls()
    {
        controlscreen.SetActive(true);
    }

    public void CloseControls()
    {
        controlscreen.SetActive(false);
    }

    public void OpenDankMemes ()
    {
        DankMemesScreen.SetActive(true);
    }

    public void CloseDankMemes()
    {
        DankMemesScreen.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit Game Succesful");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
