using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameRoot : MonoBehaviour {

	void Start () {
        UIPanelManager panelManager = UIPanelManager.Instance;
        panelManager.PushPanel(UIPanelType.Game);
	}
}
