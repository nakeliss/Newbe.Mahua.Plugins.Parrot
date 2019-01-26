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
    /// 解除好友黑名单
    /// </summary>
    [DataContract]
    public partial class CleverQQApiDelBkListHttpInput :  IEquatable<CleverQQApiDelBkListHttpInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CleverQQApiDelBkListHttpInput" /> class.
        /// </summary>
        /// <param name="响应QQ">响应QQ.</param>
        /// <param name="对象QQ">对象QQ.</param>
        public CleverQQApiDelBkListHttpInput(string 响应QQ = default(string), string 对象QQ = default(string))
        {
            this.响应QQ = 响应QQ;
            this.对象QQ = 对象QQ;
        }
        
        /// <summary>
        /// Gets or Sets 响应QQ
        /// </summary>
        [DataMember(Name="响应QQ", EmitDefaultValue=false)]
        public string 响应QQ { get; set; }

        /// <summary>
        /// Gets or Sets 对象QQ
        /// </summary>
        [DataMember(Name="对象QQ", EmitDefaultValue=false)]
        public string 对象QQ { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CleverQQApiDelBkListHttpInput {\n");
            sb.Append("  响应QQ: ").Append(响应QQ).Append("\n");
            sb.Append("  对象QQ: ").Append(对象QQ).Append("\n");
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
            return this.Equals(input as CleverQQApiDelBkListHttpInput);
        }

        /// <summary>
        /// Returns true if CleverQQApiDelBkListHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CleverQQApiDelBkListHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CleverQQApiDelBkListHttpInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.响应QQ == input.响应QQ ||
                    (this.响应QQ != null &&
                    this.响应QQ.Equals(input.响应QQ))
                ) && 
                (
                    this.对象QQ == input.对象QQ ||
                    (this.对象QQ != null &&
                    this.对象QQ.Equals(input.对象QQ))
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
                if (this.响应QQ != null)
                    hashCode = hashCode * 59 + this.响应QQ.GetHashCode();
                if (this.对象QQ != null)
                    hashCode = hashCode * 59 + this.对象QQ.GetHashCode();
                return hashCode;
            }
        }

    }

}
