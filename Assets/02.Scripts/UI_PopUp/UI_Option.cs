using UnityEngine;

public class UI_Option : UI_PopUp
{
    public void OnClickContinue()
    {
        Close();
    }

    public void OnClickQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit(); // 어플리케이션 종료
#endif
    }

    public void OnClickMain()
    {
        Debug.Log("main");
    }
}
