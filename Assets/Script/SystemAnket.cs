using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SystemAnket : MonoBehaviour
{
  public InputField _InputField;
  public Text TextAnketa;

  private void Start()
  {
    _InputField.GetComponent<InputField>();
    TextAnketa.GetComponent<Text>();
  }

  public void EndWrite()
  {
    TextAnketa.text = _InputField.text;
    SceneManager.LoadScene("AnketaPublished");
  }
}
