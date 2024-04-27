using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private int score;
    private ScriptUI scriptUI;

    // Start is called before the first frame update
    void Start()
    {
        scriptUI = FindObjectOfType<ScriptUI>();
    }

    public int Score { get { return score; }  }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int amount)
    {
        score += amount;
        scriptUI.UpdateUI();
    }
}
