using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;

    public GameObject completeLevelUI;
    public GameObject restartLevelUI;
    public GameObject gameWonUI;
    public GameObject fogUI;


    public void EndGame(){
      if (GameHasEnded == false) {
        GameHasEnded = true;
        Restart();
      }
    }

    public void ChangeLevel(){
      if (SceneManager.GetActiveScene().buildIndex == 6){
        gameWonUI.SetActive(true);
      }
      else {
        completeLevelUI.SetActive(true);
      }
    }

    void Restart(){
      restartLevelUI.SetActive(true);
    }
    public void addFog(){
      fogUI.SetActive(true);
    }


}
