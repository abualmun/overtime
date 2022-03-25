using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    public bool gameOver;
    public bool gamePaused;

    public float score;
    [Header("UI Elements")]
    [SerializeField] UIManager gameMenu;
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject inGameMenu;

    [Header("Gameplay")]
    [SerializeField] List<GameObject> platforms;
    [SerializeField] Transform platformsParent;
    public float platformLength;




    private void Awake()
    {
        gameManager = this;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver && !gamePaused)
        {
            score += Time.deltaTime * 4;
        }
        if (gameOver)
            gameMenu.Lose();

    }
    public void TogglePause()
    {
        pauseMenu.SetActive(gamePaused);
        inGameMenu.SetActive(!gamePaused);
        Time.timeScale = (gamePaused ? 0 : 1);
        gamePaused = !gamePaused;
    }

    void RandomInstantiate()
    {
        Vector3 position = platformsParent.position + new Vector3(0, 0, platformLength);

        Instantiate(platforms[0], position, Quaternion.identity);


    }
}
