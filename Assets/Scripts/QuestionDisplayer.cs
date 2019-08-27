using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    class QuestionDisplayer : MonoBehaviour
    {
        public static QuestionDisplayer instance;

        public Button OptionBtn1;
        public Button OptionBtn2;
        public Button OptionBtn3;

        public GameObject questionBackground;
        public GameObject questionPanel;
        public GameObject panel;
        public GameObject correctPanel;
        public GameObject inCorrectPanel;
        public GameObject correctTtext;
        public Text question;
        public GameObject questionHeader;

        public void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        public void Start()
        {
            
        }
    }
}
