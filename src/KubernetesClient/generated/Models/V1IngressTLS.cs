// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// IngressTLS describes the transport layer security associated with an Ingress.
    /// </summary>
    public partial class V1IngressTLS
    {
        /// <summary>
        /// Initializes a new instance of the V1IngressTLS class.
        /// </summary>
        public V1IngressTLS()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1IngressTLS class.
        /// </summary>
        /// <param name="hosts">
        /// Hosts are a list of hosts included in the TLS certificate. The values in this
        /// list must match the name/s used in the tlsSecret. Defaults to the wildcard host
        /// setting for the loadbalancer controller fulfilling this Ingress, if left
        /// unspecified.
        /// </param>
        /// <param name="secretName">
        /// SecretName is the name of the secret used to terminate TLS traffic on port 443.
        /// Field is left optional to allow TLS routing based on SNI hostname alone. If the
        /// SNI host in a listener conflicts with the &quot;Host&quot; header field used by an
        /// IngressRule, the SNI host is used for termination and value of the Host header
        /// is used for routing.
        /// </param>
        public V1IngressTLS(IList<string> hosts = null, string secretName = null)
        {
            Hosts = hosts;
            SecretName = secretName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Hosts are a list of hosts included in the TLS certificate. The values in this
        /// list must match the name/s used in the tlsSecret. Defaults to the wildcard host
        /// setting for the loadbalancer controller fulfilling this Ingress, if left
        /// unspecified.
        /// </summary>
        [JsonPropertyName("hosts")]
        public IList<string> Hosts { get; set; }

        /// <summary>
        /// SecretName is the name of the secret used to terminate TLS traffic on port 443.
        /// Field is left optional to allow TLS routing based on SNI hostname alone. If the
        /// SNI host in a listener conflicts with the &quot;Host&quot; header field used by an
        /// IngressRule, the SNI host is used for termination and value of the Host header
        /// is used for routing.
        /// </summary>
        [JsonPropertyName("secretName")]
        public string SecretName { get; set; }

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
