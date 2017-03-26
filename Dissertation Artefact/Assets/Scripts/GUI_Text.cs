﻿using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_Text : MonoBehaviour {
    public static GUI_Text instance;
    [HideInInspector]
    public StreamWriter writer;
    bool OnOff;
    bool headerPreReg;
    bool headerPage3;
    bool headerPage2;
    bool headerPage1;
    string txtQuestions = "Questions";
    string txtContentsQuestions;
    string txtAnswers = "Answers";
    string txtContentsAnswers;
    string txtEthics = "Ethics Form";
    string txtContentsEthics;
    string txtPrimingPositive = "Positive";
    string txtPrimingNegative = "Negative";
    string txtContentsPriming;
    string txtPreRegulatory = "PreRegulatoryFocus";
    string txtContentsPreRegulatory;
    string txtHexPage1 = "Hex_Page1";
    string txtContentsHexPage1;
    string txtHexPage2 = "Hex_Page2";
    string txtContentsHexPage2;
    string txtHexPage3 = "Hex_Page3";
    string txtContentsHexPage3;
    [SerializeField]
    int participantNumber;
    [HideInInspector]
    string writePath;
    [Header("Text Files")]
    public List<string> questionList = new List<string>();
    public List<string> answerList = new List<string>();
    public List<int> answerIDList = new List<int>();
    public List<string> ethicsList = new List<string>();
    public List<string> primingList = new List<string>();
    public List<string> PreRegulatoryList = new List<string>();
    public List<string> HexPage1List = new List<string>();
    public List<string> HexPage2List = new List<string>();
    public List<string> HexPage3List = new List<string>();
    void Awake() {
        instance = this;
        ReadFromTXT();
        participantNumber = RandomNumber(participantNumber);
    }
    public int RandomNumber(int num) {
        if (GUI_Manager.instance.test == true) {
            num = Random.Range(10000, 49999);
        } else {
            num = Random.Range(59999, 99999);
        }
        return num;
    }
    public void CreateFile() {
        if (GUI_Manager.instance.test == true) {
            writePath = Application.dataPath + "/Positive Priming/" + participantNumber + ".txt";
        } else {
            writePath = Application.dataPath + "/Negative Priming/" + participantNumber + ".txt";
        }
        if (!File.Exists(writePath)) {
            writer = File.CreateText(writePath) ;
            writer.WriteLine("MS6400 - Dissertation // Student Number: 1136114 // Date and Time: " + System.DateTime.UtcNow.ToString("HH:mm, dd MMMM, yyyy"));
            writer.WriteLine("");
            writer.WriteLine("Participant: " + participantNumber);
        }
    }
    public void Agreed() {
        writer.WriteLine("The participant agreed to the conditions of this study");
    }
    public void Disagreed() {
        writer.WriteLine("The participant disagreed to the conditions of this study");
        writer.Close();
    }
    public void WriteHexPage1(string gender, string age, string brainHex, string frequency, string consideration, string playStyle, string attitude) {
        writer.WriteLine("");
        writer.WriteLine("// Brain Hex Page 1");
        writer.WriteLine("");
        writer.WriteLine("Question: " + HexPage1List[3]);
        if (brainHex.Length < 2) {
            writer.WriteLine("Participant didn't answer");
        } else {
            writer.WriteLine("Answer: " + brainHex);
        }
        writer.WriteLine("");
        writer.WriteLine("Question: " + HexPage1List[4]);
        writer.WriteLine("Answer: " + gender);
        writer.WriteLine("");
        writer.WriteLine("Question: " + HexPage1List[7]);
        if (age.Length < 3) {
            writer.WriteLine("Participant didn't answer");
        } else {
            writer.WriteLine("Answer: " + age);
        }
        writer.WriteLine("");
        writer.WriteLine("Question: " + HexPage1List[8]);
        writer.WriteLine("Answer: " + frequency);
        writer.WriteLine("");
        writer.WriteLine("Question: " + HexPage1List[14]);
        writer.WriteLine("Answer: " + consideration);
        writer.WriteLine("");
        writer.WriteLine("Question: " + HexPage1List[19]);
        writer.WriteLine("Answer: " + playStyle);
        writer.WriteLine("");
        writer.WriteLine("Question: " + HexPage1List[26]);
        writer.WriteLine("Answer: " + attitude);
        writer.WriteLine("");
    }
    public void WritePreRegulatoryFocus(string recieved, int num) {
        if (headerPage2 == false) {
            writer.WriteLine("// Pre-Regulatory focus");
            headerPage2 = true;
        }
        writer.WriteLine("");
        writer.WriteLine("Question: " + PreRegulatoryList[num]);
        writer.WriteLine("Answer: " + recieved);
    }
    public void WriteHexPage2(string recieved, int num) {
        if (headerPage2 == false) {
            writer.WriteLine("// Brain Hex Page 2");
            headerPage2 = true;
        }
        writer.WriteLine("");
        writer.WriteLine("Question: " + HexPage2List[num]);
        writer.WriteLine("Answer: " + recieved);
    }
    public void WriteHexPage3(string recieved, int num) {
        if (headerPage3 == false) {
            writer.WriteLine("");
            writer.WriteLine("// Brain Hex Page 3");
            headerPage3 = true;
        }
        writer.WriteLine("");
        writer.WriteLine("Question: " + HexPage3List[num]);
        writer.WriteLine("Answer: " + recieved);
    }
    public void WritePostRegulatoryFocus(string question, string answer, int questionID, int answerID) {
        if (headerPage1 == false) {
            writer.WriteLine("");
            writer.WriteLine("// Post Regulatory focus questions");
            writer.WriteLine("");
            headerPage1 = true;
        }
        answerIDList.Add(answerID);
        writer.WriteLine("Question " + GUI_Manager.instance.currentQuestionID + ": " + question);
        writer.WriteLine("Answer: " + answer);
        writer.WriteLine("");
    }
    public void CloseFile() {
        writer.WriteLine("// End of questions");
        writer.WriteLine("");
        int ones = 0;
        int twos = 0;
        int threes = 0;
        int fours = 0;
        int fives = 0;
        for(int i = 1; i < answerIDList.Count; i++ ) {
            if(answerIDList[i] == 1) {
                ones += 1;
            }
            if (answerIDList[i] == 2) {
                twos += 1;
            }
            if (answerIDList[i] == 3) {
                threes += 1;
            }
            if (answerIDList[i] == 4) {
                fours += 1;
            }
            if (answerIDList[i] == 5) {
                fives += 1;
            }
        }
        writer.WriteLine("Number of answers per ID:");
        writer.WriteLine("Answer ID 1: " + ones + "// Answer ID 2: " + twos + "// Answer ID 3: " + threes + "// Answer ID 4: " + fours + "// Answer ID 5: " + fives);
        int minutes = Mathf.FloorToInt(Time.time / 60F);
        int seconds = Mathf.FloorToInt(Time.time - minutes * 60);
        string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);
        writer.WriteLine("");
        writer.WriteLine("Time taken to finish test: " + niceTime);
        writer.Close();
    }
    public void ReadFromTXT() {
        TextAsset txtAssetAnswers = (TextAsset)Resources.Load(txtAnswers);
        txtContentsAnswers = txtAssetAnswers.text;
        string[] linesInAnswers = txtContentsAnswers.Split('\n');
        foreach (string Answer in linesInAnswers) {
            answerList.Add(Answer);
        }
        TextAsset txtAssetQuestions = (TextAsset)Resources.Load(txtQuestions);
        txtContentsQuestions = txtAssetQuestions.text;
        string[] linesInQuestions = txtContentsQuestions.Split('\n');
        foreach (string line in linesInQuestions) {
            questionList.Add(line);
        }
        TextAsset txtAssetEthics = (TextAsset)Resources.Load(txtEthics);
        txtContentsEthics = txtAssetEthics.text;
        string[] linesInEthics = txtContentsEthics.Split('^');
        foreach (string line in linesInEthics) {
            ethicsList.Add(line);
        }
        TextAsset txtAssetPriming;
        if (GUI_Manager.instance.test) {
            txtAssetPriming = (TextAsset)Resources.Load(txtPrimingPositive);
        } else {
            txtAssetPriming = (TextAsset)Resources.Load(txtPrimingNegative);
        }
        txtContentsPriming = txtAssetPriming.text;
        string[] linesInPriming = txtContentsPriming.Split('^');
        foreach (string line in linesInPriming) {
            primingList.Add(line);
        }
        TextAsset txtAssetHexPage1 = (TextAsset)Resources.Load(txtHexPage1);
        txtContentsHexPage1 = txtAssetHexPage1.text;
        string[] linesInHexPage1 = txtContentsHexPage1.Split('\n');
        foreach (string line in linesInHexPage1) {
            HexPage1List.Add(line);
        }
        TextAsset txtAssetHexPage2 = (TextAsset)Resources.Load(txtHexPage2);
        txtContentsHexPage2 = txtAssetHexPage2.text;
        string[] linesInHexPage2 = txtContentsHexPage2.Split('\n');
        foreach (string line in linesInHexPage2) {
            HexPage2List.Add(line);
        }
        TextAsset txtAssetHexPage3 = (TextAsset)Resources.Load(txtHexPage3);
        txtContentsHexPage3 = txtAssetHexPage3.text;
        string[] linesInHexPage3 = txtContentsHexPage3.Split('\n');
        foreach (string line in linesInHexPage3) {
            HexPage3List.Add(line);
        }
        TextAsset txtAssetPreRegulatory = (TextAsset)Resources.Load(txtPreRegulatory);
        txtContentsPreRegulatory = txtAssetPreRegulatory.text;
        string[] linesInPreRegulatory = txtContentsPreRegulatory.Split('\n');
        foreach (string line in linesInPreRegulatory) {
            PreRegulatoryList.Add(line);
        }
    }
}
