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
    /// QQLightApiBanHttpInput
    /// </summary>
    [DataContract]
    public partial class QQLightApiBanHttpInput :  IEquatable<QQLightApiBanHttpInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QQLightApiBanHttpInput" /> class.
        /// </summary>
        /// <param name="群号">群号.</param>
        /// <param name="qq">qq.</param>
        /// <param name="禁言时长">单位:秒  0为解除禁言.</param>
        public QQLightApiBanHttpInput(string 群号 = default(string), string qq = default(string), int? 禁言时长 = default(int?))
        {
            this.群号 = 群号;
            this.Qq = qq;
            this.禁言时长 = 禁言时长;
        }
        
        /// <summary>
        /// Gets or Sets 群号
        /// </summary>
        [DataMember(Name="群号", EmitDefaultValue=false)]
        public string 群号 { get; set; }

        /// <summary>
        /// Gets or Sets Qq
        /// </summary>
        [DataMember(Name="qq", EmitDefaultValue=false)]
        public string Qq { get; set; }

        /// <summary>
        /// 单位:秒  0为解除禁言
        /// </summary>
        /// <value>单位:秒  0为解除禁言</value>
        [DataMember(Name="禁言时长", EmitDefaultValue=false)]
        public int? 禁言时长 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QQLightApiBanHttpInput {\n");
            sb.Append("  群号: ").Append(群号).Append("\n");
            sb.Append("  Qq: ").Append(Qq).Append("\n");
            sb.Append("  禁言时长: ").Append(禁言时长).Append("\n");
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
            return this.Equals(input as QQLightApiBanHttpInput);
        }

        /// <summary>
        /// Returns true if QQLightApiBanHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of QQLightApiBanHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QQLightApiBanHttpInput input)
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
                    this.Qq == input.Qq ||
                    (this.Qq != null &&
                    this.Qq.Equals(input.Qq))
                ) && 
                (
                    this.禁言时长 == input.禁言时长 ||
                    (this.禁言时长 != null &&
                    this.禁言时长.Equals(input.禁言时长))
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
                if (this.Qq != null)
                    hashCode = hashCode * 59 + this.Qq.GetHashCode();
                if (this.禁言时长 != null)
                    hashCode = hashCode * 59 + this.禁言时长.GetHashCode();
                return hashCode;
            }
        }

    }

}
