using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAllGame : MonoBehaviour
{
    public PlayerData playerdata;
    public DataManager dataManager;
    public Winner winner;
    public Options options;
    public void Awake()
    {
        if (winner.m == 0 || dataManager.data.m == 0)
        {
            for (int n = 0; n != winner.statistic_day.Length; n++)
            {
                winner.statistic_day[n] = 5;
            }
        }

        dataManager.Load();
        options.EN = dataManager.data.EN;
        options.RU = dataManager.data.RU;
        winner.m = dataManager.data.m;
        options.int_volume.value = dataManager.data.volume;
        
    
        if(winner.m != 0)
        {
            for (int n = 0; n != winner.statistic_day.Length; n++)
            {
                winner.statistic_day[n] = dataManager.data.graph[n];
            }
        }



    }

    // Update is called once per frame
    public void Update()
    {
        dataManager.Save();
        dataManager.data.m = winner.m;
        dataManager.data.EN = options.EN;
        dataManager.data.RU = options.RU;
        dataManager.data.graph[0] = winner.statistic_day[0];
        dataManager.data.graph[1] = winner.statistic_day[1];
        dataManager.data.graph[2] = winner.statistic_day[2];
        dataManager.data.graph[3] = winner.statistic_day[3];
        dataManager.data.graph[4] = winner.statistic_day[4];
        dataManager.data.graph[5] = winner.statistic_day[5];
        dataManager.data.graph[6] = winner.statistic_day[6];
        dataManager.data.graph[7] = winner.statistic_day[7];
        dataManager.data.graph[8] = winner.statistic_day[8];
        dataManager.data.graph[9] = winner.statistic_day[9];
        dataManager.data.volume = options.int_volume.value;



    }
}
