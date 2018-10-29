using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreviousScene : MonoBehaviour {

    public string previousScene;

	void Awake () {

        DontDestroyOnLoad(this.gameObject);

        if (FindObjectsOfType(GetType()).Length > 1)
            Destroy(gameObject);

    }

    public void SaveScene()
    {
        previousScene = SceneManager.GetActiveScene().name;

    }

}
