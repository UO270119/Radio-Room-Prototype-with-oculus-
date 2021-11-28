using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
//using UnityEngine;

public class SymonSays
{

    private int controlSequence = 0;
    private Random randonNumber;
    private List<int> SimonSaid = new List<int>();
    private Boolean speaking = false;



    // Start is called before the first frame update
    void Start()
    {
        randonNumber = new Random();
        SimonSaid.Add( randonNumber.Next(0,6) );
        new Thread( StartGame ).Start();
    }

    public void StartGame()
    {
        Thread.Sleep( 100 );
        speaking = true;
        foreach (int n in SimonSaid)
        {
            switch (n)
            {
                case 0:
                    //Encender Queso 0
                    Thread.Sleep(100);
                    //Apagar queso 0
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }
        speaking = false;
    }

    private void checkPressedCheese(int pressedCheese)
    {
        if( speaking || SimonSaid.Count == 0 )
        {
            return;
        }
        if( SimonSaid[controlSequence] == pressedCheese )
        {
            controlSequence++;
        }
        else
        {
            
        }

    }

    private void click( Object sender )
    {
        String pressed = ""; //sacar el nombre del queso
        checkPressedCheese( Convert.ToInt32( pressed.Split('_')[1] ) );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
