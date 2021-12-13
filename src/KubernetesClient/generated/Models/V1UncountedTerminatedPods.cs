// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// UncountedTerminatedPods holds UIDs of Pods that have terminated but haven&apos;t been
        /// accounted in Job status counters.
    /// </summary>
    public partial class V1UncountedTerminatedPods
    {
        /// <summary>
        /// Initializes a new instance of the V1UncountedTerminatedPods class.
        /// </summary>
        public V1UncountedTerminatedPods()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1UncountedTerminatedPods class.
        /// </summary>
        /// <param name="failed">
        /// Failed holds UIDs of failed Pods.
        /// </param>
        /// <param name="succeeded">
        /// Succeeded holds UIDs of succeeded Pods.
        /// </param>
        public V1UncountedTerminatedPods(IList<string> failed = null, IList<string> succeeded = null)
        {
            Failed = failed;
            Succeeded = succeeded;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Failed holds UIDs of failed Pods.
        /// </summary>
        [JsonPropertyName("failed")]
        public IList<string> Failed { get; set; }

        /// <summary>
        /// Succeeded holds UIDs of succeeded Pods.
        /// </summary>
        [JsonPropertyName("succeeded")]
        public IList<string> Succeeded { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
