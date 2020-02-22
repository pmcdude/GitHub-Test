using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabStateController : MonoBehaviour
{
    public Text PanelNameText;

    //State machine for tab views
    public enum TabState
    {
        Main, Research, Policies, Funding, PowerPlants, Glossary
    }

    //Used for single instance of UIController
    public static TabStateController instance;

    //Current state
    public static TabState CurrentTabState;

    //Panel reference for states
    public GameObject MainPanel;
    public GameObject ResearchPanel;
    public GameObject PoliciesPanel;
    public GameObject FundingPanel;
    public GameObject PowerPlantsPanel;
    public GameObject GlossaryPanel;

    private void Awake()
    {
        CurrentTabState = TabState.Main;
        PanelNameText.text = "Dashboard";
    }

    //TabState machine
    void onShowResearch()
    {
        CurrentTabState = TabState.Research;
        ResearchPanel.SetActive(true);
        //Hide others
        PoliciesPanel.SetActive(false);
        FundingPanel.SetActive(false);
        PowerPlantsPanel.SetActive(false);
        GlossaryPanel.SetActive(false);
        MainPanel.SetActive(false);
        PanelNameText.text = "Research";
    }

    void onShowPolicies()
    {
        CurrentTabState = TabState.Policies;
        PoliciesPanel.SetActive(true);
        //Hide others
        ResearchPanel.SetActive(false);
        FundingPanel.SetActive(false);
        PowerPlantsPanel.SetActive(false);
        GlossaryPanel.SetActive(false);
        MainPanel.SetActive(false);
        PanelNameText.text = "Policies";
    }

    void onShowFunding()
    {
        CurrentTabState = TabState.Funding;
        FundingPanel.SetActive(true);
        //Hide others
        PoliciesPanel.SetActive(false);
        PoliciesPanel.SetActive(false);
        PowerPlantsPanel.SetActive(false);
        GlossaryPanel.SetActive(false);
        MainPanel.SetActive(false);
        PanelNameText.text = "Funding";
    }

    void onShowPowerPlants()
    {
        CurrentTabState = TabState.PowerPlants;
        PowerPlantsPanel.SetActive(true);
        //Hide others
        PoliciesPanel.SetActive(false);
        FundingPanel.SetActive(false);
        FundingPanel.SetActive(false);
        GlossaryPanel.SetActive(false);
        MainPanel.SetActive(false);
        PanelNameText.text = "Power Plants";
    }

    void onShowGlossary()
    {
        CurrentTabState = TabState.Glossary;
        GlossaryPanel.SetActive(true);
        //Hide others
        PoliciesPanel.SetActive(false);
        FundingPanel.SetActive(false);
        FundingPanel.SetActive(false);
        PowerPlantsPanel.SetActive(false);
        MainPanel.SetActive(false);
        PanelNameText.text = "Glossary";
    }

    void onShowMain()
    {
        CurrentTabState = TabState.Main;
        MainPanel.SetActive(true);
        //Hide others
        ResearchPanel.SetActive(false);
        PoliciesPanel.SetActive(false);
        FundingPanel.SetActive(false);
        PowerPlantsPanel.SetActive(false);
        GlossaryPanel.SetActive(false);
        PanelNameText.text = "Dashboard";
    }

    public void onClickResearch()
    {
        if (CurrentTabState != TabState.Research)
            onShowResearch();
        else
            onShowMain();
    }

    public void onClickPolicies()
    {
        if (CurrentTabState != TabState.Policies)
            onShowPolicies();
        else
            onShowMain();
    }

    public void onClickFunding()
    {
        if (CurrentTabState != TabState.Funding)
            onShowFunding();
        else
            onShowMain();
    }

    public void onClickPowerPlants()
    {
        if (CurrentTabState != TabState.PowerPlants)
            onShowPowerPlants();
        else
            onShowMain();
    }

    public void onClickGlossary()
    {
        if (CurrentTabState != TabState.Glossary)
            onShowGlossary();
        else
            onShowMain();
    }
}
