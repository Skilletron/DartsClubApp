using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Options : MonoBehaviour
{
    public Slider int_volume;
    public AudioSource volume;
    public Text[] Translate;
    void Update()
    {
        volume.volume = int_volume.value;
    }
    public void OnClickButtonRU()
    {
        Translate[0].GetComponent<Text>().text = "История";
        Translate[1].GetComponent<Text>().text = "Игра";
        Translate[2].GetComponent<Text>().text = "Настройки";
        Translate[9].GetComponent<Text>().text = "Звук";
        Translate[10].GetComponent<Text>().text = "Язык";
        Translate[11].GetComponent<Text>().text = "Введите ваше имя";
        Translate[12].GetComponent<Text>().text = "Выберите режим";
    }
    public void OnClickButtonEN()
    {
        Translate[0].GetComponent<Text>().text = "History";
        Translate[1].GetComponent<Text>().text = "Game";
        Translate[2].GetComponent<Text>().text = "Options";
        Translate[9].GetComponent<Text>().text = "Sound";
        Translate[10].GetComponent<Text>().text = "Language";
        Translate[11].GetComponent<Text>().text = "Enter your name";
        Translate[12].GetComponent<Text>().text = "Choose Gamemode";
    }
}
