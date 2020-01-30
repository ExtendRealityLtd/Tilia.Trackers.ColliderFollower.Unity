namespace Tilia.Trackers.ColliderFollower
{
    using Malimbe.MemberChangeMethod;
    using Malimbe.MemberClearanceMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using Zinnia.Data.Attribute;

    /// <summary>
    /// The public interface for the ColliderFollower prefab.
    /// </summary>
    public class ColliderFollowerFacade : MonoBehaviour
    {
        #region Tracking Settings
        /// <summary>
        /// The source to track.
        /// </summary>
        [Serialized, Cleared]
        [field: Header("Tracking Settings"), DocumentedByXml]
        public GameObject Source { get; set; }
        #endregion

        #region Reference Settings
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        [Serialized]
        [field: Header("Reference Settings"), DocumentedByXml, Restricted]
        public ColliderFollowerConfigurator Configuration { get; protected set; }
        #endregion

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
        [CalledAfterChangeOf(nameof(Source))]
        protected virtual void OnAfterSourceChange()
        {
            Configuration.SetSource(Source);
        }
    }
}