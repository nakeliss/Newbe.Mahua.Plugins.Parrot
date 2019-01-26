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
    /// 向腾讯发送原始封包（成功返回腾讯返回的包 失败返回空）
    /// </summary>
    [DataContract]
    public partial class CleverQQApiSendPackHttpInput :  IEquatable<CleverQQApiSendPackHttpInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CleverQQApiSendPackHttpInput" /> class.
        /// </summary>
        /// <param name="响应QQ">响应QQ.</param>
        /// <param name="封包">封包内容.</param>
        public CleverQQApiSendPackHttpInput(string 响应QQ = default(string), string 封包 = default(string))
        {
            this.响应QQ = 响应QQ;
            this.封包 = 封包;
        }
        
        /// <summary>
        /// Gets or Sets 响应QQ
        /// </summary>
        [DataMember(Name="响应QQ", EmitDefaultValue=false)]
        public string 响应QQ { get; set; }

        /// <summary>
        /// 封包内容
        /// </summary>
        /// <value>封包内容</value>
        [DataMember(Name="封包", EmitDefaultValue=false)]
        public string 封包 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CleverQQApiSendPackHttpInput {\n");
            sb.Append("  响应QQ: ").Append(响应QQ).Append("\n");
            sb.Append("  封包: ").Append(封包).Append("\n");
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
            return this.Equals(input as CleverQQApiSendPackHttpInput);
        }

        /// <summary>
        /// Returns true if CleverQQApiSendPackHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CleverQQApiSendPackHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CleverQQApiSendPackHttpInput input)
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
                    this.封包 == input.封包 ||
                    (this.封包 != null &&
                    this.封包.Equals(input.封包))
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
                if (this.封包 != null)
                    hashCode = hashCode * 59 + this.封包.GetHashCode();
                return hashCode;
            }
        }

    }

}
