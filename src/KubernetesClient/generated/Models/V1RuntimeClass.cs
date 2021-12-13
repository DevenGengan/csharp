// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// RuntimeClass defines a class of container runtime supported in the cluster. The
        /// RuntimeClass is used to determine which container runtime is used to run all
        /// containers in a pod. RuntimeClasses are manually defined by a user or cluster
        /// provisioner, and referenced in the PodSpec. The Kubelet is responsible for
        /// resolving the RuntimeClassName reference before running the pod.  For more
        /// details, see https://kubernetes.io/docs/concepts/containers/runtime-class/
    /// </summary>
    public partial class V1RuntimeClass
    {
        /// <summary>
        /// Initializes a new instance of the V1RuntimeClass class.
        /// </summary>
        public V1RuntimeClass()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1RuntimeClass class.
        /// </summary>
        /// <param name="handler">
        /// Handler specifies the underlying runtime and configuration that the CRI
        /// implementation will use to handle pods of this class. The possible values are
        /// specific to the node &amp; CRI configuration.  It is assumed that all handlers are
        /// available on every node, and handlers of the same name are equivalent on every
        /// node. For example, a handler called &quot;runc&quot; might specify that the runc OCI
        /// runtime (using native Linux containers) will be used to run the containers in a
        /// pod. The Handler must be lowercase, conform to the DNS Label (RFC 1123)
        /// requirements, and is immutable.
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
        /// More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </param>
        /// <param name="overhead">
        /// Overhead represents the resource overhead associated with running a pod for a
        /// given RuntimeClass. For more details, see
        /// https://kubernetes.io/docs/concepts/scheduling-eviction/pod-overhead/
        /// This field is in beta starting v1.18 and is only honored by servers that enable
        /// the PodOverhead feature.
        /// </param>
        /// <param name="scheduling">
        /// Scheduling holds the scheduling constraints to ensure that pods running with
        /// this RuntimeClass are scheduled to nodes that support it. If scheduling is nil,
        /// this RuntimeClass is assumed to be supported by all nodes.
        /// </param>
        public V1RuntimeClass(string handler, string apiVersion = null, string kind = null, V1ObjectMeta metadata = null, V1Overhead overhead = null, V1Scheduling scheduling = null)
        {
            ApiVersion = apiVersion;
            Handler = handler;
            Kind = kind;
            Metadata = metadata;
            Overhead = overhead;
            Scheduling = scheduling;
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
        /// Handler specifies the underlying runtime and configuration that the CRI
        /// implementation will use to handle pods of this class. The possible values are
        /// specific to the node &amp; CRI configuration.  It is assumed that all handlers are
        /// available on every node, and handlers of the same name are equivalent on every
        /// node. For example, a handler called &quot;runc&quot; might specify that the runc OCI
        /// runtime (using native Linux containers) will be used to run the containers in a
        /// pod. The Handler must be lowercase, conform to the DNS Label (RFC 1123)
        /// requirements, and is immutable.
        /// </summary>
        [JsonPropertyName("handler")]
        public string Handler { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents.
        /// Servers may infer this from the endpoint the client submits requests to. Cannot
        /// be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </summary>
        [JsonPropertyName("metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Overhead represents the resource overhead associated with running a pod for a
        /// given RuntimeClass. For more details, see
        /// https://kubernetes.io/docs/concepts/scheduling-eviction/pod-overhead/
        /// This field is in beta starting v1.18 and is only honored by servers that enable
        /// the PodOverhead feature.
        /// </summary>
        [JsonPropertyName("overhead")]
        public V1Overhead Overhead { get; set; }

        /// <summary>
        /// Scheduling holds the scheduling constraints to ensure that pods running with
        /// this RuntimeClass are scheduled to nodes that support it. If scheduling is nil,
        /// this RuntimeClass is assumed to be supported by all nodes.
        /// </summary>
        [JsonPropertyName("scheduling")]
        public V1Scheduling Scheduling { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            Metadata?.Validate();
            Overhead?.Validate();
            Scheduling?.Validate();
        }
    }
}
