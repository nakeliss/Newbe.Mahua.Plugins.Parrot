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
    /// 通过语音GUID获取下载连接 失败返回空
    /// </summary>
    [DataContract]
    public partial class CleverQQApiGetVoiLinkHttpInput :  IEquatable<CleverQQApiGetVoiLinkHttpInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CleverQQApiGetVoiLinkHttpInput" /> class.
        /// </summary>
        /// <param name="响应QQ">机器人QQ.</param>
        /// <param name="语音GUID">[IR:Voi&#x3D;{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxx}.amr].</param>
        public CleverQQApiGetVoiLinkHttpInput(string 响应QQ = default(string), string 语音GUID = default(string))
        {
            this.响应QQ = 响应QQ;
            this.语音GUID = 语音GUID;
        }
        
        /// <summary>
        /// 机器人QQ
        /// </summary>
        /// <value>机器人QQ</value>
        [DataMember(Name="响应QQ", EmitDefaultValue=false)]
        public string 响应QQ { get; set; }

        /// <summary>
        /// [IR:Voi&#x3D;{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxx}.amr]
        /// </summary>
        /// <value>[IR:Voi&#x3D;{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxx}.amr]</value>
        [DataMember(Name="语音GUID", EmitDefaultValue=false)]
        public string 语音GUID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CleverQQApiGetVoiLinkHttpInput {\n");
            sb.Append("  响应QQ: ").Append(响应QQ).Append("\n");
            sb.Append("  语音GUID: ").Append(语音GUID).Append("\n");
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
            return this.Equals(input as CleverQQApiGetVoiLinkHttpInput);
        }

        /// <summary>
        /// Returns true if CleverQQApiGetVoiLinkHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CleverQQApiGetVoiLinkHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CleverQQApiGetVoiLinkHttpInput input)
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
                    this.语音GUID == input.语音GUID ||
                    (this.语音GUID != null &&
                    this.语音GUID.Equals(input.语音GUID))
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
                if (this.语音GUID != null)
                    hashCode = hashCode * 59 + this.语音GUID.GetHashCode();
                return hashCode;
            }
        }

    }

}
