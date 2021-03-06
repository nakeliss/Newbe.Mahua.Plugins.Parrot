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
    /// QQ群签到（成功返回真 失败返回假）
    /// </summary>
    [DataContract]
    public partial class CleverQQApiSignInHttpInput :  IEquatable<CleverQQApiSignInHttpInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CleverQQApiSignInHttpInput" /> class.
        /// </summary>
        /// <param name="响应QQ">机器人QQ.</param>
        /// <param name="群号">QQ群号.</param>
        /// <param name="地名">签到地名（Pro可自定义）.</param>
        /// <param name="想说的话">想发表的内容.</param>
        public CleverQQApiSignInHttpInput(string 响应QQ = default(string), string 群号 = default(string), string 地名 = default(string), string 想说的话 = default(string))
        {
            this.响应QQ = 响应QQ;
            this.群号 = 群号;
            this.地名 = 地名;
            this.想说的话 = 想说的话;
        }
        
        /// <summary>
        /// 机器人QQ
        /// </summary>
        /// <value>机器人QQ</value>
        [DataMember(Name="响应QQ", EmitDefaultValue=false)]
        public string 响应QQ { get; set; }

        /// <summary>
        /// QQ群号
        /// </summary>
        /// <value>QQ群号</value>
        [DataMember(Name="群号", EmitDefaultValue=false)]
        public string 群号 { get; set; }

        /// <summary>
        /// 签到地名（Pro可自定义）
        /// </summary>
        /// <value>签到地名（Pro可自定义）</value>
        [DataMember(Name="地名", EmitDefaultValue=false)]
        public string 地名 { get; set; }

        /// <summary>
        /// 想发表的内容
        /// </summary>
        /// <value>想发表的内容</value>
        [DataMember(Name="想说的话", EmitDefaultValue=false)]
        public string 想说的话 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CleverQQApiSignInHttpInput {\n");
            sb.Append("  响应QQ: ").Append(响应QQ).Append("\n");
            sb.Append("  群号: ").Append(群号).Append("\n");
            sb.Append("  地名: ").Append(地名).Append("\n");
            sb.Append("  想说的话: ").Append(想说的话).Append("\n");
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
            return this.Equals(input as CleverQQApiSignInHttpInput);
        }

        /// <summary>
        /// Returns true if CleverQQApiSignInHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CleverQQApiSignInHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CleverQQApiSignInHttpInput input)
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
                    this.群号 == input.群号 ||
                    (this.群号 != null &&
                    this.群号.Equals(input.群号))
                ) && 
                (
                    this.地名 == input.地名 ||
                    (this.地名 != null &&
                    this.地名.Equals(input.地名))
                ) && 
                (
                    this.想说的话 == input.想说的话 ||
                    (this.想说的话 != null &&
                    this.想说的话.Equals(input.想说的话))
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
                if (this.群号 != null)
                    hashCode = hashCode * 59 + this.群号.GetHashCode();
                if (this.地名 != null)
                    hashCode = hashCode * 59 + this.地名.GetHashCode();
                if (this.想说的话 != null)
                    hashCode = hashCode * 59 + this.想说的话.GetHashCode();
                return hashCode;
            }
        }

    }

}
