//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class SceneSwitcher : MonoBehaviour {

//	public void Switch (string sceneName) {

 //       SceneManager.LoadScene(sceneName);

//    }

//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

    string prScene;
    GameObject previousScene;

    private void Start()
    {
        previousScene = GameObject.FindGameObjectWithTag("PrScene");
        prScene = previousScene.GetComponent<PreviousScene>().previousScene;
    }

    public void startGame(string sceneName)
    {
        previousScene.GetComponent<PreviousScene>().SaveScene();
        SceneManager.LoadScene(sceneName);
    }

    public void nextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void PreviousScene()
    {
        previousScene.GetComponent<PreviousScene>().SaveScene();
        SceneManager.LoadScene(prScene);
    }

}
