using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class GameManager : MonoBehaviour
{
    public UnityEvent mouseDown;
    public TextMeshProUGUI textMeshProUGUI;

    public float lastClick = 0;

    void Start()
    {
        lastClick = Time.time;
    }

    public void ClickedMonkey()
    {
        textMeshProUGUI.text = "Oh, god. No. What have you done?";
        textMeshProUGUI.color = Color.red;
    }
}
