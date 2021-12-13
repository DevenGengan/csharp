// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// CustomResourceDefinitionSpec describes how a user wants their resource to appear
    /// </summary>
    public partial class V1CustomResourceDefinitionSpec
    {
        /// <summary>
        /// Initializes a new instance of the V1CustomResourceDefinitionSpec class.
        /// </summary>
        public V1CustomResourceDefinitionSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1CustomResourceDefinitionSpec class.
        /// </summary>
        /// <param name="group">
        /// group is the API group of the defined custom resource. The custom resources are
        /// served under `/apis/&lt;group&gt;/...`. Must match the name of the
        /// CustomResourceDefinition (in the form `&lt;names.plural&gt;.&lt;group&gt;`).
        /// </param>
        /// <param name="names">
        /// names specify the resource and kind names for the custom resource.
        /// </param>
        /// <param name="scope">
        /// scope indicates whether the defined custom resource is cluster- or
        /// namespace-scoped. Allowed values are `Cluster` and `Namespaced`.
        /// </param>
        /// <param name="versions">
        /// versions is the list of all API versions of the defined custom resource. Version
        /// names are used to compute the order in which served versions are listed in API
        /// discovery. If the version string is &quot;kube-like&quot;, it will sort above non
        /// &quot;kube-like&quot; version strings, which are ordered lexicographically. &quot;Kube-like&quot;
        /// versions start with a &quot;v&quot;, then are followed by a number (the major version),
        /// then optionally the string &quot;alpha&quot; or &quot;beta&quot; and another number (the minor
        /// version). These are sorted first by GA &gt; beta &gt; alpha (where GA is a version
        /// with no suffix such as beta or alpha), and then by comparing major version, then
        /// minor version. An example sorted list of versions: v10, v2, v1, v11beta2,
        /// v10beta3, v3beta1, v12alpha1, v11alpha2, foo1, foo10.
        /// </param>
        /// <param name="conversion">
        /// conversion defines conversion settings for the CRD.
        /// </param>
        /// <param name="preserveUnknownFields">
        /// preserveUnknownFields indicates that object fields which are not specified in
        /// the OpenAPI schema should be preserved when persisting to storage. apiVersion,
        /// kind, metadata and known fields inside metadata are always preserved. This field
        /// is deprecated in favor of setting `x-preserve-unknown-fields` to true in
        /// `spec.versions[*].schema.openAPIV3Schema`. See
        /// https://kubernetes.io/docs/tasks/access-kubernetes-api/custom-resources/custom-resource-definitions/#pruning-versus-preserving-unknown-fields
        /// for details.
        /// </param>
        public V1CustomResourceDefinitionSpec(string group, V1CustomResourceDefinitionNames names, string scope, IList<V1CustomResourceDefinitionVersion> versions, V1CustomResourceConversion conversion = null, bool? preserveUnknownFields = null)
        {
            Conversion = conversion;
            Group = group;
            Names = names;
            PreserveUnknownFields = preserveUnknownFields;
            Scope = scope;
            Versions = versions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// conversion defines conversion settings for the CRD.
        /// </summary>
        [JsonPropertyName("conversion")]
        public V1CustomResourceConversion Conversion { get; set; }

        /// <summary>
        /// group is the API group of the defined custom resource. The custom resources are
        /// served under `/apis/&lt;group&gt;/...`. Must match the name of the
        /// CustomResourceDefinition (in the form `&lt;names.plural&gt;.&lt;group&gt;`).
        /// </summary>
        [JsonPropertyName("group")]
        public string Group { get; set; }

        /// <summary>
        /// names specify the resource and kind names for the custom resource.
        /// </summary>
        [JsonPropertyName("names")]
        public V1CustomResourceDefinitionNames Names { get; set; }

        /// <summary>
        /// preserveUnknownFields indicates that object fields which are not specified in
        /// the OpenAPI schema should be preserved when persisting to storage. apiVersion,
        /// kind, metadata and known fields inside metadata are always preserved. This field
        /// is deprecated in favor of setting `x-preserve-unknown-fields` to true in
        /// `spec.versions[*].schema.openAPIV3Schema`. See
        /// https://kubernetes.io/docs/tasks/access-kubernetes-api/custom-resources/custom-resource-definitions/#pruning-versus-preserving-unknown-fields
        /// for details.
        /// </summary>
        [JsonPropertyName("preserveUnknownFields")]
        public bool? PreserveUnknownFields { get; set; }

        /// <summary>
        /// scope indicates whether the defined custom resource is cluster- or
        /// namespace-scoped. Allowed values are `Cluster` and `Namespaced`.
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// versions is the list of all API versions of the defined custom resource. Version
        /// names are used to compute the order in which served versions are listed in API
        /// discovery. If the version string is &quot;kube-like&quot;, it will sort above non
        /// &quot;kube-like&quot; version strings, which are ordered lexicographically. &quot;Kube-like&quot;
        /// versions start with a &quot;v&quot;, then are followed by a number (the major version),
        /// then optionally the string &quot;alpha&quot; or &quot;beta&quot; and another number (the minor
        /// version). These are sorted first by GA &gt; beta &gt; alpha (where GA is a version
        /// with no suffix such as beta or alpha), and then by comparing major version, then
        /// minor version. An example sorted list of versions: v10, v2, v1, v11beta2,
        /// v10beta3, v3beta1, v12alpha1, v11alpha2, foo1, foo10.
        /// </summary>
        [JsonPropertyName("versions")]
        public IList<V1CustomResourceDefinitionVersion> Versions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Names == null)
            {
                throw new ArgumentNullException("Names");    
            }
            Conversion?.Validate();
            Names?.Validate();
            if (Versions != null){
                foreach(var obj in Versions)
                {
                    obj.Validate();
                }
            }
        }
    }
}
