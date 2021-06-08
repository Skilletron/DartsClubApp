using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winner : MonoBehaviour
{
    public PlayerController playerController;
    public Text name_winner;
    public GameMode gameMode;
    public MainCalc mainCalc;
    public Animator Winner_animation;
    public PlayerData playerdata;
    public DataManager dataManager;
    public bool win;
    public int[] winner;
    public int[] statistic_day = new int[10];
    public int m;

   
    public void Update()
    {
        
        for (int i = 0; i < playerController.Score.Length; i++){
         winner[i] = int.Parse(playerController.Score[i].text);
            if(winner[i] <= 0)
            {
                name_winner.GetComponent<Text>().text = playerController.Name[i].text;
                Winner_animation.SetBool("PlayerWin", true);
                win = true;
               
                
              
                
}               
        }
        if (win == true)
        {
            win = false;
            statistic_day[m] = (mainCalc.maxresult) / 3;
           
        }
    }

    public void OnClickButtonRestart()
    {
        dataManager.data.m = dataManager.data.m + 1;
        Winner_animation.SetBool("PlayerWin", false);
        Application.LoadLevel("Game");
    }
}
