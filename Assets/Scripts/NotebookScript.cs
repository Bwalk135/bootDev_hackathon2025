using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookScript : MonoBehaviour
{
    public GameObject homeController, notebookController;

    public void notebookButton()
    {
        notebookController.SetActive(true);
        homeController.SetActive(false);
    }

    public void backButton()
    {
        notebookController.SetActive(false );
        homeController.SetActive(true);
    }
}
