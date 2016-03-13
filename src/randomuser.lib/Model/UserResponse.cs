using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class UserResponse :  IEquatable<UserResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponse" /> class.
        /// Initializes a new instance of the <see cref="UserResponse" />class.
        /// </summary>
        /// <param name="Results">Results.</param>
        /// <param name="Nationality">Nationality.</param>
        /// <param name="Seed">Seed.</param>
        /// <param name="Version">Version.</param>

        public UserResponse(List<Result> Results = null, string Nationality = null, string Seed = null, string Version = null)
        {
            this.Results = Results;
            this.Nationality = Nationality;
            this.Seed = Seed;
            this.Version = Version;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<Result> Results { get; set; }
    
        /// <summary>
        /// Gets or Sets Nationality
        /// </summary>
        [DataMember(Name="nationality", EmitDefaultValue=false)]
        public string Nationality { get; set; }
    
        /// <summary>
        /// Gets or Sets Seed
        /// </summary>
        [DataMember(Name="seed", EmitDefaultValue=false)]
        public string Seed { get; set; }
    
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserResponse {\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Nationality: ").Append(Nationality).Append("\n");
            sb.Append("  Seed: ").Append(Seed).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as UserResponse);
        }

        /// <summary>
        /// Returns true if UserResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of UserResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
                ) && 
                (
                    this.Nationality == other.Nationality ||
                    this.Nationality != null &&
                    this.Nationality.Equals(other.Nationality)
                ) && 
                (
                    this.Seed == other.Seed ||
                    this.Seed != null &&
                    this.Seed.Equals(other.Seed)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();
                
                if (this.Nationality != null)
                    hash = hash * 59 + this.Nationality.GetHashCode();
                
                if (this.Seed != null)
                    hash = hash * 59 + this.Seed.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                return hash;
            }
        }

    }
}
