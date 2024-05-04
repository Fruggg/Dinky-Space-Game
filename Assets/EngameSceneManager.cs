using UnityEngine;
using UnityEngine.SceneManagement;

public class EngameSceneManager : MonoBehaviour

{
    public PlayerScoreHandler handler;
    public void RestartGame()
    {
        //reset the score
        handler.score = 0;
        SceneManager.LoadSceneAsync(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

   
}
