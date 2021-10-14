using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject phone;
    public Button PickUpPhoneButton;

    public void TriggerDialogue ()
    {
        phone.gameObject.SetActive(false);
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    public void TurnOffThePhone()
    {
        phone.gameObject.SetActive(false);
        PickUpPhoneButton.gameObject.SetActive(true);
    }

    public void TurnOnThePhone()
    {
        phone.gameObject.SetActive(true);
        PickUpPhoneButton.gameObject.SetActive(false);
    }

}
