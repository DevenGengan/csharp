// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// LimitResponse defines how to handle requests that can not be executed right now.
    /// </summary>
    public partial class V1beta1LimitResponse
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1LimitResponse class.
        /// </summary>
        public V1beta1LimitResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1LimitResponse class.
        /// </summary>
        /// <param name="type">
        /// `type` is &quot;Queue&quot; or &quot;Reject&quot;. &quot;Queue&quot; means that requests that can not be
        /// executed upon arrival are held in a queue until they can be executed or a
        /// queuing limit is reached. &quot;Reject&quot; means that requests that can not be executed
        /// upon arrival are rejected. Required.
        /// </param>
        /// <param name="queuing">
        /// `queuing` holds the configuration parameters for queuing. This field may be
        /// non-empty only if `type` is `&quot;Queue&quot;`.
        /// </param>
        public V1beta1LimitResponse(string type, V1beta1QueuingConfiguration queuing = null)
        {
            Queuing = queuing;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// `queuing` holds the configuration parameters for queuing. This field may be
        /// non-empty only if `type` is `&quot;Queue&quot;`.
        /// </summary>
        [JsonPropertyName("queuing")]
        public V1beta1QueuingConfiguration Queuing { get; set; }

        /// <summary>
        /// `type` is &quot;Queue&quot; or &quot;Reject&quot;. &quot;Queue&quot; means that requests that can not be
        /// executed upon arrival are held in a queue until they can be executed or a
        /// queuing limit is reached. &quot;Reject&quot; means that requests that can not be executed
        /// upon arrival are rejected. Required.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            Queuing?.Validate();
        }
    }
}
