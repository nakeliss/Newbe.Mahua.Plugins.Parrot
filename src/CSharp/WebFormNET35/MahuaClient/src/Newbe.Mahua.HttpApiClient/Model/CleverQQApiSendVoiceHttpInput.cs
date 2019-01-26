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
    /// 好友语音上传并发送 （成功返回真 失败返回假）
    /// </summary>
    [DataContract]
    public partial class CleverQQApiSendVoiceHttpInput :  IEquatable<CleverQQApiSendVoiceHttpInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CleverQQApiSendVoiceHttpInput" /> class.
        /// </summary>
        /// <param name="响应QQ">机器人QQ.</param>
        /// <param name="接收QQ">接收语音人QQ.</param>
        /// <param name="语音数据">语音字节集数据（AMR Silk编码）.</param>
        public CleverQQApiSendVoiceHttpInput(string 响应QQ = default(string), string 接收QQ = default(string), string 语音数据 = default(string))
        {
            this.响应QQ = 响应QQ;
            this.接收QQ = 接收QQ;
            this.语音数据 = 语音数据;
        }
        
        /// <summary>
        /// 机器人QQ
        /// </summary>
        /// <value>机器人QQ</value>
        [DataMember(Name="响应QQ", EmitDefaultValue=false)]
        public string 响应QQ { get; set; }

        /// <summary>
        /// 接收语音人QQ
        /// </summary>
        /// <value>接收语音人QQ</value>
        [DataMember(Name="接收QQ", EmitDefaultValue=false)]
        public string 接收QQ { get; set; }

        /// <summary>
        /// 语音字节集数据（AMR Silk编码）
        /// </summary>
        /// <value>语音字节集数据（AMR Silk编码）</value>
        [DataMember(Name="语音数据", EmitDefaultValue=false)]
        public string 语音数据 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CleverQQApiSendVoiceHttpInput {\n");
            sb.Append("  响应QQ: ").Append(响应QQ).Append("\n");
            sb.Append("  接收QQ: ").Append(接收QQ).Append("\n");
            sb.Append("  语音数据: ").Append(语音数据).Append("\n");
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
            return this.Equals(input as CleverQQApiSendVoiceHttpInput);
        }

        /// <summary>
        /// Returns true if CleverQQApiSendVoiceHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CleverQQApiSendVoiceHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CleverQQApiSendVoiceHttpInput input)
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
                    this.接收QQ == input.接收QQ ||
                    (this.接收QQ != null &&
                    this.接收QQ.Equals(input.接收QQ))
                ) && 
                (
                    this.语音数据 == input.语音数据 ||
                    (this.语音数据 != null &&
                    this.语音数据.Equals(input.语音数据))
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
                if (this.接收QQ != null)
                    hashCode = hashCode * 59 + this.接收QQ.GetHashCode();
                if (this.语音数据 != null)
                    hashCode = hashCode * 59 + this.语音数据.GetHashCode();
                return hashCode;
            }
        }

    }

}
