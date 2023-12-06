using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(TextMeshProUGUI))]

public class ScoreText : MonoBehaviour
{
    [SerializeField]
    string scoreHeader = "SCORE:";
    [SerializeField]
    string scoreFomat = "D5";
    private float _score = 0;
    public float Score
    {
        set {
            if (_score != value)
            {
                _score = value;
                UpdateValue();
            }
        }
        get
        {
            return _score;
        }
    }
    private TextMeshProUGUI uiText;
    private void Awake()
    {
        uiText = GetComponent<TextMeshProUGUI>();
        UpdateValue();
    }
    private void UpdateValue()
    {
        uiText.text = $"{scoreHeader}{_score.ToString(scoreFomat)}";
    }
}
