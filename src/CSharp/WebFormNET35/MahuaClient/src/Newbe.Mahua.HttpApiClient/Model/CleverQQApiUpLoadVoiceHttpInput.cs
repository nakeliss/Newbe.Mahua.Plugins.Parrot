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
    /// 上传QQ语音，成功返回语音GUID  失败返回空
    /// </summary>
    [DataContract]
    public partial class CleverQQApiUpLoadVoiceHttpInput :  IEquatable<CleverQQApiUpLoadVoiceHttpInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CleverQQApiUpLoadVoiceHttpInput" /> class.
        /// </summary>
        /// <param name="响应QQ">机器人QQ.</param>
        /// <param name="上传类型">2、QQ群 讨论组.</param>
        /// <param name="接收群号">需上传的群号.</param>
        /// <param name="语音数据">语音字节集数据（AMR Silk编码）.</param>
        public CleverQQApiUpLoadVoiceHttpInput(string 响应QQ = default(string), int? 上传类型 = default(int?), string 接收群号 = default(string), string 语音数据 = default(string))
        {
            this.响应QQ = 响应QQ;
            this.上传类型 = 上传类型;
            this.接收群号 = 接收群号;
            this.语音数据 = 语音数据;
        }
        
        /// <summary>
        /// 机器人QQ
        /// </summary>
        /// <value>机器人QQ</value>
        [DataMember(Name="响应QQ", EmitDefaultValue=false)]
        public string 响应QQ { get; set; }

        /// <summary>
        /// 2、QQ群 讨论组
        /// </summary>
        /// <value>2、QQ群 讨论组</value>
        [DataMember(Name="上传类型", EmitDefaultValue=false)]
        public int? 上传类型 { get; set; }

        /// <summary>
        /// 需上传的群号
        /// </summary>
        /// <value>需上传的群号</value>
        [DataMember(Name="接收群号", EmitDefaultValue=false)]
        public string 接收群号 { get; set; }

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
            sb.Append("class CleverQQApiUpLoadVoiceHttpInput {\n");
            sb.Append("  响应QQ: ").Append(响应QQ).Append("\n");
            sb.Append("  上传类型: ").Append(上传类型).Append("\n");
            sb.Append("  接收群号: ").Append(接收群号).Append("\n");
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
            return this.Equals(input as CleverQQApiUpLoadVoiceHttpInput);
        }

        /// <summary>
        /// Returns true if CleverQQApiUpLoadVoiceHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CleverQQApiUpLoadVoiceHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CleverQQApiUpLoadVoiceHttpInput input)
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
                    this.上传类型 == input.上传类型 ||
                    (this.上传类型 != null &&
                    this.上传类型.Equals(input.上传类型))
                ) && 
                (
                    this.接收群号 == input.接收群号 ||
                    (this.接收群号 != null &&
                    this.接收群号.Equals(input.接收群号))
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
                if (this.上传类型 != null)
                    hashCode = hashCode * 59 + this.上传类型.GetHashCode();
                if (this.接收群号 != null)
                    hashCode = hashCode * 59 + this.接收群号.GetHashCode();
                if (this.语音数据 != null)
                    hashCode = hashCode * 59 + this.语音数据.GetHashCode();
                return hashCode;
            }
        }

    }

}
