using UnityEngine;

public class Singletone<T> : MonoBehaviour where T : MonoBehaviour
{
    // private으로 인스턴스 조정 못하게 하기
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                // 씬에서 찾기
                _instance = FindObjectOfType<T>();
                if (_instance == null)
                {
                    // 씬에 없으면 새로 생성
                    GameObject singletonObject = new GameObject(typeof(T).Name);
                    _instance = singletonObject.AddComponent<T>();
                    DontDestroyOnLoad(singletonObject); // 씬 전환 시에도 유지
                }

            }
            
            return _instance;
        }
    }

    //awake 메서드에서 인스턴스가 중복 생성되지 않도록 설정
    protected virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = this as T;
        }
        else if(_instance != this)
        {
            Destroy(gameObject); // 중복 인스턴스 제거
        }
    }
}

