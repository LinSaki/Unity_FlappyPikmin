using UnityEngine;
using UnityEngine.UI; // add library to use variable type 'Text'
using UnityEngine.SceneManagement; //manage scene objects

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverDisplay;
    public AudioSource pikminNoise;
    public string sceneName;

    public void changeScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    [ContextMenu("Increase Score!")] //adds function from Unity = Great for testing
    public void increaseScore( int scoreAdded)
    {
        playerScore += scoreAdded;
        scoreText.text = playerScore.ToString();
        pikminNoise.Play();
    }

    public void restartGame() // reload original scene when user clicks 'Play Again?' button
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //looks for file name - can just reference itself's name
    }

    public void gameOver()
    { 
        gameOverDisplay.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Quit!");
            Application.Quit();
        }
    }
}
