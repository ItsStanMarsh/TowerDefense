using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundPlay : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void OnLevelWasLoaded(int level)
    {
        onOff = PlayerPrefs.GetInt("Sounds") == 1;
    }

    bool onOff;

    public void Sounds()
    {

        PlayerPrefs.SetInt("Sounds", onOff ? 0 : 1);
        PlayerPrefs.Save();

        onOff = !onOff;
        AudioListener.volume = onOff ? 0 : 1;

    }
}
