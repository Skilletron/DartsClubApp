using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Options : MonoBehaviour
{
    public Slider int_volume;
    public DataManager dataManager;
    public AudioSource volume;
    public Text[] Translate;
    public bool RU, EN;

    public void Awake()
    {
 
        if(RU == true)
        {
            Translate[0].GetComponent<Text>().text = "История";
            Translate[1].GetComponent<Text>().text = "Игра";
            Translate[2].GetComponent<Text>().text = "Настройки";
            Translate[3].GetComponent<Text>().text = "Статистика";
            Translate[9].GetComponent<Text>().text = "Звук";
            Translate[10].GetComponent<Text>().text = "Язык";
            Translate[11].GetComponent<Text>().text = "Введите ваше имя";
            Translate[12].GetComponent<Text>().text = "Выберите режим";
        }
        else if (EN == true)
        {
            Translate[0].GetComponent<Text>().text = "History";
            Translate[1].GetComponent<Text>().text = "Game";
            Translate[2].GetComponent<Text>().text = "Options";
            Translate[3].GetComponent<Text>().text = "Statistic";
            Translate[9].GetComponent<Text>().text = "Sound";
            Translate[10].GetComponent<Text>().text = "Language";
            Translate[11].GetComponent<Text>().text = "Enter your name";
            Translate[12].GetComponent<Text>().text = "Choose Gamemode";
        }
    }
    void Update()
    {
        volume.volume = int_volume.value;

    }

    public void OnClickButtonRU()
    {
        Translate[0].GetComponent<Text>().text = "История";
        Translate[1].GetComponent<Text>().text = "Игра";
        Translate[2].GetComponent<Text>().text = "Настройки";
        Translate[3].GetComponent<Text>().text = "Статистика";
        Translate[9].GetComponent<Text>().text = "Звук";
        Translate[10].GetComponent<Text>().text = "Язык";
        Translate[11].GetComponent<Text>().text = "Введите ваше имя";
        Translate[12].GetComponent<Text>().text = "Выберите режим";
        RU = true;
        EN = false;
      
        
    }
    public void OnClickButtonEN()
    {
        Translate[0].GetComponent<Text>().text = "History";
        Translate[1].GetComponent<Text>().text = "Game";
        Translate[2].GetComponent<Text>().text = "Options";
        Translate[3].GetComponent<Text>().text = "Statistic";
        Translate[9].GetComponent<Text>().text = "Sound";
        Translate[10].GetComponent<Text>().text = "Language";
        Translate[11].GetComponent<Text>().text = "Enter your name";
        Translate[12].GetComponent<Text>().text = "Choose Gamemode";
        RU = false;
        EN = true;
    }
}
