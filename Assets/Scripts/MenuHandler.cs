using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class MenuHandler : MonoBehaviour
{
    public TMP_InputField input;

    // Start is called before the first frame update
    void Start()
    {
        input.onEndEdit.AddListener(SubmitName);
    }

    public void StartNew()
    {
        SceneManager.LoadScene(0);
    }

    public void SubmitName(string name)
    {
        ScoreManager.Instance.CurrentName = name;
    }
}
