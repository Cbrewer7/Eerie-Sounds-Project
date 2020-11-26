using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCDialog : MonoBehaviour
{

    public string[] lines;

    public TextMeshProUGUI DialogBox;

    public void Talk()
    {
        Debug.Log("Talking");
        StartCoroutine(Speak());
    }

    private IEnumerator Speak()
    {
        foreach (string line in lines)
        {
            char[] linechar = line.ToCharArray();
            foreach (char letter in linechar)
            {
                DialogBox.text += letter;
                yield return new WaitForSeconds(0.01f);
            }
            DialogBox.text += "\n";
        }
    }

}
