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
    /// 根据提交的QQ号计算得到页面操作用参数长Ldw&#x60;
    /// </summary>
    [DataContract]
    public partial class MpqApiGetLdwHttpInput :  IEquatable<MpqApiGetLdwHttpInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MpqApiGetLdwHttpInput" /> class.
        /// </summary>
        /// <param name="响应的QQ">响应的QQ.</param>
        public MpqApiGetLdwHttpInput(string 响应的QQ = default(string))
        {
            this.响应的QQ = 响应的QQ;
        }
        
        /// <summary>
        /// Gets or Sets 响应的QQ
        /// </summary>
        [DataMember(Name="响应的QQ", EmitDefaultValue=false)]
        public string 响应的QQ { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MpqApiGetLdwHttpInput {\n");
            sb.Append("  响应的QQ: ").Append(响应的QQ).Append("\n");
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
            return this.Equals(input as MpqApiGetLdwHttpInput);
        }

        /// <summary>
        /// Returns true if MpqApiGetLdwHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of MpqApiGetLdwHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MpqApiGetLdwHttpInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.响应的QQ == input.响应的QQ ||
                    (this.响应的QQ != null &&
                    this.响应的QQ.Equals(input.响应的QQ))
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
                if (this.响应的QQ != null)
                    hashCode = hashCode * 59 + this.响应的QQ.GetHashCode();
                return hashCode;
            }
        }

    }

}
