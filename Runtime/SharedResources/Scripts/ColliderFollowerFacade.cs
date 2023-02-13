namespace Tilia.Trackers.ColliderFollower
{
    using UnityEngine;
    using Zinnia.Data.Type;
    using Zinnia.Extension;

    /// <summary>
    /// The public interface for the ColliderFollower prefab.
    /// </summary>
    public class ColliderFollowerFacade : MonoBehaviour
    {
        #region Tracking Settings
        [Header("Tracking Settings")]
        [Tooltip("The source to track.")]
        [SerializeField]
        private GameObject source;
        /// <summary>
        /// The source to track.
        /// </summary>
        public GameObject Source
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterSourceChange();
                }
            }
        }
        [Tooltip("Whether to snap to source on enable.")]
        [SerializeField]
        private bool snapOnEnable;
        /// <summary>
        /// Whether to snap to source on enable.
        /// </summary>
        public bool SnapOnEnable
        {
            get
            {
                return snapOnEnable;
            }
            set
            {
                snapOnEnable = value;
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The linked Internal Setup.")]
        [SerializeField]
        private ColliderFollowerConfigurator configuration;
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        public ColliderFollowerConfigurator Configuration
        {
            get
            {
                return configuration;
            }
            protected set
            {
                configuration = value;
            }
        }
        [Tooltip("The GameObject reference for the nested Follow Tracking Container.")]
        [SerializeField]
        private ObjectReference linkedFollowTrackingContainer;
        /// <summary>
        /// The <see cref="GameObject"/> reference for the nested Follow Tracking Container.
        /// </summary>
        public ObjectReference LinkedFollowTrackingContainer
        {
            get
            {
                return linkedFollowTrackingContainer;
            }
            protected set
            {
                linkedFollowTrackingContainer = value;
            }
        }
        #endregion

        /// <summary>
        /// Clears <see cref="Source"/>.
        /// </summary>
        public virtual void ClearSource()
        {
            if (!this.IsValidState())
            {
                return;
            }

            Source = default;
        }

        /// <summary>
        /// Snaps the tracked collider directly to the source current position.
        /// </summary>
        public virtual void SnapToSource()
        {
            Configuration.SnapToSource();
        }

        /// <summary>
        /// Called after <see cref="Source"/> has been changed.
        /// </summary>
        protected virtual void OnAfterSourceChange()
        {
            Configuration.SetSource(Source);
        }
    }
}