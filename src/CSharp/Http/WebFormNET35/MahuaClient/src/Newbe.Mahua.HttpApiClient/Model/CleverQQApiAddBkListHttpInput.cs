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
    /// 将好友拉入黑名单  成功返回真 失败返回假
    /// </summary>
    [DataContract]
    public partial class CleverQQApiAddBkListHttpInput :  IEquatable<CleverQQApiAddBkListHttpInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CleverQQApiAddBkListHttpInput" /> class.
        /// </summary>
        /// <param name="响应QQ">响应QQ.</param>
        /// <param name="对象QQ">对象QQ.</param>
        public CleverQQApiAddBkListHttpInput(string 响应QQ = default(string), string 对象QQ = default(string))
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
            sb.Append("class CleverQQApiAddBkListHttpInput {\n");
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
            return this.Equals(input as CleverQQApiAddBkListHttpInput);
        }

        /// <summary>
        /// Returns true if CleverQQApiAddBkListHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CleverQQApiAddBkListHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CleverQQApiAddBkListHttpInput input)
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
