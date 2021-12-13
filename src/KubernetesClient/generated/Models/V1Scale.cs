// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// Scale represents a scaling request for a resource.
    /// </summary>
    public partial class V1Scale
    {
        /// <summary>
        /// Initializes a new instance of the V1Scale class.
        /// </summary>
        public V1Scale()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1Scale class.
        /// </summary>
        /// <param name="apiVersion">
        /// APIVersion defines the versioned schema of this representation of an object.
        /// Servers should convert recognized schemas to the latest internal value, and may
        /// reject unrecognized values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </param>
        /// <param name="kind">
        /// Kind is a string value representing the REST resource this object represents.
        /// Servers may infer this from the endpoint the client submits requests to. Cannot
        /// be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </param>
        /// <param name="metadata">
        /// Standard object metadata; More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.
        /// </param>
        /// <param name="spec">
        /// defines the behavior of the scale. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status.
        /// </param>
        /// <param name="status">
        /// current status of the scale. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status.
        /// Read-only.
        /// </param>
        public V1Scale(string apiVersion = null, string kind = null, V1ObjectMeta metadata = null, V1ScaleSpec spec = null, V1ScaleStatus status = null)
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            Spec = spec;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object.
        /// Servers should convert recognized schemas to the latest internal value, and may
        /// reject unrecognized values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [JsonPropertyName("apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents.
        /// Servers may infer this from the endpoint the client submits requests to. Cannot
        /// be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Standard object metadata; More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.
        /// </summary>
        [JsonPropertyName("metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// defines the behavior of the scale. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status.
        /// </summary>
        [JsonPropertyName("spec")]
        public V1ScaleSpec Spec { get; set; }

        /// <summary>
        /// current status of the scale. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status.
        /// Read-only.
        /// </summary>
        [JsonPropertyName("status")]
        public V1ScaleStatus Status { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            Metadata?.Validate();
            Spec?.Validate();
            Status?.Validate();
        }
    }
}
