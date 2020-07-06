using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PuzzleScoreText : DamageFloatText
{
    public struct ScoreData
    {
        public int number;
        public int gem;

        public ScoreData(int number, int gem)
        {
            this.number = number;
            this.gem = gem;
        }
    }

    [SerializeField] List<GameObject> complimentTextSprites; //show the text good, perfect etc. next to score
    [SerializeField] TMP_Text[] gemTexts;

    [SerializeField] SpriteRenderer complimentSpriteRender;
    [SerializeField] List<Sprite> complimentSprites;
    [SerializeField] TMP_Text gemText;

    //[SerializeField] SpriteRenderer complimentTextSpr;

    protected override void OnEnable()
    {
        base.OnEnable();
        //transform.localScale = Vector3.zero;
        //transform.DOScale(1f, 0.3f);
    }

    public void SetupScore(ScoreData scoreData)
    {
        SetText(scoreData.number);
        int complimentId = 0;

        //for (int i = 0; i < complimentTextSprites.Count; i++)
        //{
        //    if (i == complimentId) complimentTextSprites[i].SetActive(true);
        //    else complimentTextSprites[i].SetActive(false);
        //}

        complimentSpriteRender.sprite = complimentSprites[complimentId];
        gemText.text = scoreData.gem > 0 ? $"+{scoreData.gem}<sprite=\"diamond\" index=0>" : string.Empty;

    }
}
