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
    /// 取得机器人网页操作用参数长Ldw
    /// </summary>
    [DataContract]
    public partial class CleverQQApiGetLongLdwHttpInput :  IEquatable<CleverQQApiGetLongLdwHttpInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CleverQQApiGetLongLdwHttpInput" /> class.
        /// </summary>
        /// <param name="响应QQ">机器人QQ.</param>
        public CleverQQApiGetLongLdwHttpInput(string 响应QQ = default(string))
        {
            this.响应QQ = 响应QQ;
        }
        
        /// <summary>
        /// 机器人QQ
        /// </summary>
        /// <value>机器人QQ</value>
        [DataMember(Name="响应QQ", EmitDefaultValue=false)]
        public string 响应QQ { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CleverQQApiGetLongLdwHttpInput {\n");
            sb.Append("  响应QQ: ").Append(响应QQ).Append("\n");
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
            return this.Equals(input as CleverQQApiGetLongLdwHttpInput);
        }

        /// <summary>
        /// Returns true if CleverQQApiGetLongLdwHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CleverQQApiGetLongLdwHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CleverQQApiGetLongLdwHttpInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.响应QQ == input.响应QQ ||
                    (this.响应QQ != null &&
                    this.响应QQ.Equals(input.响应QQ))
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
                return hashCode;
            }
        }

    }

}
