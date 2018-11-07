using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour {

	void Awake () {
        DontDestroyOnLoad(this.gameObject);
	}

    void OnLevelWasLoaded(int level)
    {
        onOff = PlayerPrefs.GetInt("Music") == 1;
    }

    bool onOff;

	public void Music () {

        PlayerPrefs.SetInt("Music", onOff ? 0 : 1);
        PlayerPrefs.Save();

        onOff = !onOff;
        AudioListener.volume = onOff ? 0 : 1;
        
	}
}
