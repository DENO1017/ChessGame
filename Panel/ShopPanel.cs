using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopPanel : BasePanel
{
    private CanvasGroup canvasGroup;

    void Start()
    {
        if (canvasGroup == null) canvasGroup = GetComponent<CanvasGroup>();
    }
    public override void OnEnter()
    {
        if (canvasGroup == null) canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 1;
        canvasGroup.blocksRaycasts = true;
        //throw new System.NotImplementedException();
    }

    public override void OnExit()
    {
        canvasGroup.alpha = 0;
        canvasGroup.blocksRaycasts = false;
    }

    public override void OnPause()
    {
        throw new System.NotImplementedException();
    }

    public override void OnResume()
    {
        throw new System.NotImplementedException();
    }
    public void OnClosePanel()
    {
        UIPanelManager.Instance.PopPanel();
    }
    public void ChessMessage()
    {
        Text name;
        name = GameObject.Find("Canvas/GamePanel(Clone)/Down/Name").GetComponent<Text>();
        name.text = "名称";

        Image im;
        im = GameObject.Find("Canvas/GamePanel(Clone)/Down/ChessImage").GetComponent<Image>();
        im.sprite = Resources.Load("UI/chess", typeof(Sprite)) as Sprite;
    }
}
