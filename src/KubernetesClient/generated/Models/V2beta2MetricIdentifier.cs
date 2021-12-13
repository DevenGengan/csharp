// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// MetricIdentifier defines the name and optionally selector for a metric
    /// </summary>
    public partial class V2beta2MetricIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the V2beta2MetricIdentifier class.
        /// </summary>
        public V2beta2MetricIdentifier()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V2beta2MetricIdentifier class.
        /// </summary>
        /// <param name="name">
        /// name is the name of the given metric
        /// </param>
        /// <param name="selector">
        /// selector is the string-encoded form of a standard kubernetes label selector for
        /// the given metric When set, it is passed as an additional parameter to the
        /// metrics server for more specific metrics scoping. When unset, just the
        /// metricName will be used to gather metrics.
        /// </param>
        public V2beta2MetricIdentifier(string name, V1LabelSelector selector = null)
        {
            Name = name;
            Selector = selector;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// name is the name of the given metric
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// selector is the string-encoded form of a standard kubernetes label selector for
        /// the given metric When set, it is passed as an additional parameter to the
        /// metrics server for more specific metrics scoping. When unset, just the
        /// metricName will be used to gather metrics.
        /// </summary>
        [JsonPropertyName("selector")]
        public V1LabelSelector Selector { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            Selector?.Validate();
        }
    }
}
