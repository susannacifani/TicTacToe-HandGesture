using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CursorManager : MonoBehaviour

{

    public GameObject gamePanel;
    public Text msgTurnValue;

    public Texture2D yellowCursor;
    public Texture2D greenCursor;
    public Texture2D blueCursor;

    void Start()
    {
        Cursor.SetCursor(greenCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    void Update()
    {
        if (gamePanel.activeInHierarchy)
        {
            if (msgTurnValue.text == "X TURN")
            {
                Cursor.SetCursor(yellowCursor, Vector2.zero, CursorMode.ForceSoftware);
            }
            else if (msgTurnValue.text == "O TURN")
            {
                Cursor.SetCursor(blueCursor, Vector2.zero, CursorMode.ForceSoftware);
            }
            
        }
        else
        {
            Cursor.SetCursor(greenCursor, Vector2.zero, CursorMode.ForceSoftware);
        }
    }


}
