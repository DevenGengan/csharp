// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// CSIDriver captures information about a Container Storage Interface (CSI) volume
        /// driver deployed on the cluster. Kubernetes attach detach controller uses this
        /// object to determine whether attach is required. Kubelet uses this object to
        /// determine whether pod information needs to be passed on mount. CSIDriver objects
        /// are non-namespaced.
    /// </summary>
    public partial class V1CSIDriver
    {
        /// <summary>
        /// Initializes a new instance of the V1CSIDriver class.
        /// </summary>
        public V1CSIDriver()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1CSIDriver class.
        /// </summary>
        /// <param name="spec">
        /// Specification of the CSI Driver.
        /// </param>
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
        /// Standard object metadata. metadata.Name indicates the name of the CSI driver
        /// that this object refers to; it MUST be the same name returned by the CSI
        /// GetPluginName() call for that driver. The driver name must be 63 characters or
        /// less, beginning and ending with an alphanumeric character ([a-z0-9A-Z]) with
        /// dashes (-), dots (.), and alphanumerics between. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </param>
        public V1CSIDriver(V1CSIDriverSpec spec, string apiVersion = null, string kind = null, V1ObjectMeta metadata = null)
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            Spec = spec;
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
        /// Standard object metadata. metadata.Name indicates the name of the CSI driver
        /// that this object refers to; it MUST be the same name returned by the CSI
        /// GetPluginName() call for that driver. The driver name must be 63 characters or
        /// less, beginning and ending with an alphanumeric character ([a-z0-9A-Z]) with
        /// dashes (-), dots (.), and alphanumerics between. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </summary>
        [JsonPropertyName("metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Specification of the CSI Driver.
        /// </summary>
        [JsonPropertyName("spec")]
        public V1CSIDriverSpec Spec { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Spec == null)
            {
                throw new ArgumentNullException("Spec");    
            }
            Metadata?.Validate();
            Spec?.Validate();
        }
    }
}
