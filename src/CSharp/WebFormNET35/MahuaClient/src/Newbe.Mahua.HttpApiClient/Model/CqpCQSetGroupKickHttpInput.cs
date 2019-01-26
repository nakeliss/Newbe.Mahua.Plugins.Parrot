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
    /// 置群员移除
    /// </summary>
    [DataContract]
    public partial class CqpCQSetGroupKickHttpInput :  IEquatable<CqpCQSetGroupKickHttpInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CqpCQSetGroupKickHttpInput" /> class.
        /// </summary>
        /// <param name="群号">目标群.</param>
        /// <param name="qqid">目标QQ.</param>
        /// <param name="拒绝再加群">如果为真，则“不再接收此人加群申请”，请慎用.</param>
        public CqpCQSetGroupKickHttpInput(long? 群号 = default(long?), long? qqid = default(long?), bool? 拒绝再加群 = default(bool?))
        {
            this.群号 = 群号;
            this.Qqid = qqid;
            this.拒绝再加群 = 拒绝再加群;
        }
        
        /// <summary>
        /// 目标群
        /// </summary>
        /// <value>目标群</value>
        [DataMember(Name="群号", EmitDefaultValue=false)]
        public long? 群号 { get; set; }

        /// <summary>
        /// 目标QQ
        /// </summary>
        /// <value>目标QQ</value>
        [DataMember(Name="qqid", EmitDefaultValue=false)]
        public long? Qqid { get; set; }

        /// <summary>
        /// 如果为真，则“不再接收此人加群申请”，请慎用
        /// </summary>
        /// <value>如果为真，则“不再接收此人加群申请”，请慎用</value>
        [DataMember(Name="拒绝再加群", EmitDefaultValue=false)]
        public bool? 拒绝再加群 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CqpCQSetGroupKickHttpInput {\n");
            sb.Append("  群号: ").Append(群号).Append("\n");
            sb.Append("  Qqid: ").Append(Qqid).Append("\n");
            sb.Append("  拒绝再加群: ").Append(拒绝再加群).Append("\n");
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
            return this.Equals(input as CqpCQSetGroupKickHttpInput);
        }

        /// <summary>
        /// Returns true if CqpCQSetGroupKickHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CqpCQSetGroupKickHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CqpCQSetGroupKickHttpInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.群号 == input.群号 ||
                    (this.群号 != null &&
                    this.群号.Equals(input.群号))
                ) && 
                (
                    this.Qqid == input.Qqid ||
                    (this.Qqid != null &&
                    this.Qqid.Equals(input.Qqid))
                ) && 
                (
                    this.拒绝再加群 == input.拒绝再加群 ||
                    (this.拒绝再加群 != null &&
                    this.拒绝再加群.Equals(input.拒绝再加群))
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
                if (this.群号 != null)
                    hashCode = hashCode * 59 + this.群号.GetHashCode();
                if (this.Qqid != null)
                    hashCode = hashCode * 59 + this.Qqid.GetHashCode();
                if (this.拒绝再加群 != null)
                    hashCode = hashCode * 59 + this.拒绝再加群.GetHashCode();
                return hashCode;
            }
        }

    }

}
