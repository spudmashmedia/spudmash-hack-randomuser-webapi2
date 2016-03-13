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
    public partial class NameType :  IEquatable<NameType>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NameType" /> class.
        /// Initializes a new instance of the <see cref="NameType" />class.
        /// </summary>
        /// <param name="Title">Title.</param>
        /// <param name="First">First.</param>
        /// <param name="Last">Last.</param>

        public NameType(string Title = null, string First = null, string Last = null)
        {
            this.Title = Title;
            this.First = First;
            this.Last = Last;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or Sets First
        /// </summary>
        [DataMember(Name="first", EmitDefaultValue=false)]
        public string First { get; set; }
    
        /// <summary>
        /// Gets or Sets Last
        /// </summary>
        [DataMember(Name="last", EmitDefaultValue=false)]
        public string Last { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NameType {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
            
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
            return this.Equals(obj as NameType);
        }

        /// <summary>
        /// Returns true if NameType instances are equal
        /// </summary>
        /// <param name="other">Instance of NameType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NameType other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.First == other.First ||
                    this.First != null &&
                    this.First.Equals(other.First)
                ) && 
                (
                    this.Last == other.Last ||
                    this.Last != null &&
                    this.Last.Equals(other.Last)
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
                
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                
                if (this.First != null)
                    hash = hash * 59 + this.First.GetHashCode();
                
                if (this.Last != null)
                    hash = hash * 59 + this.Last.GetHashCode();
                
                return hash;
            }
        }

    }
}
