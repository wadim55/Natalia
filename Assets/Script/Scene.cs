using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void OpenReadyToProvideAService()
    {
        SceneManager.LoadScene("ReadyToProvideAService");
    }
    public void OpenSampleScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OpenFoundWork()
    {
        SceneManager.LoadScene("FoundSpeal");
    }

    public void OpenQuestionnaire()
    {
        SceneManager.LoadScene("Questionnaire"); 
    }
    
    
}