using System.Collections.Generic;
using UnityEngine;

public class MapPreviewController : MonoBehaviour
{
    public List<GameObject> PreviewPrefabs;

    public void ShowPreview(int index)
    {

        foreach (GameObject preview in PreviewPrefabs)
        {
            preview.SetActive(false);
        }
        
        
        PreviewPrefabs[index].SetActive(true);
        
    }
    
}
