using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void OpenReadyToProvideAService()
    {
        SceneManager.LoadScene("ReadyToProvideAService");
    }

    public void OpenFoundWork()
    {
        SceneManager.LoadScene("FoundSpeal");
    }

}