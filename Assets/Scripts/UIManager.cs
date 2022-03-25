using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text maxScoreText;
    public TMP_Text loseQuote;
    public GameObject loseMenu;
    private bool hasLost;

    void Start()
    {
        Input.backButtonLeavesApp = true;
    }


    void Update()
    {
        // update Score

        scoreText.text = ((int)GameManager.gameManager.score).ToString();
    }

    public void Play()
    {

        Debug.Log("Playing");
        Input.backButtonLeavesApp = false;
        SceneManager.LoadScene("Level1"); // TODO: change it to scene name
        Time.timeScale = 1;
    }

    public void Pause()
    {
        Debug.Log("Pausing");
        GameManager.gameManager.TogglePause();
    }

    public void Exit()
    {
        Input.backButtonLeavesApp = true;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
        EditorApplication.ExitPlaymode();
    }

    public void ShowMenu(GameObject menu)
    {
        menu.SetActive(true);
    }

    public void HideMenu(GameObject menu)
    {
        menu.SetActive(false);
    }

    public void SetLoseQuote()
    {
        loseQuote.text = Quoutes.GetRandomQuote();
    }
    public void Lose()
    {
        scoreText.text = ((int)GameManager.gameManager.score).ToString();

        loseMenu.SetActive(true);
        Time.timeScale = 0;
        if (!hasLost)
        {
            SetLoseQuote();
        }
        hasLost = true;
    }

}

[System.Serializable]
class QuotesJson
{
    public List<string> qoutes;
}

