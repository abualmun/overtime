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
    [SerializeField] Canvas pauseGameMenu;
    [SerializeField] Canvas gameplayUI;
    [SerializeField] Canvas gameOverMenu;
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

    }

    void LostGame()
    {
        gameplayUI.gameObject.SetActive(false);
        gameOverMenu.gameObject.SetActive(true);
        Time.timeScale = 0;

    }
    void PauseGame()
    {

        Time.timeScale = 0;
        pauseGameMenu.gameObject.SetActive(true);
        gameplayUI.gameObject.SetActive(false);
    }
    void Continue()
    {
        Time.timeScale = 1;
        pauseGameMenu.gameObject.SetActive(false);
        gameplayUI.gameObject.SetActive(true);
    }
    void RandomInstantiate()
    {
        Vector3 position = platformsParent.position + new Vector3(0, 0, platformLength);

        Instantiate(platforms[0], position, Quaternion.identity);


    }
}
