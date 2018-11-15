using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleSwitch : MonoBehaviour {

public void EasySwitch(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
