/* 
 * Newbe.Mahua.HttpApi
 *
 * this is http api document for Newbe.Mahua. You can get some help from http://www.newbe.pro
 *
 * OpenAPI spec version: v1
 * Contact: 472158246@qq.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Newbe.Mahua.HttpApiClient.Client.SwaggerDateConverter;

namespace Newbe.Mahua.HttpApiClient.Model
{
    /// <summary>
    /// QQLightApiSetFriendNameHttpInput
    /// </summary>
    [DataContract]
    public partial class QQLightApiSetFriendNameHttpInput :  IEquatable<QQLightApiSetFriendNameHttpInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QQLightApiSetFriendNameHttpInput" /> class.
        /// </summary>
        /// <param name="好友QQ">好友QQ.</param>
        /// <param name="备注名">备注名.</param>
        public QQLightApiSetFriendNameHttpInput(string 好友QQ = default(string), string 备注名 = default(string))
        {
            this.好友QQ = 好友QQ;
            this.备注名 = 备注名;
        }
        
        /// <summary>
        /// Gets or Sets 好友QQ
        /// </summary>
        [DataMember(Name="好友QQ", EmitDefaultValue=false)]
        public string 好友QQ { get; set; }

        /// <summary>
        /// Gets or Sets 备注名
        /// </summary>
        [DataMember(Name="备注名", EmitDefaultValue=false)]
        public string 备注名 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QQLightApiSetFriendNameHttpInput {\n");
            sb.Append("  好友QQ: ").Append(好友QQ).Append("\n");
            sb.Append("  备注名: ").Append(备注名).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as QQLightApiSetFriendNameHttpInput);
        }

        /// <summary>
        /// Returns true if QQLightApiSetFriendNameHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of QQLightApiSetFriendNameHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QQLightApiSetFriendNameHttpInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.好友QQ == input.好友QQ ||
                    (this.好友QQ != null &&
                    this.好友QQ.Equals(input.好友QQ))
                ) && 
                (
                    this.备注名 == input.备注名 ||
                    (this.备注名 != null &&
                    this.备注名.Equals(input.备注名))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.好友QQ != null)
                    hashCode = hashCode * 59 + this.好友QQ.GetHashCode();
                if (this.备注名 != null)
                    hashCode = hashCode * 59 + this.备注名.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}