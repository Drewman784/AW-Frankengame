using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWallSpawn : MonoBehaviour
{

    //creates array
    public GameObject[] randomWalls;
    //Add all parts of the layout you want to randomly spawn in the array

    //Set time between randomizations
    public float randomTime = 4f;

    //Set amount of walls that spawn each time, make it one less than the desired number because the coount begins from #0
    public int wallAmount;

    // Update is called once per frame
    void Update()
    {
        //Makes the time go towards zero
            randomTime -= Time.deltaTime;

        if(randomTime <= 0){
            
            //Turns off all walls before each randomization
            foreach(GameObject w in randomWalls){
            w.SetActive(false);
            }

            //Spawns a determined number of walls
            int a;
            for(a=0; a<=wallAmount; a++){
                //Chooses random element in array and sets it active
                int i = Random.Range(0, randomWalls.Length);
                GameObject chosenWall = randomWalls[i];
                chosenWall.SetActive(true);
            }

            //Resets timer
            randomTime = 4f;
        }
    }
}
