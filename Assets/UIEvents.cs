using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIEvents : MonoBehaviour
{
    public string PlayerName;
    public GameObject PlayerNameInput;
    public UnityEngine.UIElements.Button StartButton;

    // Start is called before the first frame update
    void Start()
    {
        StartButton.clicked += StartGame;
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void StartGame()
    {
        Debug.Log("Start Game");
        SceneManager.LoadScene("Level 1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SetPlayerName()
    {
        PlayerName = PlayerNameInput.GetComponent<TextMesh>().text;
        Debug.Log(PlayerName);
    }




}
