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
    public partial class User :  IEquatable<User>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// Initializes a new instance of the <see cref="User" />class.
        /// </summary>
        /// <param name="Gender">Gender.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Location">Location.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Username">Username.</param>
        /// <param name="Password">Password.</param>
        /// <param name="Salt">Salt.</param>
        /// <param name="Md5">Md5.</param>
        /// <param name="Sha1">Sha1.</param>
        /// <param name="Sha256">Sha256.</param>
        /// <param name="Register">Register.</param>
        /// <param name="Dob">Dob.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="Cell">Cell.</param>
        /// <param name="NINO">NINO.</param>
        /// <param name="Picture">Picture.</param>

        public User(string Gender = null, NameType Name = null, AddressType Location = null, string Email = null, string Username = null, string Password = null, string Salt = null, string Md5 = null, string Sha1 = null, string Sha256 = null, double? Register = null, double? Dob = null, string Phone = null, string Cell = null, string NINO = null, PictureType Picture = null)
        {
            this.Gender = Gender;
            this.Name = Name;
            this.Location = Location;
            this.Email = Email;
            this.Username = Username;
            this.Password = Password;
            this.Salt = Salt;
            this.Md5 = Md5;
            this.Sha1 = Sha1;
            this.Sha256 = Sha256;
            this.Register = Register;
            this.Dob = Dob;
            this.Phone = Phone;
            this.Cell = Cell;
            this.NINO = NINO;
            this.Picture = Picture;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public string Gender { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public NameType Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public AddressType Location { get; set; }
    
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
    
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
    
        /// <summary>
        /// Gets or Sets Salt
        /// </summary>
        [DataMember(Name="salt", EmitDefaultValue=false)]
        public string Salt { get; set; }
    
        /// <summary>
        /// Gets or Sets Md5
        /// </summary>
        [DataMember(Name="md5", EmitDefaultValue=false)]
        public string Md5 { get; set; }
    
        /// <summary>
        /// Gets or Sets Sha1
        /// </summary>
        [DataMember(Name="sha1", EmitDefaultValue=false)]
        public string Sha1 { get; set; }
    
        /// <summary>
        /// Gets or Sets Sha256
        /// </summary>
        [DataMember(Name="sha256", EmitDefaultValue=false)]
        public string Sha256 { get; set; }
    
        /// <summary>
        /// Gets or Sets Register
        /// </summary>
        [DataMember(Name="register", EmitDefaultValue=false)]
        public double? Register { get; set; }
    
        /// <summary>
        /// Gets or Sets Dob
        /// </summary>
        [DataMember(Name="dob", EmitDefaultValue=false)]
        public double? Dob { get; set; }
    
        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
    
        /// <summary>
        /// Gets or Sets Cell
        /// </summary>
        [DataMember(Name="cell", EmitDefaultValue=false)]
        public string Cell { get; set; }
    
        /// <summary>
        /// Gets or Sets NINO
        /// </summary>
        [DataMember(Name="NINO", EmitDefaultValue=false)]
        public string NINO { get; set; }
    
        /// <summary>
        /// Gets or Sets Picture
        /// </summary>
        [DataMember(Name="picture", EmitDefaultValue=false)]
        public PictureType Picture { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Salt: ").Append(Salt).Append("\n");
            sb.Append("  Md5: ").Append(Md5).Append("\n");
            sb.Append("  Sha1: ").Append(Sha1).Append("\n");
            sb.Append("  Sha256: ").Append(Sha256).Append("\n");
            sb.Append("  Register: ").Append(Register).Append("\n");
            sb.Append("  Dob: ").Append(Dob).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Cell: ").Append(Cell).Append("\n");
            sb.Append("  NINO: ").Append(NINO).Append("\n");
            sb.Append("  Picture: ").Append(Picture).Append("\n");
            
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
            return this.Equals(obj as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="other">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Gender == other.Gender ||
                    this.Gender != null &&
                    this.Gender.Equals(other.Gender)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.Salt == other.Salt ||
                    this.Salt != null &&
                    this.Salt.Equals(other.Salt)
                ) && 
                (
                    this.Md5 == other.Md5 ||
                    this.Md5 != null &&
                    this.Md5.Equals(other.Md5)
                ) && 
                (
                    this.Sha1 == other.Sha1 ||
                    this.Sha1 != null &&
                    this.Sha1.Equals(other.Sha1)
                ) && 
                (
                    this.Sha256 == other.Sha256 ||
                    this.Sha256 != null &&
                    this.Sha256.Equals(other.Sha256)
                ) && 
                (
                    this.Register == other.Register ||
                    this.Register != null &&
                    this.Register.Equals(other.Register)
                ) && 
                (
                    this.Dob == other.Dob ||
                    this.Dob != null &&
                    this.Dob.Equals(other.Dob)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.Cell == other.Cell ||
                    this.Cell != null &&
                    this.Cell.Equals(other.Cell)
                ) && 
                (
                    this.NINO == other.NINO ||
                    this.NINO != null &&
                    this.NINO.Equals(other.NINO)
                ) && 
                (
                    this.Picture == other.Picture ||
                    this.Picture != null &&
                    this.Picture.Equals(other.Picture)
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
                
                if (this.Gender != null)
                    hash = hash * 59 + this.Gender.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                
                if (this.Salt != null)
                    hash = hash * 59 + this.Salt.GetHashCode();
                
                if (this.Md5 != null)
                    hash = hash * 59 + this.Md5.GetHashCode();
                
                if (this.Sha1 != null)
                    hash = hash * 59 + this.Sha1.GetHashCode();
                
                if (this.Sha256 != null)
                    hash = hash * 59 + this.Sha256.GetHashCode();
                
                if (this.Register != null)
                    hash = hash * 59 + this.Register.GetHashCode();
                
                if (this.Dob != null)
                    hash = hash * 59 + this.Dob.GetHashCode();
                
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                
                if (this.Cell != null)
                    hash = hash * 59 + this.Cell.GetHashCode();
                
                if (this.NINO != null)
                    hash = hash * 59 + this.NINO.GetHashCode();
                
                if (this.Picture != null)
                    hash = hash * 59 + this.Picture.GetHashCode();
                
                return hash;
            }
        }

    }
}
