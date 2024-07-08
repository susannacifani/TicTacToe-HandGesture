using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TicTacToeCodes : MonoBehaviour
{
    public AudioSource soundEffect;

    private Boolean checker;
    int plusone;
    const int WinningScore = 3;
    public GameObject victoryPanel;
    public GameObject gamePanel;
    public GameObject imageObject;

    private Boolean btnWritten1;
    private Boolean btnWritten2;
    private Boolean btnWritten3;
    private Boolean btnWritten4;
    private Boolean btnWritten5;
    private Boolean btnWritten6;
    private Boolean btnWritten7;
    private Boolean btnWritten8;
    private Boolean btnWritten9;

    public Text btnText1 = null;
    public Text btnText2 = null;
    public Text btnText3 = null;
    public Text btnText4 = null;
    public Text btnText5 = null;
    public Text btnText6 = null;
    public Text btnText7 = null;
    public Text btnText8 = null;
    public Text btnText9 = null;

    public Text msgFeedback = null;
    public Text msgTurn = null;

    public Text txtPlayerX;
    public Text txtPlayerO;

    public Text txtWinner = null;


    private void ShowVictoryPanel()
    {
        victoryPanel.SetActive(true);
        if (soundEffect != null)
        {
            soundEffect.Play();
        }
    }

    private void HideGamePanel()
    {
        gamePanel.SetActive(false);    
    }

    public void Draw()
    {
        msgFeedback.text = "It's a draw!";
        msgTurn.text = "";
        imageObject.SetActive(false);
    }

    public void WinnerX(Text btnTextA, Text btnTextB, Text btnTextC)
    {
        btnTextA.color = Color.red;
        btnTextB.color = Color.red;
        btnTextC.color = Color.red;
        msgFeedback.text = "The winner is Player X";
        plusone = int.Parse(txtPlayerX.text); //viene preso il testo contenuto nella variabile txtPlayerX.text e viene convertito in un numero intero (int) utilizzando il metodo int.Parse()
        txtPlayerX.text = Convert.ToString(plusone + 1); //viene preso il valore attuale di plusone, viene sommato 1 e il risultato viene convertito in una stringa utilizzando il metodo Convert.ToString(). Questa stringa risultante viene quindi assegnata di nuovo alla variabile txtPlayerX.text
        msgTurn.text = "";
        imageObject.SetActive(false);
        AllBtnToTrue();
        if (plusone + 1 == WinningScore)
        {
            HideGamePanel();
            txtWinner.text = "Player X won the game!";
            ShowVictoryPanel();
            btnNewGame_Click();
        }
    }

    public void WinnerO(Text btnTextA, Text btnTextB, Text btnTextC)
    {
        btnTextA.color = Color.red;
        btnTextB.color = Color.red;
        btnTextC.color = Color.red;
        msgFeedback.text = "The winner is Player O";
        plusone = int.Parse(txtPlayerO.text);
        txtPlayerO.text = Convert.ToString(plusone + 1); 
        msgTurn.text = "";
        imageObject.SetActive(false);
        AllBtnToTrue();
        if (plusone + 1 == WinningScore)
        {
            HideGamePanel();
            txtWinner.text = "Player O won the game!";
            ShowVictoryPanel();
            btnNewGame_Click();
        }
    }

    public void AllBtnToTrue()
    {
        btnWritten1 = true;
        btnWritten2 = true;
        btnWritten3 = true;
        btnWritten4 = true;
        btnWritten5 = true;
        btnWritten6 = true;
        btnWritten7 = true;
        btnWritten8 = true;
        btnWritten9 = true;
    }

    public void Score()
    {
        //========================== Draw =========================================
        if (btnWritten1 && btnWritten2 && btnWritten3 && btnWritten4 && btnWritten5 && btnWritten6 && btnWritten7 && btnWritten8 && btnWritten9)
        {
            Draw();
        }
        //========================== Players =========================================
        //Case 1: 1-2-3
        if (btnText1 != null && btnText1.text == btnText2.text && btnText2.text == btnText3.text)
        {
            if (btnText1.text == "X")
            {
                WinnerX(btnText1, btnText2, btnText3);
            }
            else if (btnText1.text == "O")
            {
                WinnerO(btnText1, btnText2, btnText3);
            }

        }
        //Case 2: 1-4-7
        if (btnText1 != null && btnText1.text == btnText4.text && btnText4.text == btnText7.text)
        {
            if (btnText1.text == "X")
            {
                WinnerX(btnText1, btnText4, btnText7);
            }
            else if (btnText1.text == "O")
            {
                WinnerO(btnText1, btnText4, btnText7);
            }
        }
        //Case 3: 1-5-9
        if (btnText1 != null && btnText1.text == btnText5.text && btnText5.text == btnText9.text)
        {
            if (btnText1.text == "X" && btnText5.text == "X" && btnText9.text == "X")
            {
                WinnerX(btnText1, btnText5, btnText9);
            }
            else if (btnText1.text == "O")
            {
                WinnerO(btnText1, btnText5, btnText9);
            }
        }
        //Case 4: 3-5-7
        if (btnText3 != null && btnText3.text == btnText5.text && btnText5.text == btnText7.text)
        {
            if (btnText3.text == "X")
            {
                WinnerX(btnText3, btnText5, btnText7);
            }
            else if (btnText3.text == "O")
            {
                WinnerO(btnText3, btnText5, btnText7);
            }
        }
        //Case 5: 2-5-8
        if (btnText2 != null && btnText2.text == btnText5.text && btnText5.text == btnText8.text)
        {
            if (btnText2.text == "X")
            {
                WinnerX(btnText2, btnText5, btnText8);
            }
            else if (btnText2.text == "O")
            {
                WinnerO(btnText2, btnText5, btnText8);
            }
        }
        //Case 6: 3-6-9
        if (btnText3 != null && btnText3.text == btnText6.text && btnText6.text == btnText9.text)
        {
            if (btnText3.text == "X")
            {
                WinnerX(btnText3, btnText6, btnText9);
            }
            else if (btnText3.text == "O")
            {
                WinnerO(btnText3, btnText6, btnText9);
            }
        }
        //Case 7: 4-5-6
        if (btnText4 != null && btnText4.text == btnText5.text && btnText5.text == btnText6.text)
        {
            if (btnText4.text == "X")
            {
                WinnerX(btnText4, btnText5, btnText6);
            }
            else if (btnText4.text == "O")
            {
                WinnerO(btnText4, btnText5, btnText6);
            }
        }
        //Case 8: 7-8-9
        if (btnText7 != null && btnText7.text == btnText8.text && btnText8.text == btnText9.text)
        {
            if (btnText7.text == "X")
            {
                WinnerX(btnText7, btnText8, btnText9);
            }
            else if (btnText7.text == "O")
            {
                WinnerO(btnText7, btnText8, btnText9);
            }
        }

    }

    public void btnText_Click(ref bool btnWritten, Text btnText)
    {
        if (btnWritten == false)
        {
            if (checker == false)
            {
                btnText.text = "X";
                checker = true;
                msgTurn.text = "O TURN";
            }
            else
            {
                btnText.text = "O";
                checker = false;
                msgTurn.text = "X TURN";
            }
            btnWritten = true;
            Score();
        }
    }

    public void btnText1_Click()
    {
        btnText_Click(ref btnWritten1, btnText1);
    }
    public void btnText2_Click()
    {
        btnText_Click(ref btnWritten2, btnText2);
    }
    public void btnText3_Click()
    {
        btnText_Click(ref btnWritten3, btnText3);
    }
    public void btnText4_Click()
    {
        btnText_Click(ref btnWritten4, btnText4);
    }
    public void btnText5_Click()
    {
        btnText_Click(ref btnWritten5, btnText5);
    }
    public void btnText6_Click()
    {
        btnText_Click(ref btnWritten6, btnText6);
    }
    public void btnText7_Click()
    {
        btnText_Click(ref btnWritten7, btnText7);
    }
    public void btnText8_Click()
    {
        btnText_Click(ref btnWritten8, btnText8);
    }
    public void btnText9_Click()
    {
        btnText_Click(ref btnWritten9, btnText9);
    }

    public void btnResetGame_Click()
    {
        btnText1.text = "";
        btnText2.text = "";
        btnText3.text = "";
        btnText4.text = "";
        btnText5.text = "";
        btnText6.text = "";
        btnText7.text = "";
        btnText8.text = "";
        btnText9.text = "";

        msgFeedback.text = "";
        msgTurn.text = "X TURN";
        imageObject.SetActive(true);

        checker = false;
        btnWritten1 = false;
        btnWritten2 = false;
        btnWritten3 = false;
        btnWritten4 = false;
        btnWritten5 = false;
        btnWritten6 = false;
        btnWritten7 = false;
        btnWritten8 = false;
        btnWritten9 = false;

        btnText1.color = Color.black;
        btnText2.color = Color.black;
        btnText3.color = Color.black;
        btnText4.color = Color.black;
        btnText5.color = Color.black;
        btnText6.color = Color.black;
        btnText7.color = Color.black;
        btnText8.color = Color.black;
        btnText9.color = Color.black;
    }


    public void btnNewGame_Click()
    {
        btnResetGame_Click();
        txtPlayerX.text = "0";
        txtPlayerO.text = "0";

    }




}
