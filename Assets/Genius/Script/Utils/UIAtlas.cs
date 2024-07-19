using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif


[ExecuteInEditMode]
public class UIAtlas : MonoBehaviour
{
    [SerializeField] private SpriteAtlas spriteatlas;
    private string[] spritenames;
    private Image uiimage;
    
    private void Start()
    {
        CheckComponentImage();

        Sprite[] sprites = new Sprite[spriteatlas.spriteCount];
        spriteatlas.GetSprites(sprites);
        spritenames = new string[sprites.Length];
        for (int i = 0; i < sprites.Length; i++)
        {
            spritenames[i] = sprites[i].name;
            Debug.Log(spritenames[i]);
        }
    }

    private void CheckComponentImage()
    {
        uiimage = GetComponent<Image>();
        if (uiimage == null)
        {
            uiimage = gameObject.AddComponent<Image>();
        }
    }

    #region Editor
    #if UNITY_EDITOR
    
    #endif
    #endregion
}