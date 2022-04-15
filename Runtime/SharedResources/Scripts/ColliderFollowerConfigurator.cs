namespace Tilia.Trackers.ColliderFollower
{
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Operation.Extraction;
    using Zinnia.Extension;
    using Zinnia.Tracking.Follow;

    /// <summary>
    /// Sets up the ColliderFollower prefab based on the provided settings and implements the logic to follow the relevant source.
    /// </summary>
    public class ColliderFollowerConfigurator : MonoBehaviour
    {
        #region Facade Settings
        [Header("Facade Settings")]
        [Tooltip("The public interface facade.")]
        [SerializeField]
        [Restricted]
        private ColliderFollowerFacade facade;
        /// <summary>
        /// The public interface facade.
        /// </summary>
        public ColliderFollowerFacade Facade
        {
            get
            {
                return facade;
            }
            protected set
            {
                facade = value;
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The Zinnia.Tracking.Follow.ObjectFollower that performs the source follow.")]
        [SerializeField]
        [Restricted]
        private ObjectFollower objectFollower;
        /// <summary>
        /// The <see cref="Zinnia.Tracking.Follow.ObjectFollower"/> that performs the source follow.
        /// </summary>
        public ObjectFollower ObjectFollower
        {
            get
            {
                return objectFollower;
            }
            protected set
            {
                objectFollower = value;
            }
        }
        [Tooltip("The TransformPositionExtractor that extracts the source position.")]
        [SerializeField]
        [Restricted]
        private TransformPositionExtractor positionExtractor;
        /// <summary>
        /// The <see cref="TransformPositionExtractor"/> that extracts the source position.
        /// </summary>
        public TransformPositionExtractor PositionExtractor
        {
            get
            {
                return positionExtractor;
            }
            protected set
            {
                positionExtractor = value;
            }
        }
        [Tooltip("The GameObject containing the collider.")]
        [SerializeField]
        [Restricted]
        private GameObject colliderContainer;
        /// <summary>
        /// The <see cref="GameObject"/> containing the collider.
        /// </summary>
        public GameObject ColliderContainer
        {
            get
            {
                return colliderContainer;
            }
            protected set
            {
                colliderContainer = value;
            }
        }
        #endregion

        /// <summary>
        /// Sets the source on the relevant references.
        /// </summary>
        /// <param name="source">The source to set.</param>
        public virtual void SetSource(GameObject source)
        {
            ObjectFollower.Sources.RunWhenActiveAndEnabled(() => ObjectFollower.Sources.Clear());
            ObjectFollower.Sources.RunWhenActiveAndEnabled(() => ObjectFollower.Sources.Add(source));
            PositionExtractor.Source = source;
        }

        /// <summary>
        /// Snaps the tracked collider directly to the source current position.
        /// </summary>
        public virtual void SnapToSource()
        {
            PositionExtractor.DoExtract();
        }

        protected virtual void OnEnable()
        {
            SetSource(Facade.Source);
        }
    }
}