using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public string[] sentences;
    public GameObject dialogueBox;
    public GameObject phone;
    public Text name;
    public Text dialogueSentence;
    public Button button1;
    public Button button2;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new string[6];

    }

    public void StartDialogue(Dialogue dialogue)
    {
        for (int i = 0; i < 6; i++)
            sentences[i] = dialogue.sentences[i];
        name.text = dialogue.name;
        dialogueSentence.text = sentences[0];
        button1.gameObject.SetActive(true);
        button2.gameObject.SetActive(true);
        button1.GetComponentInChildren<Text>().text = sentences[1];
        button2.GetComponentInChildren<Text>().text = sentences[2];
        dialogueBox.gameObject.SetActive(true);
    }

    public void AnswerA()
    {
        dialogueSentence.text = sentences[3];
        button1.gameObject.SetActive(false);
        button2.GetComponentInChildren<Text>().text = sentences[5];
    }

    public void AnswerB()
    {
        if(button2.GetComponentInChildren<Text>().text == sentences[2])
        {
            dialogueSentence.text = sentences[4];
            button1.gameObject.SetActive(false);
            button2.GetComponentInChildren<Text>().text = sentences[5];
        }
        else
        {
            dialogueBox.gameObject.SetActive(false);
            phone.gameObject.SetActive(true);
        }
    }
}
