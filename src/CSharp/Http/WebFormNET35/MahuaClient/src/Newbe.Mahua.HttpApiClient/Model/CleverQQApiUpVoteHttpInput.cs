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
    /// 调用一次点一下，成功返回空，失败返回理由如：每天最多给他点十个赞哦，调用此Api时应注意频率，每人每日可被赞10次，每日每Q最多可赞50人
    /// </summary>
    [DataContract]
    public partial class CleverQQApiUpVoteHttpInput :  IEquatable<CleverQQApiUpVoteHttpInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CleverQQApiUpVoteHttpInput" /> class.
        /// </summary>
        /// <param name="响应QQ">机器人QQ.</param>
        /// <param name="被赞QQ">填写被赞人QQ.</param>
        public CleverQQApiUpVoteHttpInput(string 响应QQ = default(string), string 被赞QQ = default(string))
        {
            this.响应QQ = 响应QQ;
            this.被赞QQ = 被赞QQ;
        }
        
        /// <summary>
        /// 机器人QQ
        /// </summary>
        /// <value>机器人QQ</value>
        [DataMember(Name="响应QQ", EmitDefaultValue=false)]
        public string 响应QQ { get; set; }

        /// <summary>
        /// 填写被赞人QQ
        /// </summary>
        /// <value>填写被赞人QQ</value>
        [DataMember(Name="被赞QQ", EmitDefaultValue=false)]
        public string 被赞QQ { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CleverQQApiUpVoteHttpInput {\n");
            sb.Append("  响应QQ: ").Append(响应QQ).Append("\n");
            sb.Append("  被赞QQ: ").Append(被赞QQ).Append("\n");
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
            return this.Equals(input as CleverQQApiUpVoteHttpInput);
        }

        /// <summary>
        /// Returns true if CleverQQApiUpVoteHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CleverQQApiUpVoteHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CleverQQApiUpVoteHttpInput input)
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
                    this.被赞QQ == input.被赞QQ ||
                    (this.被赞QQ != null &&
                    this.被赞QQ.Equals(input.被赞QQ))
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
                if (this.被赞QQ != null)
                    hashCode = hashCode * 59 + this.被赞QQ.GetHashCode();
                return hashCode;
            }
        }

    }

}
