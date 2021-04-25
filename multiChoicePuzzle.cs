using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class multiChoicePuzzle : MonoBehaviour
{
    public GameObject MultiChoice;
    public GameObject Q1;
    public GameObject Q2;
    public GameObject Q3;
    public GameObject Q4;
    public GameObject Q5;
    public GameObject Q6;
    public GameObject Q7;
    public GameObject Q8;
    public GameObject Q9;
    public GameObject Q10;
    public GameObject Retry;
    public int Score;
    public float Timer = -1f;

    public GameObject MC;
    inspectRaycast IR_Script;
    public GameObject CH;
    public GameObject CHInspect;
    public GameObject ItemTextBG;
    public GameObject DescBG;

    public AudioSource Q0Audio;
    public AudioSource Q1Audio;
    public AudioSource Q2Audio;
    public AudioSource Q3Audio;
    public AudioSource Q4Audio;
    public AudioSource Q5Audio;
    public AudioSource Q6Audio;
    public AudioSource Q7Audio;
    public AudioSource Q8Audio;
    public AudioSource Q9Audio;
    public AudioSource Q10Audio;
    public AudioSource Q11Audio;
    public AudioSource Q12Audio;
    public AudioSource Q13Audio;
    public AudioSource Q14Audio;
    public AudioSource Q15Audio;
    public AudioSource Q16Audio;
    public AudioSource bang;

    public int Answer;
    public int QuestionCounter = 0;

    void Start() {
        MultiChoice.SetActive(false);
        clearQuestions();
        Retry.SetActive(false);

        Timer = -1f;
    }
    
    public void Questions() {

        IR_Script = MC.GetComponent<inspectRaycast>();
        IR_Script.enabled = false;
        CH.SetActive(false);
        CHInspect.SetActive(false);
        ItemTextBG.SetActive(false);
        DescBG.SetActive(false);


        Cursor.lockState = CursorLockMode.None;
        MultiChoice.SetActive(true);
        
        Q0Audio.Play();
        Debug.Log("Who are you?"); //First question
        QuestionCounter = 1;
    }

    public void Update() {

        Debug.Log("Question #: " + QuestionCounter);
        Debug.Log("Score: " + Score);

        if(QuestionCounter == 1) { //Who are you?
        Q1.SetActive(true);
            switch(Answer) {
                case 2 : Debug.Log("We don't get many tourist around here. What are you doing here?"); //i'm a tourist -> response positive
                Q1Audio.Play();
                Answer = 0;
                nextQuestion();
                break;  
                case 3 : Debug.Log("I'm the barkeep. What are you doing here?"); //i was going to ask you that -> response nuetral
                Q2Audio.Play();
                Answer = 0;
                nextQuestion();
                break;
                case 1 : Debug.Log("You're crazy! Tell me what you are doing here before I kick you out"); //im a time traveler -> response negative & -1 score
                Q3Audio.Play();
                Score -= 1;
                Answer = 0;
                nextQuestion();
                break;
            }
        }

        if(QuestionCounter == 2) { //What are you doing here?
        clearQuestions();
        Q2.SetActive(true);
            switch(Answer) {
                case 1 : Debug.Log("Who are you looking for?"); //I'm looking for someone -> response positive
                Q4Audio.Play();
                Answer = 0;
                QuestionCounter = 3;
                break;
                case 2 : Debug.Log("What are you trying to fix?"); //I'm fixing something -> response nuetral
                Q5Audio.Play();
                Answer = 0;
                QuestionCounter = 4;
                break;
                case 3 : Debug.Log("Tell me what you're really doing here before I pull the shotgun out from behind the bar."); //I'm stealing something -> response negative & -1 score
                Q6Audio.Play();
                Score -= 1;
                Answer = 0;
                QuestionCounter = 5;
                break;
            }
        }

        if(QuestionCounter == 3) { //Who are you looking for?
        clearQuestions();
        Q3.SetActive(true);
            switch(Answer) {
                case 1 : Debug.Log("Tom Mill...why does that name sound so familiar....Oh yeah! He was in here last night! Why are you looking for him?"); //A man named Tom Mill
                Q7Audio.Play();
                Answer = 0;
                QuestionCounter = 7;
                break;
                case 2 : Debug.Log("You don't look like much of the outlaw hunting type...what are you really here for?"); //The man in that wanted poster
                Q8Audio.Play();
                Answer = 0;
                QuestionCounter = 5;
                break;
            }
        }

        if(QuestionCounter == 4) { //What are you trying to fix?
        clearQuestions();
        Q4.SetActive(true);
            switch(Answer) {
                case 1 : Debug.Log("Who are you looking for?"); //It's hard to explain. I just really need to find someone.
                Q4Audio.Play();
                Answer = 0;
                QuestionCounter = 3;
                break;
                case 2 : Debug.Log("Alright, well can I help ya at all?"); //I don't think you'd understand it...
                Q9Audio.Play();
                Answer = 0;
                QuestionCounter = 6;
                break;
                case 3 : Debug.Log("Well alright then, can I be of any help?"); //None of your business.
                if(Score > -2) {
                Q10Audio.Play();
                Answer = 0;
                QuestionCounter = 6;
                Score -= 1;
                }
                else if(Score == -2) {
                Answer = 0;
                QuestionCounter = 6;
                Score -= 1;
                }
                break;
            }
        }

        if(QuestionCounter == 5) { //What are you REALLY doing here?
        clearQuestions();
        Q5.SetActive(true);
            switch(Answer) {
                case 1 : Debug.Log("Who are you looking for?"); //I'm looking for someone.
                Q4Audio.Play();
                Answer = 0;
                QuestionCounter = 3;
                break;
                case 2 : Debug.Log("Well alright then, can I be of any help?"); //None of your business.
                if(Score > -2) {
                Q10Audio.Play();
                Answer = 0;
                QuestionCounter = 6;
                Score -= 1;
                }
                else if(Score == -2) {
                Answer = 0;
                QuestionCounter = 6;
                Score -= 1;
                }
                break;
            }
        }

        if(QuestionCounter == 6) { //Can I help?
        clearQuestions();
        Q6.SetActive(true);
            switch(Answer) {
                case 1 : Debug.Log("Tom Mill...why does that name sound so familiar....Oh yeah! He was in here last night! Why are you looking for him?"); //I'm looking for a man named Tom Mill
                Q7Audio.Play();
                Answer = 0;
                QuestionCounter = 7;
                break;
                case 2 : Debug.Log("Are you sure? I've lived here my whole life. I know everything about this town."); //No, I don't need help from you.
                Q11Audio.Play();
                QuestionCounter = 8;
                Score -= 1;
                break;
            }
        }

        if(QuestionCounter == 7) { //Why are you looking for him?
        clearQuestions();
        Q7.SetActive(true);
            switch(Answer) {
                case 1 : Debug.Log("Yeah, he's staying at the Inn just down the street. He actually left his wagon out back overnight."); //Do you know where I can find him?
                Q12Audio.Play();
                Answer = 0;
                QuestionCounter = 9;
                break;
                case 2 : Debug.Log("Stop him? I was talking to him last night, he seems pretty dead set on making it to Oregon."); //I need to stop him from getting somewhere.
                Q13Audio.Play();
                Answer = 0;
                QuestionCounter = 9;
                break;
            }
        }

        if(QuestionCounter == 8) { //Are you sure? I've lived here....
        clearQuestions();
        Q8.SetActive(true);
            switch(Answer) {
                case 1 : Debug.Log("Tom Mill...why does that name sound so familiar....Oh yeah! He was in here last night! Why are you looking for him?"); //Maybe I was a little too brash. I could actually use some help, I'm looking for a man named Tom Mill.
                Q7Audio.Play();
                Answer = 0;
                QuestionCounter = 7;
                break;
                case 2 : //yeah fuck you.
                Answer = 0;
                Score -= 3;
                break;
            }
        }

        if(QuestionCounter == 9) { // His wagon is out back
        clearQuestions();
        Q9.SetActive(true);
            switch(Answer) {
                case 2 : Debug.Log("Lucky for you that guy was kind of a dick last night. Trashed the place with his buddies and stiffed me on half his drinks. How can I help?"); //I need to make sure that wagon doesn't make it to Oregon, can you help me?
                Q14Audio.Play();
                Answer = 0;
                QuestionCounter = 10;
                break;
            }
        }

        if(QuestionCounter == 10) { //How can I help?
        clearQuestions();
        Q10.SetActive(true);
            switch(Answer) {
                case 1 : Debug.Log("Alright, I'll break that wagon. Make sure he's stuck here for a while at least."); //Make sure he doesn't leave this town.
                Q15Audio.Play();
                Answer = 0;
                QuestionCounter = 1000000;
                break;
                case 2 : Debug.Log("I don't know why but I feel inclined you help you. Alright, I'll challenge him to a duel tomorrow."); //Kill him for me.
                Q16Audio.Play();
                Answer = 0;
                QuestionCounter = 1000000;
                break;
            }
        }

        if(QuestionCounter == 1000000) {
            clearQuestions();
            Debug.Log("END OF DEMO");
            Timer = 8f;
            QuestionCounter = 1000000001;
        }

        if(Timer <= 1 && Timer > -1) {
            SceneManager.LoadScene("creditsMenu");
        }

        if(Score <= -3) {
            //bang.Play();
            clearQuestions();
            Retry.SetActive(true);
        }

        Timer = Timer - Time.deltaTime;
    }

    void nextQuestion() {
        Answer = 0;
        QuestionCounter += 1;
    }

    void clearQuestions() {
        Q1.SetActive(false);
        Q2.SetActive(false);
        Q3.SetActive(false);
        Q4.SetActive(false);
        Q5.SetActive(false);
        Q6.SetActive(false);
        Q7.SetActive(false);
        Q8.SetActive(false);
        Q9.SetActive(false);
        Q10.SetActive(false);
    }

    public void ButtonA() {
        Answer = 1;
    }

    public void ButtonB() {
        Answer = 2;
    }

    public void ButtonC() {
        Answer = 3;
    }

    public void ButtonRetry() {
        Retry.SetActive(false);
        QuestionCounter = 1;
        Answer = 0;
        Score = 0;
        Q0Audio.Play();
    }
}