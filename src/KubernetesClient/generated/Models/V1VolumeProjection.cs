// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// Projection that may be projected along with other supported volume types
    /// </summary>
    public partial class V1VolumeProjection
    {
        /// <summary>
        /// Initializes a new instance of the V1VolumeProjection class.
        /// </summary>
        public V1VolumeProjection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1VolumeProjection class.
        /// </summary>
        /// <param name="configMap">
        /// information about the configMap data to project
        /// </param>
        /// <param name="downwardAPI">
        /// information about the downwardAPI data to project
        /// </param>
        /// <param name="secret">
        /// information about the secret data to project
        /// </param>
        /// <param name="serviceAccountToken">
        /// information about the serviceAccountToken data to project
        /// </param>
        public V1VolumeProjection(V1ConfigMapProjection configMap = null, V1DownwardAPIProjection downwardAPI = null, V1SecretProjection secret = null, V1ServiceAccountTokenProjection serviceAccountToken = null)
        {
            ConfigMap = configMap;
            DownwardAPI = downwardAPI;
            Secret = secret;
            ServiceAccountToken = serviceAccountToken;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// information about the configMap data to project
        /// </summary>
        [JsonPropertyName("configMap")]
        public V1ConfigMapProjection ConfigMap { get; set; }

        /// <summary>
        /// information about the downwardAPI data to project
        /// </summary>
        [JsonPropertyName("downwardAPI")]
        public V1DownwardAPIProjection DownwardAPI { get; set; }

        /// <summary>
        /// information about the secret data to project
        /// </summary>
        [JsonPropertyName("secret")]
        public V1SecretProjection Secret { get; set; }

        /// <summary>
        /// information about the serviceAccountToken data to project
        /// </summary>
        [JsonPropertyName("serviceAccountToken")]
        public V1ServiceAccountTokenProjection ServiceAccountToken { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            ConfigMap?.Validate();
            DownwardAPI?.Validate();
            Secret?.Validate();
            ServiceAccountToken?.Validate();
        }
    }
}
