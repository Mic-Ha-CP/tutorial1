using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public GameObject completeLevelUI;


    public void CompleteLevel()
    {
        //Debug.Log("Level Won!");
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if(!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
            //Restart();
        }
    }

    void Restart()
    {
        //SceneManager.LoadScene("Level01"); hard-coded
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //not only for lvl1 then
    }
}
