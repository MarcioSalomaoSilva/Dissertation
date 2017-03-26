//using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Answer_Data {
    public List<string> answerList = new List<string>();
    public List<int> answerIDList = new List<int>();
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
    public enum PageState {
        Form, HexPart1, PreRgulatoryQuestions1, PreRgulatoryQuestions2, PreRgulatoryQuestions3, HexPart2_1, HexPart2_2, HexPart2_3, HexPart3, Priming, PostRgulatoryQuestions, Thanks
    }
    PageState currentPageState;
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
    //post regulatory questions
    bool check1;
    bool check2;
    bool check3;
    bool check4;
    bool check5;
    bool check6;
    bool check7;
    bool check8;
    bool check9;
    bool check10;
    string currentQuestion;
    [HideInInspector]
    public int currentQuestionID;
    int currentPrimingID;
    public Answer_Data curQuestionData = new Answer_Data();
    Answer_Data question1 = new Answer_Data();
    Answer_Data question2 = new Answer_Data();
    Answer_Data question3 = new Answer_Data();
    Answer_Data question4 = new Answer_Data();
    Answer_Data question5 = new Answer_Data();
    Answer_Data question6 = new Answer_Data();
    Answer_Data question7 = new Answer_Data();
    Answer_Data question8 = new Answer_Data();
    Answer_Data question9 = new Answer_Data();
    Answer_Data question10 = new Answer_Data();
    void Awake() {
        instance = this;
    }
    void Start () {
        CreateLists();
    }
    void Update() {
        currentQuestionID = Mathf.Clamp(currentQuestionID,1,11);
        QuestionStates();
    }
    void OnGUI() {
        float boxWidth = Screen.width - (Screen.width / 11) * 2;
        float boxHeight = Screen.height - (Screen.height / 11) * 2;
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
                if(GUI.Toggle(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30, Screen.width / 10, Screen.height / 27), male, GUI_Text.instance.HexPage1List[5])) {
                    male = true; female = false;
                }
                if (GUI.Toggle(new Rect(Screen.width / 23 + Screen.width / 10, Screen.height / 10 + Screen.height / 30, Screen.width / 10, Screen.height / 27), female, GUI_Text.instance.HexPage1List[6])) {
                    male = false; female = true;
                }
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 2, Screen.width / 3, Screen.height / 27), GUI_Text.instance.HexPage1List[7]);
                yearOfBirth = GUI.TextField(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 3, Screen.width / 5, Screen.height / 27), yearOfBirth, 25);
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 4, Screen.width / 3, Screen.height / 27), GUI_Text.instance.HexPage1List[8]);
                if (GUI.Toggle(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 5, Screen.width / 3, Screen.height / 27), everyDay, GUI_Text.instance.HexPage1List[9])) {
                    everyDay = true;everyWeek = false;occasionally = false;rarely = false;never = false; 
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
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 10, Screen.width / 2, Screen.height / 27), GUI_Text.instance.HexPage1List[13]);
                if (GUI.Toggle(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 11, Screen.width / 3, Screen.height / 27), hardCore, GUI_Text.instance.HexPage1List[14])) {
                    hardCore = true; between = false; casual = false; noIdea = false; 
                }
                if (GUI.Toggle(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 12, Screen.width / 3, Screen.height / 27), between, GUI_Text.instance.HexPage1List[15])) {
                    hardCore = false; between = true; casual = false; noIdea = false;
                }
                if (GUI.Toggle(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 13, Screen.width / 3, Screen.height / 27), casual, GUI_Text.instance.HexPage1List[16])) {
                    hardCore = false; between = false; casual = true; noIdea = false;
                }
                if (GUI.Toggle(new Rect(Screen.width / 23, Screen.height / 10 + Screen.height / 30 * 14, Screen.width / 3, Screen.height / 27), noIdea, GUI_Text.instance.HexPage1List[17])) {
                    hardCore = false; between = false; casual = false; noIdea = true;
                }
                GUI.Label(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10, Screen.width / 3, Screen.height / 27), GUI_Text.instance.HexPage1List[18]);
                if (GUI.Toggle(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30, Screen.width / 3, Screen.height / 27), singleAlone, GUI_Text.instance.HexPage1List[19])) {
                    singleAlone = true; singlePassing = false;localMultiplayer = false; onlineMultiplayer = false;teamPlay = false;mmorpg = false;
                }
                if (GUI.Toggle(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30 * 2, Screen.width / 3, Screen.height / 27), singlePassing, GUI_Text.instance.HexPage1List[20])) {
                    singleAlone = false; singlePassing = true; localMultiplayer = false; onlineMultiplayer = false; teamPlay = false; mmorpg = false;
                }
                if (GUI.Toggle(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30 * 3, Screen.width / 3, Screen.height / 27), localMultiplayer, GUI_Text.instance.HexPage1List[19])) {
                    singleAlone = false; singlePassing = false; localMultiplayer = true; onlineMultiplayer = false; teamPlay = false; mmorpg = false;
                }
                if (GUI.Toggle(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30 * 4, Screen.width / 3, Screen.height / 27), onlineMultiplayer, GUI_Text.instance.HexPage1List[20])) {
                    singleAlone = false; singlePassing = false; localMultiplayer = false; onlineMultiplayer = true; teamPlay = false; mmorpg = false;
                }
                if (GUI.Toggle(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30 * 5, Screen.width / 3, Screen.height / 27), teamPlay, GUI_Text.instance.HexPage1List[21])) {
                    singleAlone = false; singlePassing = false; localMultiplayer = false; onlineMultiplayer = false; teamPlay = true; mmorpg = false;
                }
                if (GUI.Toggle(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30 * 6, Screen.width / 3, Screen.height / 27), mmorpg, GUI_Text.instance.HexPage1List[22])) {
                    singleAlone = false; singlePassing = false; localMultiplayer = false; onlineMultiplayer = false; teamPlay = false; mmorpg = true;
                }
                GUI.Label(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30 * 7, Screen.width / 3, Screen.height / 27), GUI_Text.instance.HexPage1List[23]);
                if (GUI.Toggle(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30 * 8, Screen.width / 3, Screen.height / 27), important, GUI_Text.instance.HexPage1List[24])) {
                    important = true; helpEnjoy = false; notImportant = false; noStory = false; dontPlay = false;
                }
                if (GUI.Toggle(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30 * 9, Screen.width / 3, Screen.height / 27), helpEnjoy, GUI_Text.instance.HexPage1List[25])) {
                    important = false; helpEnjoy = true; notImportant = false; noStory = false; dontPlay = false;
                }
                if (GUI.Toggle(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30 * 10, Screen.width / 3, Screen.height / 27), notImportant, GUI_Text.instance.HexPage1List[26])) {
                    important = false; helpEnjoy = false; notImportant = true; noStory = false; dontPlay = false;
                }
                if (GUI.Toggle(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30 * 11, Screen.width / 3, Screen.height / 27), noStory, GUI_Text.instance.HexPage1List[27])) {
                    important = false; helpEnjoy = false; notImportant = false; noStory = true; dontPlay = false;
                }
                if (GUI.Toggle(new Rect(boxWidth / 2 + Screen.width / 40, Screen.height / 10 + Screen.height / 30 * 12, Screen.width / 3, Screen.height / 27), dontPlay, GUI_Text.instance.HexPage1List[28])) {
                    important = false; helpEnjoy = false; notImportant = false; noStory = false; dontPlay = true;
                }
                if (GUI.Button(new Rect(boxWidth / 2, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Continue")) {
                    currentPageState = PageState.PreRgulatoryQuestions1;
                }
                break;
            case PageState.PreRgulatoryQuestions1:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, Screen.height / 15), GUI_Text.instance.PreRegulatoryList[0]);
                PreRegulatoryQuestions(preRegulatoryList1, 1, GUI_Text.instance.PreRegulatoryList[1]);
                PreRegulatoryQuestions(preRegulatoryList2, 3, GUI_Text.instance.PreRegulatoryList[2]);
                PreRegulatoryQuestions(preRegulatoryList3, 5, GUI_Text.instance.PreRegulatoryList[3]);
                PreRegulatoryQuestions(preRegulatoryList4, 7, GUI_Text.instance.PreRegulatoryList[4]);
                PreRegulatoryQuestions(preRegulatoryList5, 9, GUI_Text.instance.PreRegulatoryList[5]);
                PreRegulatoryQuestions(preRegulatoryList6, 11, GUI_Text.instance.PreRegulatoryList[6]);
                PreRegulatoryQuestions(preRegulatoryList7, 13, GUI_Text.instance.PreRegulatoryList[7]);
                if (GUI.Button(new Rect(boxWidth / 2, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Continue")) {
                    currentPageState = PageState.PreRgulatoryQuestions2;
                }
                if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Back")) {
                    currentPageState = PageState.HexPart1;
                }
                break;
            case PageState.PreRgulatoryQuestions2:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, Screen.height / 15), GUI_Text.instance.PreRegulatoryList[0]);
                PreRegulatoryQuestions(preRegulatoryList8, 1, GUI_Text.instance.PreRegulatoryList[8]);
                PreRegulatoryQuestions(preRegulatoryList9, 3, GUI_Text.instance.PreRegulatoryList[9]);
                PreRegulatoryQuestions(preRegulatoryList10, 5, GUI_Text.instance.PreRegulatoryList[10]);
                PreRegulatoryQuestions(preRegulatoryList11, 7, GUI_Text.instance.PreRegulatoryList[11]);
                PreRegulatoryQuestions(preRegulatoryList12, 9, GUI_Text.instance.PreRegulatoryList[12]);
                PreRegulatoryQuestions(preRegulatoryList13, 11, GUI_Text.instance.PreRegulatoryList[13]);
                PreRegulatoryQuestions(preRegulatoryList14, 13, GUI_Text.instance.PreRegulatoryList[14]);
                if (GUI.Button(new Rect(boxWidth / 2, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Continue")) {
                    currentPageState = PageState.PreRgulatoryQuestions3;
                }
                if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Back")) {
                    currentPageState = PageState.PreRgulatoryQuestions1;
                }
                break;
            case PageState.PreRgulatoryQuestions3:
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, Screen.height / 15), GUI_Text.instance.PreRegulatoryList[0]);
                PreRegulatoryQuestions(preRegulatoryList15, 1, GUI_Text.instance.PreRegulatoryList[15]);
                PreRegulatoryQuestions(preRegulatoryList16, 3, GUI_Text.instance.PreRegulatoryList[16]);
                PreRegulatoryQuestions(preRegulatoryList17, 5, GUI_Text.instance.PreRegulatoryList[17]);
                PreRegulatoryQuestions(preRegulatoryList18, 7, GUI_Text.instance.PreRegulatoryList[18]);
                if (GUI.Button(new Rect(boxWidth / 2, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Continue")) {
                    currentPageState = PageState.HexPart2_1;
                }
                if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Back")) {
                    currentPageState = PageState.PreRgulatoryQuestions2;
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
                    currentPageState = PageState.PreRgulatoryQuestions2;
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
                    currentPageState = PageState.Priming;
                }
                if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Back")) {
                    currentPageState = PageState.HexPart2_3;
                }
                break;
            case PageState.Priming:
                currentPrimingID = Mathf.Clamp(currentPrimingID, 0, 1);
                switch (currentPrimingID) {
                    case 0:
                        GUI.Box(new Rect(0, 0, boxWidth, boxHeight - boxHeight / 10), "");
                        GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                        GUI.Box(new Rect(0, boxHeight - boxHeight / 10, boxWidth, boxHeight / 5), "");
                        GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, Screen.height / 15), GUI_Text.instance.primingList[1]);//---------
                        GUI.Label(new Rect(Screen.width / 23, Screen.height / 10, boxWidth - Screen.width / 11.5f, boxHeight - Screen.height / 25), GUI_Text.instance.primingList[2]);
                        if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Do First Thing") || GUI.Button(new Rect(boxWidth / 2, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Do Second Thing")) {
                            currentPrimingID += 1;
                        }
                        break;
                    case 1:
                        GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                        GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                        GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, Screen.height / 15), GUI_Text.instance.primingList[1]);//-------
                        GUI.Label(new Rect(Screen.width / 23, Screen.height / 10, boxWidth - Screen.width / 11.5f, boxHeight - Screen.height / 25), GUI_Text.instance.primingList[3]);
                        if (GUI.Button(new Rect(boxWidth / 2, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Continue")) {
                            currentPageState = PageState.PostRgulatoryQuestions;
                        }
                        if (GUI.Button(new Rect(0, boxHeight / 10 * 9, boxWidth / 2, boxHeight / 10), "Back")) {
                            currentPageState = PageState.HexPart3;
                        }
                        break;
                    default:
                        currentPrimingID = 0;
                        break;
                }
                break;
            case PageState.PostRgulatoryQuestions:
                if (checkWrite == false) {
                    SendHexPage1();
                    SendPreRgulatory(preRegulatoryList1, 1, preRegulatoryList2, 2, preRegulatoryList3, 3, preRegulatoryList4, 4, preRegulatoryList5, 5, preRegulatoryList6, 6, preRegulatoryList7, 7, preRegulatoryList8, 8,
                        preRegulatoryList9, 9, preRegulatoryList10, 10, preRegulatoryList11, 11, preRegulatoryList12, 12, preRegulatoryList13, 13, preRegulatoryList14, 14, preRegulatoryList15, 15, preRegulatoryList16, 16,
                        preRegulatoryList17, 17, preRegulatoryList18, 18);
                    SendHexPage21(part2AnswerList1, 1, part2AnswerList2, 2, part2AnswerList3, 3, part2AnswerList4, 4, part2AnswerList5, 5, part2AnswerList6, 6, part2AnswerList7, 7, part2AnswerList8, 8, part2AnswerList9, 9);
                    SendHexPage21(part2AnswerList10, 10, part2AnswerList11, 11, part2AnswerList12, 12, part2AnswerList13, 13, part2AnswerList14, 14, part2AnswerList15, 15, part2AnswerList16, 16, part2AnswerList17, 17, part2AnswerList18, 18);
                    SendHexPage22(part2AnswerList19, 19, part2AnswerList20, 20, part2AnswerList21, 21);
                    SendHexPage3(part3AnswerList1, 1, part3AnswerList2, 2, part3AnswerList3, 3, part3AnswerList4, 4, part3AnswerList5, 5, part3AnswerList6, 6, part3AnswerList7, 7);
                    checkWrite = true;
                }
                GUI.Box(new Rect(0, 0, boxWidth, boxHeight), "");
                GUI.Box(new Rect(0, 0, boxWidth / 3 * 2, boxHeight), "");
                GUI.Box(new Rect(boxWidth / 3 * 2, 0, boxWidth / 2, boxHeight), "");
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 23, boxWidth - Screen.width / 11.5f, Screen.height / 15), "Question: " + currentQuestionID);//-----
                GUI.Label(new Rect(Screen.width / 23, Screen.height / 10, boxWidth / 3 * 2 - Screen.width / 11.5f, boxHeight - Screen.height / 25), currentQuestion);
                if (GUI.Button(new Rect(boxWidth / 3 * 2, 0, boxWidth / 3, boxHeight / 5), curQuestionData.answerList[1])) {
                    GUI_Text.instance.WritePostRegulatoryFocus(currentQuestion, curQuestionData.answerList[1], currentQuestionID, curQuestionData.answerIDList[1]);
                    currentQuestionID += 1;
                }
                if (GUI.Button(new Rect(boxWidth / 3 * 2, boxHeight / 5, boxWidth / 3, boxHeight / 5), curQuestionData.answerList[2])) {
                    GUI_Text.instance.WritePostRegulatoryFocus(currentQuestion, curQuestionData.answerList[2], currentQuestionID, curQuestionData.answerIDList[2]);
                    currentQuestionID += 1;
                }
                if (GUI.Button(new Rect(boxWidth / 3 * 2, boxHeight / 5 * 2, boxWidth / 3, boxHeight / 5), curQuestionData.answerList[3])) {
                    GUI_Text.instance.WritePostRegulatoryFocus(currentQuestion, curQuestionData.answerList[3], currentQuestionID, curQuestionData.answerIDList[3]);
                    currentQuestionID += 1;
                }
                if (GUI.Button(new Rect(boxWidth / 3 * 2, boxHeight / 5 * 3, boxWidth / 3, boxHeight / 5), curQuestionData.answerList[4])) {
                    GUI_Text.instance.WritePostRegulatoryFocus(currentQuestion, curQuestionData.answerList[4], currentQuestionID, curQuestionData.answerIDList[4]);
                    currentQuestionID += 1;
                }
                if (GUI.Button(new Rect(boxWidth / 3 * 2, boxHeight / 5 * 4, boxWidth / 3, boxHeight / 5), curQuestionData.answerList[5])) {
                    GUI_Text.instance.WritePostRegulatoryFocus(currentQuestion, curQuestionData.answerList[5], currentQuestionID, curQuestionData.answerIDList[5]);
                    currentQuestionID += 1;
                }
                break;
            case PageState.Thanks:
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
        if (GUI.Toggle(new Rect(Screen.width / 23, Screen.height / 9 + (Screen.height / 30 * num), Screen.width / 13, Screen.height / 27), answerBool.iLoveIt, GUI_Text.instance.PreRegulatoryList[19])) {
            answerBool.iLoveIt = true; answerBool.iLikeIt = false; answerBool.itOkay = false; answerBool.iDislikeIt = false; answerBool.iHateIt = false;
        }
        if (GUI.Toggle(new Rect(Screen.width / 23 + Screen.width / 13, Screen.height / 9 + (Screen.height / 30 * num), Screen.width / 13, Screen.height / 27), answerBool.iLikeIt, GUI_Text.instance.PreRegulatoryList[20])) {
            answerBool.iLoveIt = false; answerBool.iLikeIt = true; answerBool.itOkay = false; answerBool.iDislikeIt = false; answerBool.iHateIt = false;
        }
        if (GUI.Toggle(new Rect(Screen.width / 23 + Screen.width / 13 * 2, Screen.height / 9 + (Screen.height / 30 * num), Screen.width / 13, Screen.height / 27), answerBool.itOkay, GUI_Text.instance.PreRegulatoryList[21])) {
            answerBool.iLoveIt = false; answerBool.iLikeIt = false; answerBool.itOkay = true; answerBool.iDislikeIt = false; answerBool.iHateIt = false;
        }
        if (GUI.Toggle(new Rect(Screen.width / 23 + Screen.width / 13 * 3, Screen.height / 9 + (Screen.height / 30 * num), Screen.width / 13, Screen.height / 27), answerBool.iDislikeIt, GUI_Text.instance.PreRegulatoryList[22])) {
            answerBool.iLoveIt = false; answerBool.iLikeIt = false; answerBool.itOkay = false; answerBool.iDislikeIt = true; answerBool.iHateIt = false;
        }
        if (GUI.Toggle(new Rect(Screen.width / 23 + Screen.width / 13 * 4, Screen.height / 9 + (Screen.height / 30 * num), Screen.width / 13, Screen.height / 27), answerBool.iHateIt, GUI_Text.instance.PreRegulatoryList[23])) {
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
        GUI_Text.instance.WritePreRegulatoryFocus(toSend, num);
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
    void CreateLists() {
        CreateListString(question1.answerList, GUI_Text.instance.answerList[0], GUI_Text.instance.answerList[1], GUI_Text.instance.answerList[2], GUI_Text.instance.answerList[3], GUI_Text.instance.answerList[4], GUI_Text.instance.answerList[5]);
        CreateListString(question2.answerList, GUI_Text.instance.answerList[0], GUI_Text.instance.answerList[6], GUI_Text.instance.answerList[7], GUI_Text.instance.answerList[8], GUI_Text.instance.answerList[9], GUI_Text.instance.answerList[10]);
        CreateListString(question3.answerList, GUI_Text.instance.answerList[0], GUI_Text.instance.answerList[11], GUI_Text.instance.answerList[12], GUI_Text.instance.answerList[13], GUI_Text.instance.answerList[14], GUI_Text.instance.answerList[15]);
        CreateListString(question4.answerList, GUI_Text.instance.answerList[0], GUI_Text.instance.answerList[16], GUI_Text.instance.answerList[17], GUI_Text.instance.answerList[18], GUI_Text.instance.answerList[19], GUI_Text.instance.answerList[20]);
        CreateListString(question5.answerList, GUI_Text.instance.answerList[0], GUI_Text.instance.answerList[21], GUI_Text.instance.answerList[22], GUI_Text.instance.answerList[23], GUI_Text.instance.answerList[24], GUI_Text.instance.answerList[25]);
        CreateListString(question6.answerList, GUI_Text.instance.answerList[0], GUI_Text.instance.answerList[26], GUI_Text.instance.answerList[27], GUI_Text.instance.answerList[28], GUI_Text.instance.answerList[29], GUI_Text.instance.answerList[30]);
        CreateListString(question7.answerList, GUI_Text.instance.answerList[0], GUI_Text.instance.answerList[31], GUI_Text.instance.answerList[32], GUI_Text.instance.answerList[33], GUI_Text.instance.answerList[34], GUI_Text.instance.answerList[35]);
        CreateListString(question8.answerList, GUI_Text.instance.answerList[0], GUI_Text.instance.answerList[36], GUI_Text.instance.answerList[37], GUI_Text.instance.answerList[38], GUI_Text.instance.answerList[39], GUI_Text.instance.answerList[40]);
        CreateListString(question9.answerList, GUI_Text.instance.answerList[0], GUI_Text.instance.answerList[41], GUI_Text.instance.answerList[42], GUI_Text.instance.answerList[43], GUI_Text.instance.answerList[44], GUI_Text.instance.answerList[45]);
        CreateListString(question10.answerList, GUI_Text.instance.answerList[0], GUI_Text.instance.answerList[46], GUI_Text.instance.answerList[47], GUI_Text.instance.answerList[48], GUI_Text.instance.answerList[49], GUI_Text.instance.answerList[50]);
        CreateListInt(question1.answerIDList, 0, 1, 2, 3, 4, 5);
        CreateListInt(question2.answerIDList, 0, 1, 2, 3, 4, 5);
        CreateListInt(question3.answerIDList, 0, 1, 2, 3, 4, 5);
        CreateListInt(question4.answerIDList, 0, 1, 2, 3, 4, 5);
        CreateListInt(question5.answerIDList, 0, 1, 2, 3, 4, 5);
        CreateListInt(question6.answerIDList, 0, 1, 2, 3, 4, 5);
        CreateListInt(question7.answerIDList, 0, 1, 2, 3, 4, 5);
        CreateListInt(question8.answerIDList, 0, 1, 2, 3, 4, 5);
        CreateListInt(question9.answerIDList, 0, 1, 2, 3, 4, 5);
        CreateListInt(question10.answerIDList, 0, 1, 2, 3, 4, 5);
    }
    void QuestionStates() {
        switch (currentQuestionID) {
            case 1:
                if (check1 == false) {
                    question1 = shuffleList(question1);
                    currentQuestion = GUI_Text.instance.questionList[1];
                    curQuestionData = question1;
                    check1 = true;
                }
                break;
            case 2:
                if (check2 == false) {
                    question2 = shuffleList(question2);
                    currentQuestion = GUI_Text.instance.questionList[2];
                    curQuestionData = question2;
                    check2 = true;
                }
        break;
            case 3:
                if (check3 == false) {
                    question3 = shuffleList(question3);
                    currentQuestion = GUI_Text.instance.questionList[3];
                    curQuestionData = question3;
                    check3 = true;
                }
                break;
            case 4:
                if (check4 == false) {
                    question4 = shuffleList(question4);
                    currentQuestion = GUI_Text.instance.questionList[4];
                    curQuestionData = question4;
                    check4 = true;
                }
                break;
            case 5:
                if (check5 == false) {
                    question5 = shuffleList(question5);
                    currentQuestion = GUI_Text.instance.questionList[5];
                    curQuestionData = question5;
                    check5 = true;
                }
                break;
            case 6:
                if (check6 == false) {
                    question6 = shuffleList(question6);
                    currentQuestion = GUI_Text.instance.questionList[6];
                    curQuestionData = question6;
                    check6 = true;
                }
                break;
            case 7:
                if (check7 == false) {
                    question7 = shuffleList(question7);
                    currentQuestion = GUI_Text.instance.questionList[7];
                    curQuestionData = question7;
                    check7 = true;
                }
                break;
            case 8:
                if (check8 == false) {
                    question8 = shuffleList(question8);
                    currentQuestion = GUI_Text.instance.questionList[8];
                    curQuestionData = question8;
                    check8 = true;
                }
                break;
            case 9:
                if (check9 == false) {
                    question9 = shuffleList(question9);
                    currentQuestion = GUI_Text.instance.questionList[9];
                    curQuestionData = question9;
                    check9 = true;
                }
                break;
            case 10:
                if (check10 == false) {
                    question10 = shuffleList(question10);
                    currentQuestion = GUI_Text.instance.questionList[10];
                    curQuestionData = question10;
                    check10 = true;
                }
                break;
            case 11:
                currentPageState = PageState.Thanks;
                break;
            default:
                currentQuestionID = 1;
                break;
        }
    }
    public List<string> CreateListString(List<string> newList, string add0, string add1, string add2, string add3, string add4, string add5) {
        newList.Add(add0);
        newList.Add(add1);
        newList.Add(add2);
        newList.Add(add3);
        newList.Add(add4);
        newList.Add(add5);
        return newList;
    }
    public List<int> CreateListInt(List<int> newList, int add0, int add1, int add2, int add3, int add4, int add5) {
        newList.Add(add0);
        newList.Add(add1);
        newList.Add(add2);
        newList.Add(add3);
        newList.Add(add4);
        newList.Add(add5);
        return newList;
    }
    Answer_Data shuffleList(Answer_Data toShuffle) {
        int x;
        int y;
        int t;
        string s;
        for (int i = 1; i < toShuffle.answerList.Count; i++) {
            x = ((Random.Range(i, toShuffle.answerList.Count)));
            y = x;
            s = toShuffle.answerList[i];
            t = toShuffle.answerIDList[i];
            toShuffle.answerList[i] = toShuffle.answerList[x];
            toShuffle.answerIDList[i] = toShuffle.answerIDList[y];
            toShuffle.answerList[x] = s;
            toShuffle.answerIDList[y] = t;
        }
        return toShuffle;
    }
}
