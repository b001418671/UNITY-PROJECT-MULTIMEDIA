using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float rstartDelay = 1f;

    public void EndGame ()
    {
        if(gameHasEnded == false)
        {
        gameHasEnded = true;
        Debug.Log("Game Over");
        Invoke("Restart", rstartDelay);
        }
    }
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
