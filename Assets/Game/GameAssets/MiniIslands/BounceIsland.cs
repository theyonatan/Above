using UnityEngine;
using MoreMountains.Feedbacks;

public class BounceIsland : MonoBehaviour
{
    private bool _timeout;
    [SerializeField] private MMF_Player feedbackPlayer;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Bounce Island");
        if (_timeout) return;
        if (!other.CompareTag("Player")) return;
        if (feedbackPlayer.IsPlaying) return;
        
        feedbackPlayer?.PlayFeedbacks();
        _timeout = true;
    }

    public void OnFeedbackComplete()
    {
        _timeout = false;
    }
}
