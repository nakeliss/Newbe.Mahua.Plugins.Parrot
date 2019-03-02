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
    /// 往帐号列表添加一个Q.当该Q已存在时则覆盖密码&#x60;
    /// </summary>
    [DataContract]
    public partial class MpqApiAddQQHttpInput :  IEquatable<MpqApiAddQQHttpInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MpqApiAddQQHttpInput" /> class.
        /// </summary>
        /// <param name="qq">qq.</param>
        /// <param name="密码">密码.</param>
        /// <param name="自动登录">运行框架时是否自动登录该Q.若添加后需要登录该Q则需要通过Api_Login操作.</param>
        public MpqApiAddQQHttpInput(string qq = default(string), string 密码 = default(string), bool? 自动登录 = default(bool?))
        {
            this.Qq = qq;
            this.密码 = 密码;
            this.自动登录 = 自动登录;
        }
        
        /// <summary>
        /// Gets or Sets Qq
        /// </summary>
        [DataMember(Name="qq", EmitDefaultValue=false)]
        public string Qq { get; set; }

        /// <summary>
        /// Gets or Sets 密码
        /// </summary>
        [DataMember(Name="密码", EmitDefaultValue=false)]
        public string 密码 { get; set; }

        /// <summary>
        /// 运行框架时是否自动登录该Q.若添加后需要登录该Q则需要通过Api_Login操作
        /// </summary>
        /// <value>运行框架时是否自动登录该Q.若添加后需要登录该Q则需要通过Api_Login操作</value>
        [DataMember(Name="自动登录", EmitDefaultValue=false)]
        public bool? 自动登录 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MpqApiAddQQHttpInput {\n");
            sb.Append("  Qq: ").Append(Qq).Append("\n");
            sb.Append("  密码: ").Append(密码).Append("\n");
            sb.Append("  自动登录: ").Append(自动登录).Append("\n");
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
            return this.Equals(input as MpqApiAddQQHttpInput);
        }

        /// <summary>
        /// Returns true if MpqApiAddQQHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of MpqApiAddQQHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MpqApiAddQQHttpInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Qq == input.Qq ||
                    (this.Qq != null &&
                    this.Qq.Equals(input.Qq))
                ) && 
                (
                    this.密码 == input.密码 ||
                    (this.密码 != null &&
                    this.密码.Equals(input.密码))
                ) && 
                (
                    this.自动登录 == input.自动登录 ||
                    (this.自动登录 != null &&
                    this.自动登录.Equals(input.自动登录))
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
                if (this.Qq != null)
                    hashCode = hashCode * 59 + this.Qq.GetHashCode();
                if (this.密码 != null)
                    hashCode = hashCode * 59 + this.密码.GetHashCode();
                if (this.自动登录 != null)
                    hashCode = hashCode * 59 + this.自动登录.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}