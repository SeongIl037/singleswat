using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManger : Singletone<StageManger>
{
    public readonly int RespawnPoint;
    protected override void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        base.Awake();
    }
    // 다음 씬으로 보내주기
    public void LoadQuests(int questID)
    {
        SceneManager.LoadScene(questID);
    }
}
