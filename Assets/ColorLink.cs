using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ColorLink : MonoBehaviour
{
    [SerializeField] TMP_Text textSource;
    [SerializeField] TMP_Text text;

    [SerializeField] SpriteRenderer spriteRenderSource;
    [SerializeField] SpriteRenderer spriteRender;

    public enum Type { Text, SpriteRender }
    public Type type;

    [SerializeField] PuzzleScoreText scoreText;

    private void Awake()
    {
    }

    private void OnEnable()
    {
        UpdateColor();
        switch (type)
        {
            case Type.Text:
                Debug.Log($"E {gameObject.name} Color {text.color} {textSource.color}");
                break;
            case Type.SpriteRender:
                Debug.Log($"E {gameObject.name} Color {spriteRender.color} {spriteRenderSource.color}");
                break;
        }
    }

    private void Update()
    {
        UpdateColor();
    }

    void OnSetupScore(int score) { UpdateColor(); }

    void UpdateColor()
    {
        switch (type)
        {
            case Type.Text:
                text.color = textSource.color;
                break;
            case Type.SpriteRender:
                spriteRender.color = spriteRenderSource.color;
                break;
        }
    }

    private void OnDestroy()
    {
    }

    private void OnDisable()
    {
        LogColor();
    }

    public void LogColor()
    {
        switch (type)
        {
            case Type.Text:
                Debug.Log($"{gameObject.name} Color {text.color} {textSource.color}");
                break;
            case Type.SpriteRender:
                Debug.Log($"{gameObject.name} Color {spriteRender.color} {spriteRenderSource.color}");
                break;
        }
    }
}
