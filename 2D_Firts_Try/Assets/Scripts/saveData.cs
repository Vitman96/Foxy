using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveData : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D col)
    {
       PlayerPrefs.SetInt("diamonds", ScoreTextScribt.coinAmount);
    }
}
