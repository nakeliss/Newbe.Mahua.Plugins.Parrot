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
    /// 增加运行日志
    /// </summary>
    [DataContract]
    public partial class CqpCQAddLogHttpInput :  IEquatable<CqpCQAddLogHttpInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CqpCQAddLogHttpInput" /> class.
        /// </summary>
        /// <param name="优先级">#Log_ 开头常量.</param>
        /// <param name="类型">类型.</param>
        /// <param name="内容">内容.</param>
        public CqpCQAddLogHttpInput(int? 优先级 = default(int?), string 类型 = default(string), string 内容 = default(string))
        {
            this.优先级 = 优先级;
            this.类型 = 类型;
            this.内容 = 内容;
        }
        
        /// <summary>
        /// #Log_ 开头常量
        /// </summary>
        /// <value>#Log_ 开头常量</value>
        [DataMember(Name="优先级", EmitDefaultValue=false)]
        public int? 优先级 { get; set; }

        /// <summary>
        /// Gets or Sets 类型
        /// </summary>
        [DataMember(Name="类型", EmitDefaultValue=false)]
        public string 类型 { get; set; }

        /// <summary>
        /// Gets or Sets 内容
        /// </summary>
        [DataMember(Name="内容", EmitDefaultValue=false)]
        public string 内容 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CqpCQAddLogHttpInput {\n");
            sb.Append("  优先级: ").Append(优先级).Append("\n");
            sb.Append("  类型: ").Append(类型).Append("\n");
            sb.Append("  内容: ").Append(内容).Append("\n");
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
            return this.Equals(input as CqpCQAddLogHttpInput);
        }

        /// <summary>
        /// Returns true if CqpCQAddLogHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CqpCQAddLogHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CqpCQAddLogHttpInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.优先级 == input.优先级 ||
                    (this.优先级 != null &&
                    this.优先级.Equals(input.优先级))
                ) && 
                (
                    this.类型 == input.类型 ||
                    (this.类型 != null &&
                    this.类型.Equals(input.类型))
                ) && 
                (
                    this.内容 == input.内容 ||
                    (this.内容 != null &&
                    this.内容.Equals(input.内容))
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
                if (this.优先级 != null)
                    hashCode = hashCode * 59 + this.优先级.GetHashCode();
                if (this.类型 != null)
                    hashCode = hashCode * 59 + this.类型.GetHashCode();
                if (this.内容 != null)
                    hashCode = hashCode * 59 + this.内容.GetHashCode();
                return hashCode;
            }
        }

    }

}
