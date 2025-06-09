using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Map : UI_PopUp
{
    
    public void OnStage(int stage)
    {
        SceneManager.LoadScene(stage);
    }
}
