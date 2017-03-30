//using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Answer_Data {
    public string question;
    public string answer;
}
[System.Serializable]
public class Bool_Data {
    public bool iLoveIt;
    public bool iLikeIt;
    public bool itOkay;
    public bool iDislikeIt;
    public bool iHateIt;
}
[System.Serializable]
public class Bool_Data2 {
    public bool one;
    public bool two;
    public bool three;
    public bool four;
    public bool five;
    public bool six;
    public bool seven;
}
public class GUI_Manager : MonoBehaviour {
    public static GUI_Manager instance;
    public bool test;
    public bool test2;
    public enum PageState {
        Form, RegulatoryQuestions1, RegulatoryQuestions2, RegulatoryQuestions3,
        MoralExplanation1,
        PreMoralQuestion1, PreMoralQuestion2, PreMoralQuestion3, PreMoralQuestion4, 
        MoralExplanation2,
        Priming,
        MoralExplanation3,
        PostMoralQuestion1, PostMoralQuestion2, PostMoralQuestion3, PostMoralQuestion4, 
        HexPart1, HexPart2_1, HexPart2_2, HexPart2_3, HexPart3,
        Thanks //PostRgulatoryQuestions,
    }
    PageState currentPageState;
    //
    float boxWidth;
    float boxHeight;
    bool checkClose;
    bool checkWrite;
    //hex1
    string yearOfBirth = "";
    string brainHex = "";
    bool male;
    bool female;
    bool everyDay;
    bool everyWeek;
    bool occasionally;
    bool rarely;
    bool never;
    bool hardCore;
    bool between;
    bool casual;
    bool noIdea;
    bool singleAlone;
    bool singlePassing;
    bool localMultiplayer;
    bool onlineMultiplayer;
    bool teamPlay;
    bool mmorpg;
    bool important;
    bool helpEnjoy;
    bool notImportant;
    bool noStory;
    bool dontPlay;
    //pre-regulatory
    Bool_Data preRegulatoryList1 = new Bool_Data();
    Bool_Data preRegulatoryList2 = new Bool_Data();
    Bool_Data preRegulatoryList3 = new Bool_Data();
    Bool_Data preRegulatoryList4 = new Bool_Data();
    Bool_Data preRegulatoryList5 = new Bool_Data();
    Bool_Data preRegulatoryList6 = new Bool_Data();
    Bool_Data preRegulatoryList7 = new Bool_Data();
    Bool_Data preRegulatoryList8 = new Bool_Data();
    Bool_Data preRegulatoryList9 = new Bool_Data();
    Bool_Data preRegulatoryList10 = new Bool_Data();
    Bool_Data preRegulatoryList11 = new Bool_Data();
    Bool_Data preRegulatoryList12 = new Bool_Data();
    Bool_Data preRegulatoryList13 = new Bool_Data();
    Bool_Data preRegulatoryList14 = new Bool_Data();
    Bool_Data preRegulatoryList15 = new Bool_Data();
    Bool_Data preRegulatoryList16 = new Bool_Data();
    Bool_Data preRegulatoryList17 = new Bool_Data();
    Bool_Data preRegulatoryList18 = new Bool_Data();
    //hex2
    Bool_Data part2AnswerList1 = new Bool_Data();
    Bool_Data part2AnswerList2 = new Bool_Data();
    Bool_Data part2AnswerList3 = new Bool_Data();
    Bool_Data part2AnswerList4 = new Bool_Data();
    Bool_Data part2AnswerList5 = new Bool_Data();
    Bool_Data part2AnswerList6 = new Bool_Data();
    Bool_Data part2AnswerList7 = new Bool_Data();
    Bool_Data part2AnswerList8 = new Bool_Data();
    Bool_Data part2AnswerList9 = new Bool_Data();
    Bool_Data part2AnswerList10 = new Bool_Data();
    Bool_Data part2AnswerList11 = new Bool_Data();
    Bool_Data part2AnswerList12 = new Bool_Data();
    Bool_Data part2AnswerList13 = new Bool_Data();
    Bool_Data part2AnswerList14 = new Bool_Data();
    Bool_Data part2AnswerList15 = new Bool_Data();
    Bool_Data part2AnswerList16 = new Bool_Data();
    Bool_Data part2AnswerList17 = new Bool_Data();
    Bool_Data part2AnswerList18 = new Bool_Data();
    Bool_Data part2AnswerList19 = new Bool_Data();
    Bool_Data part2AnswerList20 = new Bool_Data();
    Bool_Data part2AnswerList21 = new Bool_Data();
    //hex3
    Bool_Data2 part3AnswerList1 = new Bool_Data2();
    Bool_Data2 part3AnswerList2 = new Bool_Data2();
    Bool_Data2 part3AnswerList3 = new Bool_Data2();
    Bool_Data2 part3AnswerList4 = new Bool_Data2();
    Bool_Data2 part3AnswerList5 = new Bool_Data2();
    Bool_Data2 part3AnswerList6 = new Bool_Data2();
    Bool_Data2 part3AnswerList7 = new Bool_Data2();
    //moral questions
    int currentPrimingID;
    int currentQuestionID;
    Answer_Data moralQuestion1 = new Answer_Data();
    Answer_Data moralQuestion2 = new Answer_Data();
    Answer_Data moralQuestion3 = new Answer_Data();
    Answer_Data moralQuestion4 = new Answer_Data();
    Answer_Data moralQuestion5 = new Answer_Data();
    Answer_Data moralQuestion6 = new Answer_Data();
    Answer_Data moralQuestion7 = new Answer_Data();
    Answer_Data moralQuestion8 = new Answer_Data();
    //
    void Awake() {
        instance = this;
        boxWidth = Screen.width - (Screen.width / 11) * 2;
        boxHeight = Screen.height - (Screen.height / 11) * 2;
    }
    void OnGUI() {
        //
        float boxWidth = Screen.width - (Screen.width / 11) * 2;
        float boxHeight = Screen.height - (Screen.height / 11) * 2;
        currentPrimingID = Mathf.Clamp(currentPrimingID, 0, 1);
        currentQuestionID = Mathf.Clamp(currentPrimingID, 0, 11);
        GUILayout.BeginArea(new Rect(Screen.width / 11, Screen.height / 11, boxWidth, boxHeight));
        switch (currentPageState) {
            case PageState.Form:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight- boxHeight/10), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, boxHeight - boxHeight / 10, boxWidth, boxHeight / 10), "");
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, Screen.height / 15), GUI_Text.instance.ethicsList[0]);
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 10, boxWidth - Screen.width / 11.5f, boxHeight - Screen.height / 23), GUI_Text.instance.ethicsList[1]);
                if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Agree")) {
                    GUI_Text.instance.CreateFile();
                    GUI_Text.instance.Agreed();
                    currentPageState = PageState.HexPart1;
                }
                if (GUI.Button(new Rect(boxWidth / 2, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Don't Agree")) {
                    currentPageState = PageState.Thanks;
                }
                break;
            case PageState.RegulatoryQuestions1:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, Screen.height / 15), GUI_Text.instance.regulatoryList[0]);
                PreRegulatoryQuestions(preRegulatoryList1, 1, GUI_Text.instance.regulatoryList[1]);
                PreRegulatoryQuestions(preRegulatoryList2, 3, GUI_Text.instance.regulatoryList[2]);
                PreRegulatoryQuestions(preRegulatoryList3, 5, GUI_Text.instance.regulatoryList[3]);
                PreRegulatoryQuestions(preRegulatoryList4, 7, GUI_Text.instance.regulatoryList[4]);
                PreRegulatoryQuestions(preRegulatoryList5, 9, GUI_Text.instance.regulatoryList[5]);
                PreRegulatoryQuestions(preRegulatoryList6, 11, GUI_Text.instance.regulatoryList[6]);
                PreRegulatoryQuestions(preRegulatoryList7, 13, GUI_Text.instance.regulatoryList[7]);
                if (GUI.Button(new Rect(boxWidth / 2, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Continue")) {
                    currentPageState = PageState.RegulatoryQuestions2;
                }
                if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Back")) {
                    currentPageState = PageState.HexPart1;
                }
                break;
            case PageState.RegulatoryQuestions2:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, Screen.height / 15), GUI_Text.instance.regulatoryList[0]);
                PreRegulatoryQuestions(preRegulatoryList8, 1, GUI_Text.instance.regulatoryList[8]);
                PreRegulatoryQuestions(preRegulatoryList9, 3, GUI_Text.instance.regulatoryList[9]);
                PreRegulatoryQuestions(preRegulatoryList10, 5, GUI_Text.instance.regulatoryList[10]);
                PreRegulatoryQuestions(preRegulatoryList11, 7, GUI_Text.instance.regulatoryList[11]);
                PreRegulatoryQuestions(preRegulatoryList12, 9, GUI_Text.instance.regulatoryList[12]);
                PreRegulatoryQuestions(preRegulatoryList13, 11, GUI_Text.instance.regulatoryList[13]);
                PreRegulatoryQuestions(preRegulatoryList14, 13, GUI_Text.instance.regulatoryList[14]);
                if (GUI.Button(new Rect(boxWidth / 2, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Continue")) {
                    currentPageState = PageState.RegulatoryQuestions3;
                }
                if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Back")) {
                    currentPageState = PageState.RegulatoryQuestions1;
                }
                break;
            case PageState.RegulatoryQuestions3:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, Screen.height / 15), GUI_Text.instance.regulatoryList[0]);
                PreRegulatoryQuestions(preRegulatoryList15, 1, GUI_Text.instance.regulatoryList[15]);
                PreRegulatoryQuestions(preRegulatoryList16, 3, GUI_Text.instance.regulatoryList[16]);
                PreRegulatoryQuestions(preRegulatoryList17, 5, GUI_Text.instance.regulatoryList[17]);
                PreRegulatoryQuestions(preRegulatoryList18, 7, GUI_Text.instance.regulatoryList[18]);
                if (GUI.Button(new Rect(boxWidth / 2, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Continue")) {
                    currentPageState = PageState.MoralExplanation1;
                }
                if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Back")) {
                    currentPageState = PageState.RegulatoryQuestions2;
                }
                break;
            case PageState.MoralExplanation1:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, Screen.height / 15), GUI_Text.instance.ethicsList[2]);
                if (GUI.Button(new Rect(boxWidth / 2, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Continue")) {
                    currentPageState = PageState.PreMoralQuestion1;
                }
                if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Back")) {
                    currentPageState = PageState.RegulatoryQuestions3;
                }
                break;
            case PageState.PreMoralQuestion1:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                //
                moralQuestion1.question = GUI_Text.instance.questionsList[1]; //string from list  GUI_Text.instance.HexPage1List[0]
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, boxHeight - Screen.height / 25), moralQuestion1.question);//get question list
                if (GUI.Button(new Rect(boxWidth / 3, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), GUI_Text.instance.questionsList[2])) {
                    moralQuestion1.answer = GUI_Text.instance.questionsList[2]; //string from list
                    currentPageState = PageState.PreMoralQuestion2;
                }
                if (GUI.Button(new Rect(boxWidth / 3 * 2, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), GUI_Text.instance.questionsList[3])) {
                    moralQuestion1.answer = GUI_Text.instance.questionsList[3]; //string from list
                    currentPageState = PageState.PreMoralQuestion2;
                }
                if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), "Back")) {
                    currentPageState = PageState.RegulatoryQuestions3;
                }
                break;
            case PageState.PreMoralQuestion2:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                //
                moralQuestion2.question = GUI_Text.instance.questionsList[4]; //string from list  GUI_Text.instance.HexPage1List[0]
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, boxHeight - Screen.height / 25), moralQuestion2.question);//get question list
                if (GUI.Button(new Rect(boxWidth / 3, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), GUI_Text.instance.questionsList[5])) {
                    moralQuestion2.answer = GUI_Text.instance.questionsList[5]; //string from list
                    currentPageState = PageState.PreMoralQuestion3;
                }
                if (GUI.Button(new Rect(boxWidth / 3 * 2, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), GUI_Text.instance.questionsList[6])) {
                    moralQuestion2.answer = GUI_Text.instance.questionsList[6]; //string from list
                    currentPageState = PageState.PreMoralQuestion3;
                }
                if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), "Back")) {
                    currentPageState = PageState.PreMoralQuestion1;
                }
                break;
            case PageState.PreMoralQuestion3:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                //
                moralQuestion3.question = GUI_Text.instance.questionsList[7]; //string from list  GUI_Text.instance.HexPage1List[0]
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, boxHeight - Screen.height / 25), moralQuestion3.question);//get question list
                if (GUI.Button(new Rect(boxWidth / 3, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), GUI_Text.instance.questionsList[8])) {
                    moralQuestion3.answer = GUI_Text.instance.questionsList[8]; //string from list
                    currentPageState = PageState.PreMoralQuestion4;
                }
                if (GUI.Button(new Rect(boxWidth / 3 * 2, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), GUI_Text.instance.questionsList[9])) {
                    moralQuestion3.answer = GUI_Text.instance.questionsList[9]; //string from list
                    currentPageState = PageState.PreMoralQuestion4;
                }
                if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), "Back")) {
                    currentPageState = PageState.PreMoralQuestion2;
                }
                break;
            case PageState.PreMoralQuestion4:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                //
                moralQuestion4.question = GUI_Text.instance.questionsList[10]; //string from list  GUI_Text.instance.HexPage1List[0]
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, boxHeight - Screen.height / 25), moralQuestion4.question);//get question list
                if (GUI.Button(new Rect(boxWidth / 3, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), GUI_Text.instance.questionsList[11])) {
                    moralQuestion4.answer = GUI_Text.instance.questionsList[11]; //string from list
                    currentPageState = PageState.MoralExplanation2;
                }
                if (GUI.Button(new Rect(boxWidth / 3 * 2, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), GUI_Text.instance.questionsList[12])) {
                    moralQuestion4.answer = GUI_Text.instance.questionsList[12]; //string from list
                    currentPageState = PageState.MoralExplanation2;
                }
                if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), "Back")) {
                    currentPageState = PageState.PreMoralQuestion3;
                }
                break;
            case PageState.MoralExplanation2:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, Screen.height / 15), GUI_Text.instance.ethicsList[3]);
                if (GUI.Button(new Rect(boxWidth / 2, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Continue")) {
                    currentPageState = PageState.Priming;
                }
                if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Back")) {
                    currentPageState = PageState.PreMoralQuestion4;
                }
                break;
            case PageState.Priming:
                bool primeAnswer = false;
                switch (currentPrimingID) {
                    case 0:
                        GUI.Box(new Rect(0, 0, boxWidth, boxHeight - boxHeight / 10), "");
                        GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                        GUI.Box(new Rect(0, boxHeight - boxHeight / 10, boxWidth, boxHeight / 5), "");
                        //GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, Screen.height / 15), GUI_Text.instance.primingList[1]);//---------
                        GUI.Label(new Rect(Screen.width / 23, Screen.height / 10, boxWidth - Screen.width / 11.5f, boxHeight - Screen.height / 25), GUI_Text.instance.primingList[2]);
                        if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Use Explosive Spell")) {
                            primeAnswer = true;
                            currentPrimingID += 1;
                        }
                        if (GUI.Button(new Rect(boxWidth / 2, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Use multiple Spells")) {
                            primeAnswer = false;
                            currentPrimingID += 1;
                        }
                        break;
                    case 1:
                        GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                        GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                        //GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, Screen.height / 15), GUI_Text.instance.primingList[1]);//-------
                        if (primeAnswer) {
                            GUI.Label(new Rect(Screen.width / 23, Screen.height / 10, boxWidth - Screen.width / 11.5f, boxHeight - Screen.height / 25), GUI_Text.instance.primingList[2]);
                            if (GUI.Button(new Rect(boxWidth / 2, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Continue")) {
                                currentPageState = PageState.MoralExplanation3;
                            }
                        } else {
                            GUI.Label(new Rect(Screen.width / 23, Screen.height / 10, boxWidth - Screen.width / 11.5f, boxHeight - Screen.height / 25), GUI_Text.instance.primingList[3]);
                            if (GUI.Button(new Rect(boxWidth / 2, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Continue")) {
                                currentPageState = PageState.MoralExplanation3;
                            }
                        }
                        break;
                    default:
                        currentPrimingID = 0;
                        break;
                }
                break;
            case PageState.MoralExplanation3:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, Screen.height / 15), GUI_Text.instance.ethicsList[2]);
                if (GUI.Button(new Rect(boxWidth / 2, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Continue")) {
                    currentPageState = PageState.PostMoralQuestion1;
                }
                break;
            case PageState.PostMoralQuestion1:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                //
                moralQuestion5.question = GUI_Text.instance.questionsList[13]; //string from list  GUI_Text.instance.HexPage1List[0]
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, boxHeight - Screen.height / 25), moralQuestion5.question);//get question list
                if (GUI.Button(new Rect(boxWidth / 3, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), GUI_Text.instance.questionsList[14])) {
                    moralQuestion5.answer = GUI_Text.instance.questionsList[14]; //string from list
                    currentPageState = PageState.PostMoralQuestion2;
                }
                if (GUI.Button(new Rect(boxWidth / 3 * 2, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), GUI_Text.instance.questionsList[15])) {
                    moralQuestion5.answer = GUI_Text.instance.questionsList[15]; //string from list
                    currentPageState = PageState.PostMoralQuestion2;
                }
                break;
            case PageState.PostMoralQuestion2:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                //
                moralQuestion6.question = GUI_Text.instance.questionsList[16]; //string from list  GUI_Text.instance.HexPage1List[0]
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, boxHeight - Screen.height / 25), moralQuestion6.question);//get question list
                if (GUI.Button(new Rect(boxWidth / 3, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), GUI_Text.instance.questionsList[17])) {
                    moralQuestion6.answer = GUI_Text.instance.questionsList[17]; //string from list
                    currentPageState = PageState.PostMoralQuestion3;
                }
                if (GUI.Button(new Rect(boxWidth / 3 * 2, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), GUI_Text.instance.questionsList[18])) {
                    moralQuestion6.answer = GUI_Text.instance.questionsList[18]; //string from list
                    currentPageState = PageState.PostMoralQuestion3;
                }
                if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), "Back")) {
                    currentPageState = PageState.PostMoralQuestion1;
                }
                break;
            case PageState.PostMoralQuestion3:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                //
                moralQuestion7.question = GUI_Text.instance.questionsList[19]; //string from list  GUI_Text.instance.HexPage1List[0]
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, boxHeight - Screen.height / 25), moralQuestion7.question);//get question list
                if (GUI.Button(new Rect(boxWidth / 3, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), GUI_Text.instance.questionsList[20])) {
                    moralQuestion7.answer = GUI_Text.instance.questionsList[20]; //string from list
                    currentPageState = PageState.PostMoralQuestion4;
                }
                if (GUI.Button(new Rect(boxWidth / 3 * 2, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), GUI_Text.instance.questionsList[21])) {
                    moralQuestion7.answer = GUI_Text.instance.questionsList[21]; //string from list
                    currentPageState = PageState.PostMoralQuestion4;
                }
                if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), "Back")) {
                    currentPageState = PageState.PostMoralQuestion2;
                }
                break;
            case PageState.PostMoralQuestion4:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                //
                moralQuestion8.question = GUI_Text.instance.questionsList[22]; //string from list  GUI_Text.instance.HexPage1List[0]
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, boxHeight - Screen.height / 25), moralQuestion8.question);//get question list
                if (GUI.Button(new Rect(boxWidth / 3, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), GUI_Text.instance.questionsList[23])) {
                    moralQuestion8.answer = GUI_Text.instance.questionsList[23]; //string from list
                    currentPageState = PageState.HexPart2_1;
                }
                if (GUI.Button(new Rect(boxWidth / 3 * 2, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), GUI_Text.instance.questionsList[24])) {
                    moralQuestion8.answer = GUI_Text.instance.questionsList[24]; //string from list
                    currentPageState = PageState.HexPart2_1;
                }
                if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), "Back")) {
                    currentPageState = PageState.PostMoralQuestion3;
                }
                break;
            case PageState.HexPart1:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, Screen.height / 15), GUI_Text.instance.HexPage1List[0]);//---------------
                //GUI.Label(new Rect(Screen.width / 23, Screen.height / 10, Screen.width / 3, Screen.height / 27), GUI_Text.instance.questionnaireList[1]);
                //if (GUI.Button(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30, Screen.width / 3, Screen.height / 27), GUI_Text.instance.questionnaireList[2])) {
                //    Application.OpenURL(GUI_Text.instance.questionnaireList[2]);
                //}
                //GUI.Label(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 2, Screen.width / 3, Screen.height / 40), GUI_Text.instance.questionnaireList[3]);
                //brainHex = GUI.TextField(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 3, Screen.width / 5, Screen.height / 27), brainHex, 25);
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 10, Screen.width / 3, Screen.height / 27), GUI_Text.instance.HexPage1List[4]);
                if (GUI.Toggle(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30, Screen.width / 10, Screen.height / 27), male, GUI_Text.instance.HexPage1List[5])) {
                    male = true; female = false;
                }
                if (GUI.Toggle(new Rect(Screen.width / 23 + Screen.width / 10, Screen.height / 10 + Screen.height / 30, Screen.width / 10, Screen.height / 27), female, GUI_Text.instance.HexPage1List[6])) {
                    male = false; female = true;
                }
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 2, Screen.width / 3, Screen.height / 27), GUI_Text.instance.HexPage1List[7]);
                yearOfBirth = GUI.TextField(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 3, Screen.width / 5, Screen.height / 27), yearOfBirth, 25);
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 4, Screen.width / 3, Screen.height / 27), GUI_Text.instance.HexPage1List[8]);
                if (GUI.Toggle(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 5, Screen.width / 3, Screen.height / 27), everyDay, GUI_Text.instance.HexPage1List[9])) {
                    everyDay = true; everyWeek = false; occasionally = false; rarely = false; never = false;
                }
                if (GUI.Toggle(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 6, Screen.width / 3, Screen.height / 27), everyWeek, GUI_Text.instance.HexPage1List[10])) {
                    everyDay = false; everyWeek = true; occasionally = false; rarely = false; never = false;
                }
                if (GUI.Toggle(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 7, Screen.width / 3, Screen.height / 27), occasionally, GUI_Text.instance.HexPage1List[11])) {
                    everyDay = false; everyWeek = false; occasionally = true; rarely = false; never = false;
                }
                if (GUI.Toggle(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 8, Screen.width / 3, Screen.height / 27), rarely, GUI_Text.instance.HexPage1List[12])) {
                    everyDay = false; everyWeek = false; occasionally = false; rarely = true; never = false;
                }
                if (GUI.Toggle(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 9, Screen.width / 3, Screen.height / 27), never, GUI_Text.instance.HexPage1List[13])) {
                    everyDay = false; everyWeek = false; occasionally = false; rarely = false; never = true;
                }
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 10, Screen.width / 2, Screen.height / 27), GUI_Text.instance.HexPage1List[14]);
                if (GUI.Toggle(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 11, Screen.width / 3, Screen.height / 27), hardCore, GUI_Text.instance.HexPage1List[15])) {
                    hardCore = true; between = false; casual = false; noIdea = false;
                }
                if (GUI.Toggle(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 12, Screen.width / 3, Screen.height / 27), between, GUI_Text.instance.HexPage1List[16])) {
                    hardCore = false; between = true; casual = false; noIdea = false;
                }
                if (GUI.Toggle(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 13, Screen.width / 3, Screen.height / 27), casual, GUI_Text.instance.HexPage1List[17])) {
                    hardCore = false; between = false; casual = true; noIdea = false;
                }
                if (GUI.Toggle(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 14, Screen.width / 3, Screen.height / 27), noIdea, GUI_Text.instance.HexPage1List[18])) {
                    hardCore = false; between = false; casual = false; noIdea = true;
                }
                GUI.Label(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10, Screen.width / 3, Screen.height / 27), GUI_Text.instance.HexPage1List[19]);
                if (GUI.Toggle(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30, Screen.width / 3, Screen.height / 27), singleAlone, GUI_Text.instance.HexPage1List[20])) {
                    singleAlone = true; singlePassing = false; localMultiplayer = false; onlineMultiplayer = false; teamPlay = false; mmorpg = false;
                }
                if (GUI.Toggle(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30 * 2, Screen.width / 3, Screen.height / 27), singlePassing, GUI_Text.instance.HexPage1List[21])) {
                    singleAlone = false; singlePassing = true; localMultiplayer = false; onlineMultiplayer = false; teamPlay = false; mmorpg = false;
                }
                if (GUI.Toggle(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30 * 3, Screen.width / 3, Screen.height / 27), localMultiplayer, GUI_Text.instance.HexPage1List[22])) {
                    singleAlone = false; singlePassing = false; localMultiplayer = true; onlineMultiplayer = false; teamPlay = false; mmorpg = false;
                }
                if (GUI.Toggle(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30 * 4, Screen.width / 3, Screen.height / 27), onlineMultiplayer, GUI_Text.instance.HexPage1List[23])) {
                    singleAlone = false; singlePassing = false; localMultiplayer = false; onlineMultiplayer = true; teamPlay = false; mmorpg = false;
                }
                if (GUI.Toggle(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30 * 5, Screen.width / 3, Screen.height / 27), teamPlay, GUI_Text.instance.HexPage1List[24])) {
                    singleAlone = false; singlePassing = false; localMultiplayer = false; onlineMultiplayer = false; teamPlay = true; mmorpg = false;
                }
                if (GUI.Toggle(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30 * 6, Screen.width / 3, Screen.height / 27), mmorpg, GUI_Text.instance.HexPage1List[25])) {
                    singleAlone = false; singlePassing = false; localMultiplayer = false; onlineMultiplayer = false; teamPlay = false; mmorpg = true;
                }
                GUI.Label(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30 * 7, Screen.width / 3, Screen.height / 27), GUI_Text.instance.HexPage1List[26]);
                if (GUI.Toggle(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30 * 8, Screen.width / 3, Screen.height / 27), important, GUI_Text.instance.HexPage1List[27])) {
                    important = true; helpEnjoy = false; notImportant = false; noStory = false; dontPlay = false;
                }
                if (GUI.Toggle(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30 * 9, Screen.width / 3, Screen.height / 27), helpEnjoy, GUI_Text.instance.HexPage1List[28])) {
                    important = false; helpEnjoy = true; notImportant = false; noStory = false; dontPlay = false;
                }
                if (GUI.Toggle(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30 * 10, Screen.width / 3, Screen.height / 27), notImportant, GUI_Text.instance.HexPage1List[29])) {
                    important = false; helpEnjoy = false; notImportant = true; noStory = false; dontPlay = false;
                }
                if (GUI.Toggle(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30 * 11, Screen.width / 3, Screen.height / 27), noStory, GUI_Text.instance.HexPage1List[30])) {
                    important = false; helpEnjoy = false; notImportant = false; noStory = true; dontPlay = false;
                }
                if (GUI.Toggle(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30 * 12, Screen.width / 3, Screen.height / 27), dontPlay, GUI_Text.instance.HexPage1List[31])) {
                    important = false; helpEnjoy = false; notImportant = false; noStory = false; dontPlay = true;
                }
                if (GUI.Button(new Rect(boxWidth / 2, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Continue")) {
                    currentPageState = PageState.RegulatoryQuestions1;
                }
                break;
            case PageState.HexPart2_1:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, Screen.height / 15), GUI_Text.instance.HexPage2List[0]);//---------------
                Part2Questions(part2AnswerList1, 1, GUI_Text.instance.HexPage2List[1]);
                Part2Questions(part2AnswerList2, 3, GUI_Text.instance.HexPage2List[2]);
                Part2Questions(part2AnswerList3, 5, GUI_Text.instance.HexPage2List[3]);
                Part2Questions(part2AnswerList4, 7, GUI_Text.instance.HexPage2List[4]);
                Part2Questions(part2AnswerList5, 9, GUI_Text.instance.HexPage2List[5]);
                Part2Questions(part2AnswerList6, 11, GUI_Text.instance.HexPage2List[6]);
                Part2Questions(part2AnswerList7, 13, GUI_Text.instance.HexPage2List[7]);
                if (GUI.Button(new Rect(boxWidth / 2, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Continue")) {
                    currentPageState = PageState.HexPart2_2;
                }
                if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Back")) {
                    currentPageState = PageState.PostMoralQuestion4;
                }
                break;
            case PageState.HexPart2_2:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, Screen.height / 15), GUI_Text.instance.HexPage2List[0]);//---------------
                Part2Questions(part2AnswerList8, 1, GUI_Text.instance.HexPage2List[8]);
                Part2Questions(part2AnswerList9, 3, GUI_Text.instance.HexPage2List[9]);
                Part2Questions(part2AnswerList10, 5, GUI_Text.instance.HexPage2List[10]);
                Part2Questions(part2AnswerList11, 7, GUI_Text.instance.HexPage2List[11]);
                Part2Questions(part2AnswerList12, 9, GUI_Text.instance.HexPage2List[12]);
                Part2Questions(part2AnswerList13, 11, GUI_Text.instance.HexPage2List[13]);
                Part2Questions(part2AnswerList14, 13, GUI_Text.instance.HexPage2List[14]);
                if (GUI.Button(new Rect(boxWidth / 2, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Continue")) {
                    currentPageState = PageState.HexPart2_3;
                }
                if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Back")) {
                    currentPageState = PageState.HexPart2_1;
                }
                break;
            case PageState.HexPart2_3:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, Screen.height / 15), GUI_Text.instance.HexPage2List[0]);//---------------
                Part2Questions(part2AnswerList15, 1, GUI_Text.instance.HexPage2List[15]);
                Part2Questions(part2AnswerList16, 3, GUI_Text.instance.HexPage2List[16]);
                Part2Questions(part2AnswerList17, 5, GUI_Text.instance.HexPage2List[17]);
                Part2Questions(part2AnswerList18, 7, GUI_Text.instance.HexPage2List[18]);
                Part2Questions(part2AnswerList19, 9, GUI_Text.instance.HexPage2List[19]);
                Part2Questions(part2AnswerList20, 11, GUI_Text.instance.HexPage2List[20]);
                Part2Questions(part2AnswerList21, 13, GUI_Text.instance.HexPage2List[21]);
                if (GUI.Button(new Rect(boxWidth / 2, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Continue")) {
                    currentPageState = PageState.HexPart3;
                }
                if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Back")) {
                    currentPageState = PageState.HexPart2_2;
                }
                break;
            case PageState.HexPart3:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, Screen.height / 15), GUI_Text.instance.HexPage3List[0]);
                Part3Questions(part3AnswerList1, part3AnswerList2, part3AnswerList3, part3AnswerList4, part3AnswerList5, part3AnswerList6, part3AnswerList7, 1, GUI_Text.instance.HexPage2List[1]);
                Part3Questions(part3AnswerList2, part3AnswerList1, part3AnswerList3, part3AnswerList4, part3AnswerList5, part3AnswerList6, part3AnswerList7, 3, GUI_Text.instance.HexPage2List[2]);
                Part3Questions(part3AnswerList3, part3AnswerList2, part3AnswerList1, part3AnswerList4, part3AnswerList5, part3AnswerList6, part3AnswerList7, 5, GUI_Text.instance.HexPage2List[3]);
                Part3Questions(part3AnswerList4, part3AnswerList2, part3AnswerList3, part3AnswerList1, part3AnswerList5, part3AnswerList6, part3AnswerList7, 7, GUI_Text.instance.HexPage2List[4]);
                Part3Questions(part3AnswerList5, part3AnswerList2, part3AnswerList3, part3AnswerList4, part3AnswerList1, part3AnswerList6, part3AnswerList7, 9, GUI_Text.instance.HexPage2List[5]);
                Part3Questions(part3AnswerList6, part3AnswerList2, part3AnswerList3, part3AnswerList4, part3AnswerList5, part3AnswerList1, part3AnswerList7, 11, GUI_Text.instance.HexPage2List[6]);
                Part3Questions(part3AnswerList7, part3AnswerList2, part3AnswerList3, part3AnswerList4, part3AnswerList5, part3AnswerList6, part3AnswerList1, 13, GUI_Text.instance.HexPage2List[7]);
                if (GUI.Button(new Rect(boxWidth / 2, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Continue")) {
                    currentPageState = PageState.Thanks;
                }
                if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Back")) {
                    currentPageState = PageState.HexPart2_3;
                }
                break;
            case PageState.Thanks:
                if (checkWrite == false) {
                    SendHexPage1();
                    SendPreRgulatory(preRegulatoryList1, 1, preRegulatoryList2, 2, preRegulatoryList3, 3, preRegulatoryList4, 4, preRegulatoryList5, 5, preRegulatoryList6, 6, preRegulatoryList7, 7, preRegulatoryList8, 8,
                        preRegulatoryList9, 9, preRegulatoryList10, 10, preRegulatoryList11, 11, preRegulatoryList12, 12, preRegulatoryList13, 13, preRegulatoryList14, 14, preRegulatoryList15, 15, preRegulatoryList16, 16,
                        preRegulatoryList17, 17, preRegulatoryList18, 18);
                    SendPreMoralQuestions(moralQuestion1, moralQuestion2, moralQuestion3, moralQuestion4);
                    SendPostMoralQuestions(moralQuestion5, moralQuestion6, moralQuestion7, moralQuestion8);
                    SendHexPage21(part2AnswerList1, 1, part2AnswerList2, 2, part2AnswerList3, 3, part2AnswerList4, 4, part2AnswerList5, 5, part2AnswerList6, 6, part2AnswerList7, 7, part2AnswerList8, 8, part2AnswerList9, 9);
                    SendHexPage21(part2AnswerList10, 10, part2AnswerList11, 11, part2AnswerList12, 12, part2AnswerList13, 13, part2AnswerList14, 14, part2AnswerList15, 15, part2AnswerList16, 16, part2AnswerList17, 17, part2AnswerList18, 18);
                    SendHexPage22(part2AnswerList19, 19, part2AnswerList20, 20, part2AnswerList21, 21);
                    SendHexPage3(part3AnswerList1, 1, part3AnswerList2, 2, part3AnswerList3, 3, part3AnswerList4, 4, part3AnswerList5, 5, part3AnswerList6, 6, part3AnswerList7, 7);
                    checkWrite = true;
                }
                if (checkClose == false) {
                    if (GUI_Text.instance.writer != null) {
                        GUI_Text.instance.CloseFile();
                    }
                    checkClose = true;
                }
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), ""); // thanks one
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, Screen.height / 15), "Thanks for participating");//-------
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 10, boxWidth - Screen.width / 11.5f, boxHeight - Screen.height / 25), ""); //thanks two
                break;
            default:
                currentPageState = PageState.Form;
                break;
        }
        GUILayout.EndArea();
        GUI.Box(new Rect(0, Screen.height - Screen.height / 23, Screen.width, Screen.height / 23), "");
        GUI.Box(new Rect(0, Screen.height - Screen.height / 23, Screen.width, Screen.height / 23), "");
        GUI.Label(new Rect(Screen.width / 80, Screen.height-Screen.height/23, Screen.width, Screen.height / 23), "MS6400 - Dissertation // Student Number: 1136114 // Date and Time: " 
            + System.DateTime.UtcNow.ToString("HH:mm, dd MMMM, yyyy"));
        if (GUI.Button(new Rect(Screen.width - Screen.width / 5, Screen.height - Screen.height / 23, Screen.width / 5, Screen.height / 23), "Stop Test")) {
            Application.Quit();
        }
    }
    void MoralQuestions(Answer_Data data, string answer1, string answer2) {
        GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, Screen.height / 15), data.question);//get question list
        if (GUI.Button(new Rect(boxWidth / 3, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10), answer1)) {
            data.answer = answer1; //string from list
            currentPageState = PageState.Priming;
        }
        if (GUI.Button(new Rect(boxWidth / 3 * 2, boxHeight / 10 * 9, boxWidth / 3, boxHeight / 10),answer2)) {
            data.answer = answer2; //string from list
            currentPageState = PageState.Priming;
        }
        //return data;
    }
    public void SendPreMoralQuestions(Answer_Data one, Answer_Data two, Answer_Data three, Answer_Data four) {
        GUI_Text.instance.WritePreMoralQuestions(one, 1);
        GUI_Text.instance.WritePreMoralQuestions(two, 2);
        GUI_Text.instance.WritePreMoralQuestions(three, 3);
        GUI_Text.instance.WritePreMoralQuestions(four, 4);
    }
    public void SendPostMoralQuestions(Answer_Data five, Answer_Data six, Answer_Data seven, Answer_Data eight) {
        GUI_Text.instance.WritePostMoralQuestions(five, 6);
        GUI_Text.instance.WritePostMoralQuestions(six, 7);
        GUI_Text.instance.WritePostMoralQuestions(seven, 8);
        GUI_Text.instance.WritePostMoralQuestions(eight, 9);
    }
    public void SendHexPage1() {
        string gender;
        if (male) {
            gender = "Male";
        } else if (female) {
            gender = "female";
        } else {
            gender = "Participant didn't answer";
        }
        string frequency;
        if (everyDay) {
            frequency = "Every day";
        } else if (everyWeek) {
            frequency = "Every Week";
        } else if (occasionally) {
            frequency = "Occasionally";
        } else if (rarely) {
            frequency = "Rarely";
        } else if (never) {
            frequency = "Never";
        } else {
            frequency = "Participant didn't answer";
        }
        string consideration;
        if (hardCore) {
            consideration = "Hardcore gamer";
        } else if (between) {
            consideration = "something between a Hardcore and a Casual gamer";
        } else if (casual) {
            consideration = "Casual gamer";
        } else if (noIdea) {
            consideration = "I have no idea!";
        } else {
            consideration = "Participant didn't answer";
        }
        string playStyle;
        if (singleAlone) {
            playStyle = "Single player alone";
        } else if (singlePassing) {
            playStyle = "Single player with other people helping or pad-passing";
        } else if (localMultiplayer) {
            playStyle = "Multiplayer, in the same room";
        } else if (onlineMultiplayer) {
            playStyle = "Multiplayer, over the internet";
        } else if (teamPlay) {
            playStyle = "Team play or Clan play over the internet";
        } else if (mmorpg) {
            playStyle = "Virtual worlds or MMORPGs";
        } else {
            playStyle = "Participant didn't answer";
        }
        string attitude;
        if (important) {
            attitude = "Stories are very important to my enjoyment of videogames";
        } else if (helpEnjoy) {
            attitude = "Stories can help me enjoy a videogame";
        } else if (notImportant) {
            attitude = "Stories are not important to me in videogames";
        } else if (noStory) {
            attitude = "I prefer videogames without stories";
        } else if (dontPlay) {
            attitude = "I don't play videogames";
        } else {
            attitude = "Participant didn't answer";
        }
        GUI_Text.instance.WriteHexPage1(gender, yearOfBirth, brainHex, frequency, consideration, playStyle, attitude);
    }
    Bool_Data PreRegulatoryQuestions(Bool_Data answerBool, int num, string question) {
        GUI.Label(new Rect(Screen.width / 23, Screen.height / 9 + ((Screen.height / 30) * (num - 1)), Screen.width / 3, Screen.height / 27), question);
        if (GUI.Toggle(new Rect(Screen.width / 23, Screen.height / 9 + (Screen.height / 30 * num), Screen.width / 13, Screen.height / 27), answerBool.iLoveIt, GUI_Text.instance.regulatoryList[19])) {
            answerBool.iLoveIt = true; answerBool.iLikeIt = false; answerBool.itOkay = false; answerBool.iDislikeIt = false; answerBool.iHateIt = false;
        }
        if (GUI.Toggle(new Rect(Screen.width / 23 + Screen.width / 13, Screen.height / 9 + (Screen.height / 30 * num), Screen.width / 13, Screen.height / 27), answerBool.iLikeIt, GUI_Text.instance.regulatoryList[20])) {
            answerBool.iLoveIt = false; answerBool.iLikeIt = true; answerBool.itOkay = false; answerBool.iDislikeIt = false; answerBool.iHateIt = false;
        }
        if (GUI.Toggle(new Rect(Screen.width / 23 + Screen.width / 13 * 2, Screen.height / 9 + (Screen.height / 30 * num), Screen.width / 13, Screen.height / 27), answerBool.itOkay, GUI_Text.instance.regulatoryList[21])) {
            answerBool.iLoveIt = false; answerBool.iLikeIt = false; answerBool.itOkay = true; answerBool.iDislikeIt = false; answerBool.iHateIt = false;
        }
        if (GUI.Toggle(new Rect(Screen.width / 23 + Screen.width / 13 * 3, Screen.height / 9 + (Screen.height / 30 * num), Screen.width / 13, Screen.height / 27), answerBool.iDislikeIt, GUI_Text.instance.regulatoryList[22])) {
            answerBool.iLoveIt = false; answerBool.iLikeIt = false; answerBool.itOkay = false; answerBool.iDislikeIt = true; answerBool.iHateIt = false;
        }
        if (GUI.Toggle(new Rect(Screen.width / 23 + Screen.width / 13 * 4, Screen.height / 9 + (Screen.height / 30 * num), Screen.width / 13, Screen.height / 27), answerBool.iHateIt, GUI_Text.instance.regulatoryList[23])) {
            answerBool.iLoveIt = false; answerBool.iLikeIt = false; answerBool.itOkay = false; answerBool.iDislikeIt = false; answerBool.iHateIt = true;
        }
        return answerBool;
    }
    public void SendPreRgulatory(Bool_Data one, int num1, Bool_Data two, int num2, Bool_Data three, int num3, Bool_Data four, int num4, Bool_Data five, int num5, Bool_Data six, int num6, 
        Bool_Data seven, int num7, Bool_Data eight, int num8, Bool_Data nine, int num9, Bool_Data ten, int num10, Bool_Data eleven, int num11, Bool_Data twelve, int num12, Bool_Data thirteen, int num13,
        Bool_Data fourteen, int num14, Bool_Data fifthteen, int num15, Bool_Data sixteen, int num16, Bool_Data seventeen, int num17, Bool_Data eighteen, int num18) {
        GetBoolRegulatory(one, num1);
        GetBoolRegulatory(two, num2);
        GetBoolRegulatory(three, num3);
        GetBoolRegulatory(four, num4);
        GetBoolRegulatory(five, num5);
        GetBoolRegulatory(six, num6);
        GetBoolRegulatory(seven, num7);
        GetBoolRegulatory(eight, num8);
        GetBoolRegulatory(nine, num9);
        GetBoolRegulatory(one, num10);
        GetBoolRegulatory(two, num11);
        GetBoolRegulatory(three, num12);
        GetBoolRegulatory(four, num13);
        GetBoolRegulatory(five, num14);
        GetBoolRegulatory(six, num15);
        GetBoolRegulatory(seven, num16);
        GetBoolRegulatory(eight, num17);
        GetBoolRegulatory(nine, num18);
    }
    public void GetBoolRegulatory(Bool_Data data, int num) {
        string toSend;
        if (data.iLoveIt) {
            toSend = "1 (Agree)";
        } else if (data.iLikeIt) {
            toSend = "2";
        } else if (data.itOkay) {
            toSend = "3 (Neither)";
        } else if (data.iDislikeIt) {
            toSend = "4";
        } else if (data.iHateIt) {
            toSend = "5 (Disagree)";
        } else {
            toSend = "Participant didn't answer";
        }
        GUI_Text.instance.WriteRegulatoryFocus(toSend, num);
    }
    Bool_Data Part2Questions(Bool_Data answerBool, int num, string question) {
        GUI.Label(new Rect(Screen.width / 23, Screen.height / 9 + ((Screen.height / 30) * (num-1)), Screen.width / 3, Screen.height / 27), question);
        if (GUI.Toggle(new Rect(Screen.width / 23, Screen.height / 9 + (Screen.height / 30 * num), Screen.width / 13, Screen.height / 27), answerBool.iLoveIt, GUI_Text.instance.HexPage2List[22])) {
            answerBool.iLoveIt = true; answerBool.iLikeIt = false; answerBool.itOkay = false; answerBool.iDislikeIt = false; answerBool.iHateIt = false;
        }
        if (GUI.Toggle(new Rect(Screen.width / 23 + Screen.width / 13, Screen.height / 9 + (Screen.height / 30 * num), Screen.width / 13, Screen.height / 27), answerBool.iLikeIt, GUI_Text.instance.HexPage2List[23])) {
            answerBool.iLoveIt = false; answerBool.iLikeIt = true; answerBool.itOkay = false; answerBool.iDislikeIt = false; answerBool.iHateIt = false;
        }
        if (GUI.Toggle(new Rect(Screen.width / 23 + Screen.width / 13 * 2, Screen.height / 9 + (Screen.height / 30 * num), Screen.width / 13, Screen.height / 27), answerBool.itOkay, GUI_Text.instance.HexPage2List[24])) {
            answerBool.iLoveIt = false; answerBool.iLikeIt = false; answerBool.itOkay = true; answerBool.iDislikeIt = false; answerBool.iHateIt = false;
        }
        if (GUI.Toggle(new Rect(Screen.width / 23 + Screen.width / 13 * 3, Screen.height / 9 + (Screen.height / 30 * num), Screen.width / 13, Screen.height / 27), answerBool.iDislikeIt, GUI_Text.instance.HexPage2List[25])) {
            answerBool.iLoveIt = false; answerBool.iLikeIt = false; answerBool.itOkay = false; answerBool.iDislikeIt = true; answerBool.iHateIt = false;
        }
        if (GUI.Toggle(new Rect(Screen.width / 23 + Screen.width / 13 * 4, Screen.height / 9 + (Screen.height / 30 * num), Screen.width / 13, Screen.height / 27), answerBool.iHateIt, GUI_Text.instance.HexPage2List[26])) {
            answerBool.iLoveIt = false; answerBool.iLikeIt = false; answerBool.itOkay = false; answerBool.iDislikeIt = false; answerBool.iHateIt = true;
        }
        return answerBool;
    }
    public void SendHexPage21(Bool_Data one, int num1, Bool_Data two, int num2, Bool_Data three, int num3, Bool_Data four, int num4, Bool_Data five, int num5, Bool_Data six, int num6, Bool_Data seven, int num7, Bool_Data eight, int num8, Bool_Data nine, int num9) {
        GetBool(one, num1);
        GetBool(two, num2);
        GetBool(three, num3);
        if (four != null) {
            GetBool(four, num4);
            GetBool(five, num5);
            GetBool(six, num6);
            GetBool(seven, num7);
            GetBool(eight, num8);
            GetBool(nine, num9);
        }
    }
    public void SendHexPage22(Bool_Data one, int num1, Bool_Data two, int num2, Bool_Data three, int num3) {
        GetBool(one, num1);
        GetBool(two, num2);
        GetBool(three, num3);
    }
    public void GetBool(Bool_Data data, int num) {
        string toSend;
        if (data.iLoveIt) {
            toSend = "I love it";
        } else if (data.iLikeIt) {
            toSend = "I like it";
        } else if (data.itOkay) {
            toSend = "It's okay";
        } else if (data.iDislikeIt) {
            toSend = "I dislike it";
        } else if (data.iHateIt) {
            toSend = "I hate it";
        } else {
            toSend = "Participant didn't answer";
        }
        GUI_Text.instance.WriteHexPage2(toSend, num);
    }
    Bool_Data2 Part3Questions(Bool_Data2 answerData1, Bool_Data2 answerData2, Bool_Data2 answerData3, Bool_Data2 answerData4, Bool_Data2 answerData5, 
        Bool_Data2 answerData6, Bool_Data2 answerData7, int num, string question) {
        GUI.Label(new Rect(Screen.width / 23, Screen.height / 9 + ((Screen.height / 30) * (num - 1)), Screen.width / 3, Screen.height / 27), question);
        if (GUI.Toggle(new Rect(Screen.width / 23, Screen.height / 9 + (Screen.height / 30 * num), Screen.width / 19, Screen.height / 27), answerData1.one, GUI_Text.instance.HexPage3List[8])) {
            answerData1.one = true; answerData1.two = false; answerData1.three = false; answerData1.four = false; answerData1.five = false; answerData1.six = false; answerData1.seven = false;
            answerData2.one = false; answerData3.one = false; answerData4.one = false; answerData5.one = false; answerData6.one = false; answerData7.one = false;
        }
        if (GUI.Toggle(new Rect(Screen.width / 23 + Screen.width / 19, Screen.height / 9 + (Screen.height / 30 * num), Screen.width / 19, Screen.height / 27), answerData1.two, GUI_Text.instance.HexPage3List[9])) {
            answerData1.one = false; answerData1.two = true; answerData1.three = false; answerData1.four = false; answerData1.five = false; answerData1.six = false; answerData1.seven = false;
            answerData2.two = false; answerData3.two = false; answerData4.two = false; answerData5.two = false; answerData6.two = false; answerData7.two = false;
        }
        if (GUI.Toggle(new Rect(Screen.width / 23 + Screen.width / 19 * 2, Screen.height / 9 + (Screen.height / 30 * num), Screen.width / 19, Screen.height / 27), answerData1.three, GUI_Text.instance.HexPage3List[10])) {
            answerData1.one = false; answerData1.two = false; answerData1.three = true; answerData1.four = false; answerData1.five = false; answerData1.six = false; answerData1.seven = false;
            answerData2.three = false; answerData3.three = false; answerData4.three = false; answerData5.three = false; answerData6.three = false; answerData7.three = false;
        }
        if (GUI.Toggle(new Rect(Screen.width / 23 + Screen.width / 19 * 3, Screen.height / 9 + (Screen.height / 30 * num), Screen.width / 19, Screen.height / 27), answerData1.four, GUI_Text.instance.HexPage3List[11])) {
            answerData1.one = false; answerData1.two = false; answerData1.three = false; answerData1.four = true; answerData1.five = false; answerData1.six = false; answerData1.seven = false;
            answerData2.four = false; answerData3.four = false; answerData4.four = false; answerData5.four = false; answerData6.four = false; answerData7.four = false;
        }
        if (GUI.Toggle(new Rect(Screen.width / 23 + Screen.width / 19 * 4, Screen.height / 9 + (Screen.height / 30 * num), Screen.width / 19, Screen.height / 27), answerData1.five, GUI_Text.instance.HexPage3List[12])) {
            answerData1.one = false; answerData1.two = false; answerData1.three = false; answerData1.four = false; answerData1.five = true; answerData1.six = false; answerData1.seven = false;
            answerData2.five = false; answerData3.five = false; answerData4.five = false; answerData5.five = false; answerData6.five = false; answerData7.five = false;
        }
        if (GUI.Toggle(new Rect(Screen.width / 23 + Screen.width / 19 * 5, Screen.height / 9 + (Screen.height / 30 * num), Screen.width / 19, Screen.height / 27), answerData1.six, GUI_Text.instance.HexPage3List[13])) {
            answerData1.one = false; answerData1.two = false; answerData1.three = false; answerData1.four = false; answerData1.five = false; answerData1.six = true; answerData1.seven = false;
            answerData2.six = false; answerData3.six = false; answerData4.six = false; answerData5.six = false; answerData6.six = false; answerData7.six = false;
        }
        if (GUI.Toggle(new Rect(Screen.width / 23 + Screen.width / 19 * 6, Screen.height / 9 + (Screen.height / 30 * num), Screen.width / 19, Screen.height / 27), answerData1.seven, GUI_Text.instance.HexPage3List[14])) {
            answerData1.one = false; answerData1.two = false; answerData1.three = false; answerData1.four = false; answerData1.five = false; answerData1.six = false; answerData1.seven = true;
            answerData2.seven = false; answerData3.seven = false; answerData4.seven = false; answerData5.seven = false; answerData6.seven = false; answerData7.seven = false;
        }
        return answerData1;
    }
    public void SendHexPage3(Bool_Data2 one, int num1, Bool_Data2 two, int num2, Bool_Data2 three, int num3, Bool_Data2 four, int num4, Bool_Data2 five, int num5, 
        Bool_Data2 six, int num6, Bool_Data2 seven, int num7) {
        GetBool2(one, num1);
        GetBool2(two, num2);
        GetBool2(three, num3);
        GetBool2(four, num4);
        GetBool2(five, num5);
        GetBool2(six, num6);
        GetBool2(seven, num7);
    }
    public void GetBool2(Bool_Data2 data, int num) {
        string toSend;
        if (data.one) {
            toSend = "1";
        } else if (data.two) {
            toSend = "2";
        } else if (data.three) {
            toSend = "3";
        } else if (data.four) {
            toSend = "4";
        } else if (data.five) {
            toSend = "5";
        } else if (data.six) {
            toSend = "6";
        } else if (data.seven) {
            toSend = "7";
        } else {
            toSend = "Participant didn't answer";
        }
        GUI_Text.instance.WriteHexPage3(toSend, num);
    }
}
