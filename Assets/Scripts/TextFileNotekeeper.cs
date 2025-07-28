using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine.UI;

public class TextFileNotekeeper : MonoBehaviour
{
    private string contentDate = "Date " + System.DateTime.Now + "\n";
    private string content;
    private string path;

    [SerializeField] TMP_InputField inputFieldNotebook;
    [SerializeField] TextMeshProUGUI notebookTextLog;

    void createText()
    {
        //path of the file
        path = Application.dataPath + "/NotebookLog.txt";

        //create file if it doesn't exist
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Notebook Log \n\n");
        }

        //content for file based on user input
         //content = "Login" + contentDate;

        //add user input to it
        File.AppendAllText(path, content);

        notebookTextLog.text = content;
    }

    public void notebookEntry()
    {
        //content = inputFieldNotebook.text + File.ReadAllText(path, content);
    }

    private void Start()
    {
        createText();
    }
}
