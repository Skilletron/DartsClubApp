using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animator_controller : MonoBehaviour
{
    public PlayerController playerController;
    public MainCalc mainCalc;
    public GameObject Game, History, Options, Statistic;
    public Animator Gamemode_animation, Options_animation, History_animation, EnterName_animation,Statistic_animation;
    public InputField name;
    public AudioSource audio;
    public AudioClip clip;

    private void Start()
    {
        Options.GetComponent<Canvas>().sortingOrder = 0;
        Game.GetComponent<Canvas>().sortingOrder = 1;
        History.GetComponent<Canvas>().sortingOrder = 0;
        Statistic.GetComponent<Canvas>().sortingOrder = 0;
    }
    public void OnClickButtonOption()
    {
        audio.PlayOneShot(clip);
        Options.GetComponent<Canvas>().sortingOrder = 1;
        Game.GetComponent<Canvas>().sortingOrder = 0;
        History.GetComponent<Canvas>().sortingOrder = 0;
        Statistic.GetComponent<Canvas>().sortingOrder = 0;
        Options_animation.SetBool("PlayerClickOptions", true);
        Statistic_animation.SetBool("StatisticClick", false);
        History_animation.SetBool("PlayerClickHistory", false);

    }
    public void OnClickButtonHistory()
    {
        audio.PlayOneShot(clip);
        Options.GetComponent<Canvas>().sortingOrder = 0;
        Game.GetComponent<Canvas>().sortingOrder = 0;
        History.GetComponent<Canvas>().sortingOrder = 1;
        Statistic.GetComponent<Canvas>().sortingOrder = 0;
        History_animation.SetBool("PlayerClickHistory", true);
        Statistic_animation.SetBool("StatisticClick", false);
        Options_animation.SetBool("PlayerClickOptions", false);
    }
    public void OnClickButtonGame()
    {
        Options.GetComponent<Canvas>().sortingOrder = 0;
        Game.GetComponent<Canvas>().sortingOrder = 1;
        History.GetComponent<Canvas>().sortingOrder = 0;
        Statistic.GetComponent<Canvas>().sortingOrder = 0;
        audio.PlayOneShot(clip);
        Statistic_animation.SetBool("StatisticClick", false);
        History_animation.SetBool("PlayerClickHistory", false);
        Options_animation.SetBool("PlayerClickOptions", false);
    }
    public void OnClickButtonStatistic()
    {
        Options.GetComponent<Canvas>().sortingOrder = 0;
        Game.GetComponent<Canvas>().sortingOrder = 0;
        History.GetComponent<Canvas>().sortingOrder = 0;
        Statistic.GetComponent<Canvas>().sortingOrder = 1;
        audio.PlayOneShot(clip);
        Statistic_animation.SetBool("StatisticClick", true);
        History_animation.SetBool("PlayerClickHistory", false);
        Options_animation.SetBool("PlayerClickOptions", false);
    }
    public void OnClickButton_Gamemode() {
        audio.PlayOneShot(clip);
        Gamemode_animation.SetBool("GameMode_click", true);
    }
    public void OnClickButton_AddPlayerName()
    {
        audio.PlayOneShot(clip);
        EnterName_animation.SetBool("AddPlayer", true);
    }
    public void OnClickButton_NameOK()
    {
  
            audio.PlayOneShot(clip);
            EnterName_animation.SetBool("AddPlayer", false);
            playerController.Name[playerController.NumberPlayer].GetComponent<Text>().text = playerController.Player_Name.text;
            playerController.Name_History[playerController.NumberPlayer].GetComponent<Text>().text = playerController.Player_Name.text;
            if(playerController.Name[playerController.NumberPlayer].GetComponent<Text>().text == ""|| playerController.Name[playerController.NumberPlayer].GetComponent<Text>().text == " "|| playerController.Name[playerController.NumberPlayer].GetComponent<Text>().text == "   "|| playerController.Name[playerController.NumberPlayer].GetComponent<Text>().text == "     ")
        {
            playerController.Name[playerController.NumberPlayer].GetComponent<Text>().text = "Player" + " " + playerController.NumberPlayer;
            playerController.Name_History[playerController.NumberPlayer].GetComponent<Text>().text = "Player" + " " + playerController.NumberPlayer;
        }
       
    }
}
