using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Dialogue
{
    public string name;
    [TextArea(3, 10)]
    public string[] sentences;
    
    /*
    public TextMeshProUGUI textConponent;
    public string[] lines;
    public float textSpeed;

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        textConponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartDialogue()
    {
        index = 0;
        
        TypeLine();
    }

    IEnumerable TypeLine()
    {
        foreach(char c in  lines[index].ToCharArray())
        {
            textConponent.text += c;
            yield return new WaitForSeconds(textSpeed);

        }
    }*/
}
