using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScriptUI : MonoBehaviour
{
    public TMP_Text scoreText;
    private ScoreSystem scoreSystem;

    // Start is called before the first frame update
    void Start()
    {
        scoreSystem = FindObjectOfType<ScoreSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        scoreText.text = "" + scoreSystem.Score;
    }
}
