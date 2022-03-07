using UnityEngine;
using House312B.Core;
using House312B.DialogSystem;
using House312B.Utils;

public class ResetDialogAction : MonoBehaviour, IAction
{
    [SerializeField] private Dialog _dialog;

    private void Start()
    {
        QuickAssert.AssertIsNotNullAfterAssigment(_dialog);    
    }

    public void Do()
    {
        _dialog.ResetIndex();
    }
}
