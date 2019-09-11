using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePanel : BasePanel
{
    private CanvasGroup canvasGroup;
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public override void OnEnter()
    {
        //throw new System.NotImplementedException();
    }

    public override void OnExit()
    {
        //throw new System.NotImplementedException();
    }

    public override void OnPause()
    {
        canvasGroup.blocksRaycasts = false;
        //throw new System.NotImplementedException();
    }

    public void OnPushPanel(string panelTypeString)
    {
        //UIPanelType panelType = (UIPanelType)System.Enum.Parse(typeof(UIPanelType), panelTypeString);
        UIPanelManager.Instance.PushPanel(panelTypeString);
    }

    public override void OnResume()
    {
        canvasGroup.blocksRaycasts = true;
        //throw new System.NotImplementedException();
    }
}
