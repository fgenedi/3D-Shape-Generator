using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameUI : MonoBehaviour
{

    public static  Color curColor;
    public static bool colour = false;
    public static bool save = false;
    public void OnChangeColour()
    {
        curColor = Random.ColorHSV();
        GameManager.curShape.GetComponent<Renderer>().material.color = curColor;
        colour = true;
       
    }
    public void OnSave()
    {
        save = true;
    }
    
}
