using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FileEmulationScript : MonoBehaviour
{
    #region variables
    public GameObject baseFolderStack, modelStack, backButton;
    public Text contentText;

    private int numOfBaseFolders = 9;
    private List<GameObject> folders = new List<GameObject>();
    private List<GameObject> models = new List<GameObject>();
    private bool foldersHidden = false;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 9; i++)
        {
            folders.Add(baseFolderStack.transform.GetChild(i).gameObject);
            folders[i].GetComponentInChildren<Text>().text = "Folder" + (i + 1).ToString();
            models.Add(modelStack.transform.GetChild(i).gameObject);
        }
    }

    public void clickReceive(int num)
    {
        switch (foldersHidden)
        {
            case false:
                //  deactivate all other folders
                for (int i = 0; i < 9; i++)
                {
                    baseFolderStack.transform.GetChild(i).gameObject.SetActive(false);
                }
                backButton.gameObject.SetActive(true);
                models[num].gameObject.SetActive(true);
                foldersHidden = true;
                break;
            case true:
                //  activate all other folders
                for (int i = 0; i < 9; i++)
                {
                    baseFolderStack.transform.GetChild(i).gameObject.SetActive(true);
                }
                for(int i = 0; i < 9; i++)
                {
                    if (models[i].gameObject.activeInHierarchy)
                    {
                        models[i].gameObject.SetActive(false);
                        break;
                    }
                }
                backButton.gameObject.SetActive(false);
                foldersHidden = false;
                break;
        }
    }
}
