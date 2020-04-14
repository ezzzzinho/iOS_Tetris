using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public int music = 0; //Domyślne ustawienie Audio (OFF)
    public int HScore; //Wynik Highscore
    public Text AudioSetting; //Tekst On/Off do Audio
    public Text HighScore; //Tekst do wyświetlania Highscore

    void Start()
    {
        music = PlayerPrefs.GetInt("Audio", 0); //Przypisanie wartości z bazy danych do "Music"

        if (music == 0)
        {
            AudioSetting.text = "OFF";
        }
        else if (music == 1)
        {
            AudioSetting.text = "ON";
        }

        HScore = PlayerPrefs.GetInt("HighScore", 0); //Przypisanie z bazy danych Highscore;
        HighScore.text = "" + HScore; //Wyświetlanie Highscore;
    }

    public void exitGame()
    {
        Application.Quit(); //Wyjście z aplikacji
    }

    public void loadLevel()
    {
        SceneManager.LoadScene(1); //Załadowanie następnej sceny
    }

    public void musicSettings() //Ustawienia Audio
    {
        if (music == 0)
        {
            music = 1;
            PlayerPrefs.SetInt("Audio", music);
            AudioSetting.text = "ON";
        }
        else
        {
            music = 0;
            PlayerPrefs.SetInt("Audio", music);
            AudioSetting.text = "OFF";
        }
    }
}

