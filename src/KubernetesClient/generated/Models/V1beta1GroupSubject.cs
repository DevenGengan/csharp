// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// GroupSubject holds detailed information for group-kind subject.
    /// </summary>
    public partial class V1beta1GroupSubject
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1GroupSubject class.
        /// </summary>
        public V1beta1GroupSubject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1GroupSubject class.
        /// </summary>
        /// <param name="name">
        /// name is the user group that matches, or &quot;*&quot; to match all user groups. See
        /// https://github.com/kubernetes/apiserver/blob/master/pkg/authentication/user/user.go
        /// for some well-known group names. Required.
        /// </param>
        public V1beta1GroupSubject(string name)
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// name is the user group that matches, or &quot;*&quot; to match all user groups. See
        /// https://github.com/kubernetes/apiserver/blob/master/pkg/authentication/user/user.go
        /// for some well-known group names. Required.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

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
