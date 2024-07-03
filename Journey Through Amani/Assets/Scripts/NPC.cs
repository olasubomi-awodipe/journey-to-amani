using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPC : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TMP_Text dialogueText;
    public string[] dialogue;
    public Image dialogueImage;
    public Sprite npcImage;
    public TMP_Text npcNameText;
    public GameObject interactionPrompt;

    private int index;
    public float wordSpeed = 0.05f;
    public bool playerIsClose;
    public GameObject continueButton;

    void Start()
    {
        // Ensure the dialogue panel and image are hidden initially
        if (dialoguePanel != null)
        {
            dialoguePanel.SetActive(false);
        }
        if (dialogueImage != null)
        {
            dialogueImage.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) && playerIsClose)
        {
            if (dialoguePanel != null && dialoguePanel.activeInHierarchy)
            {
                zeroText();
            }
            else if (dialoguePanel != null)
            {
                dialoguePanel.SetActive(true);
                if (dialogueImage != null && npcImage != null)
                {
                    dialogueImage.sprite = npcImage;
                    dialogueImage.gameObject.SetActive(true);
                }
                if (npcNameText != null)
                {
                    npcNameText.text = gameObject.name; // Assign NPC's name to text component
                }
                StartCoroutine(Typing());
            }
        }

        if (dialogueText != null && dialogue != null && index < dialogue.Length && dialogueText.text == dialogue[index])
        {
            if (continueButton != null)
            {
                continueButton.SetActive(true);
            }
        }
    }

    public void zeroText()
    {
        if (dialogueText != null)
        {
            dialogueText.text = "";
        }
        index = 0;
        if (dialoguePanel != null)
        {
            dialoguePanel.SetActive(false);
        }
        if (dialogueImage != null)
        {
            dialogueImage.gameObject.SetActive(false);
        }
    }

    IEnumerator Typing()
    {
        if (dialogueText != null && dialogue != null && index < dialogue.Length)
        {
            dialogueText.text = "";  // Clear previous text before starting
            foreach (char letter in dialogue[index].ToCharArray())
            {
                dialogueText.text += letter;
                yield return new WaitForSeconds(wordSpeed);
            }
        }
    }

    public void NextLine()
    {
        if (continueButton != null)
        {
            continueButton.SetActive(false);
        }

        if (index < dialogue.Length - 1)
        {
            index++;
            StartCoroutine(Typing());
        }
        else
        {
            zeroText();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
            if (interactionPrompt != null)
            {
                interactionPrompt.gameObject.SetActive(true);  // Show the prompt
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            zeroText();
            if (interactionPrompt != null)
            {
                interactionPrompt.gameObject.SetActive(false);  // Hide the prompt
            }
        }
    }
}
