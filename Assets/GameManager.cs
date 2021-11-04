using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelayTime = 1f;

    public void EndGame()
    {
        if (gameHasEnded)
            return;

        gameHasEnded = true;
        Debug.Log("GAME OVER");
        Invoke("Restart", restartDelayTime);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
