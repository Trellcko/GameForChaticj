using UnityEngine;
using House312B.Core;
using House312B.Player;
using House312B.Utils;

public class TeleportAction : MonoBehaviour, IAction
{
    [SerializeField] private Transform _to;

    [SerializeField] private Transform _target;

    [Space]
    [Tooltip("if field _target is empty")]
    [SerializeField] private bool _shouldFindInteractingGO;

    private void Start()
    {
        QuickAssert.AssertIsNotNullAfterAssigment(_to);
        if (_shouldFindInteractingGO)
        {
            if (_target == null)
            {
                _target = FindObjectOfType<Interacting>().transform;
            }
            QuickAssert.AssertIsNotNullAfterFind(_target);
            return;
        }
        QuickAssert.AssertIsNotNullAfterAssigment(_target);

    }

    public void Do()
    {
        _target.position = _to.position;
    }
}
