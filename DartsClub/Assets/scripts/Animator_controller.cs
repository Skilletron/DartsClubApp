using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animator_controller : MonoBehaviour
{
    public PlayerController playerController;
    public MainCalc mainCalc;
    public Animator Gamemode_animation;
    public Animator EnterName_animation;
    public Animator History_animation;
    public Animator Options_animation;
    public InputField name;
    public AudioSource audio;
    public AudioClip clip;
        

    public void OnClickButtonOption()
    {
        audio.PlayOneShot(clip);
        Options_animation.SetBool("PlayerClickOptions", true);
    
    }
    public void OnClickButtonHistory()
    {
        audio.PlayOneShot(clip);
        History_animation.SetBool("PlayerClickHistory", true);
        Options_animation.SetBool("PlayerClickOptions", false);
    }
    public void OnClickButtonGame()
    {
        audio.PlayOneShot(clip);
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
