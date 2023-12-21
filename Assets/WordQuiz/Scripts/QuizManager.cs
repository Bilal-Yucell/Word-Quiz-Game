using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public static QuizManager instance;

    // [SerializeField] private GameObject gameComplete;
    //Scriptable data which store our questions data
    // [SerializeField] private QuizDataScriptable questionDataScriptable;
    // [SerializeField] private Image questionImage;           //image element to show the image

    [SerializeField] private WordData[] answerWordList;     //list of answers word in the game
    [SerializeField] private WordData[] optionsWordList;    //list of options word in the game



    void Start()
    {
        
    }

    void Update()
    {
        
    }

    [System.Serializable]
    public class QuestionData
    {
        public Sprite questionImage;
        public string answer;
    }

}
