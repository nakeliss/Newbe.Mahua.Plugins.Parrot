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
    /// 根据图片GUID取得图片下载连接 失败返回空&#x60;
    /// </summary>
    [DataContract]
    public partial class MpqApiGuidGetPicLinkHttpInput :  IEquatable<MpqApiGuidGetPicLinkHttpInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MpqApiGuidGetPicLinkHttpInput" /> class.
        /// </summary>
        /// <param name="图片GUID">{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.jpg这样的GUID.</param>
        public MpqApiGuidGetPicLinkHttpInput(string 图片GUID = default(string))
        {
            this.图片GUID = 图片GUID;
        }
        
        /// <summary>
        /// {xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.jpg这样的GUID
        /// </summary>
        /// <value>{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.jpg这样的GUID</value>
        [DataMember(Name="图片GUID", EmitDefaultValue=false)]
        public string 图片GUID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MpqApiGuidGetPicLinkHttpInput {\n");
            sb.Append("  图片GUID: ").Append(图片GUID).Append("\n");
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
            return this.Equals(input as MpqApiGuidGetPicLinkHttpInput);
        }

        /// <summary>
        /// Returns true if MpqApiGuidGetPicLinkHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of MpqApiGuidGetPicLinkHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MpqApiGuidGetPicLinkHttpInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.图片GUID == input.图片GUID ||
                    (this.图片GUID != null &&
                    this.图片GUID.Equals(input.图片GUID))
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
                if (this.图片GUID != null)
                    hashCode = hashCode * 59 + this.图片GUID.GetHashCode();
                return hashCode;
            }
        }

    }

}
