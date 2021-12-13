// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// UserInfo holds the information about the user needed to implement the user.Info
        /// interface.
    /// </summary>
    public partial class V1UserInfo
    {
        /// <summary>
        /// Initializes a new instance of the V1UserInfo class.
        /// </summary>
        public V1UserInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1UserInfo class.
        /// </summary>
        /// <param name="extra">
        /// Any additional information provided by the authenticator.
        /// </param>
        /// <param name="groups">
        /// The names of groups this user is a part of.
        /// </param>
        /// <param name="uid">
        /// A unique value that identifies this user across time. If this user is deleted
        /// and another user by the same name is added, they will have different UIDs.
        /// </param>
        /// <param name="username">
        /// The name that uniquely identifies this user among all active users.
        /// </param>
        public V1UserInfo(IDictionary<string, IList<string>> extra = null, IList<string> groups = null, string uid = null, string username = null)
        {
            Extra = extra;
            Groups = groups;
            Uid = uid;
            Username = username;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Any additional information provided by the authenticator.
        /// </summary>
        [JsonPropertyName("extra")]
        public IDictionary<string, IList<string>> Extra { get; set; }

        /// <summary>
        /// The names of groups this user is a part of.
        /// </summary>
        [JsonPropertyName("groups")]
        public IList<string> Groups { get; set; }

        /// <summary>
        /// A unique value that identifies this user across time. If this user is deleted
        /// and another user by the same name is added, they will have different UIDs.
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// The name that uniquely identifies this user among all active users.
        /// </summary>
        [JsonPropertyName("username")]
        public string Username { get; set; }

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
