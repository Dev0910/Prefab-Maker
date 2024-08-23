using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinChange : MonoBehaviour
{
    public int[] array;
    public int amount;
    public int NumberOfWays(int[] notes, int amount)
    {
        int numberOfWays = 0;
        //for (int i = 0; i < notes.Length; i++)
        //{
        //    int tempIndex = 0;
        //    for (int j = i;j<notes.Length;j++)
        //    {
        //        if(notes[tempIndex] < notes[j])
        //        {
        //            tempIndex = j;
        //        }
        //    }
        //    int temp = notes[i];
        //    notes[i] = notes[tempIndex];
        //    notes[tempIndex] = temp;
        //    print(notes[i]);
        //}

        int[] maxNotes = new int[notes.Length];
        int maxNoOfNotes = 0;
        for (int i = 0;i < notes.Length;i++)
        {
            maxNotes[i] = amount/notes[i];
            maxNoOfNotes += amount / notes[i];
            print(maxNotes[i]);
        }
        
        //while(true)
        //{
        //    int currentValue = 0;
        //    int currentIndex = 0;
        //    for (int i = 0;i<maxNoOfNotes;i++)
        //    {
        //        currentValue += notes[];
        //        if(currentValue>amount)
        //        {

        //        }
        //    }
        //    for (int i = 0; i < maxNotes.Length;i++)
        //    {
        //        for (int j = 1; j < maxNotes[i];j++)
        //        {

        //        }
        //    }
        //}


        return numberOfWays;
    }

    public int GetChange(int[] notes, int amount)
    {
        int[,] dp = new int[notes.Length + 1, amount + 1];

        // Base case initialization
        for (int i = 0; i <= notes.Length; i++)
            dp[i, 0] = 1;

        // Building up the dp table
        for (int i = 1; i <= notes.Length; i++)
        {
            for (int j = 1; j <= amount; j++)
            {
                if (notes[i - 1] <= j)
                {
                    dp[i, j] = dp[i - 1, j] + dp[i, j - notes[i - 1]];
                }
                else
                {
                    dp[i, j] = dp[i - 1, j];
                }
            }
        }

        return dp[notes.Length, amount];
    }
    private void Start()
    {
        print(GetChange(array,amount));
    }
}
