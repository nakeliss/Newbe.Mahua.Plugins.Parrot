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
    /// 向对象发送一条音乐信息（所谓的点歌）次数不限&#x60;
    /// </summary>
    [DataContract]
    public partial class MpqApiSendMusicHttpInput :  IEquatable<MpqApiSendMusicHttpInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MpqApiSendMusicHttpInput" /> class.
        /// </summary>
        /// <param name="响应的QQ">响应的QQ.</param>
        /// <param name="收信对象类型">同Api_SendMsg  1好友 2群 3讨论组 4群临时会话 5讨论组临时会话.</param>
        /// <param name="收信对象所属群讨论组">发群内、临时会话必填 好友可不填.</param>
        /// <param name="收信对象QQ">临时会话、好友必填 发至群内可不填.</param>
        /// <param name="音乐简介">留空默认‘QQ音乐 的分享’.</param>
        /// <param name="音乐播放页面连接">任意直连或短链接均可 留空为空 无法点开.</param>
        /// <param name="音乐封面连接">任意直连或短链接均可 可空 例:http://url.cn/cDiJT4.</param>
        /// <param name="音乐文件直连连接">任意直连或短链接均可 不可空 例:http://url.cn/djwXjr.</param>
        /// <param name="曲名">可空.</param>
        /// <param name="歌手名">可空.</param>
        /// <param name="音乐来源名">可空 为空默认QQ音乐.</param>
        /// <param name="音乐来源图标连接">可空 为空默认QQ音乐 http://qzonestyle.gtimg.cn/ac/qzone/applogo/64/308/100497308_64.gif.</param>
        public MpqApiSendMusicHttpInput(string 响应的QQ = default(string), int? 收信对象类型 = default(int?), string 收信对象所属群讨论组 = default(string), string 收信对象QQ = default(string), string 音乐简介 = default(string), string 音乐播放页面连接 = default(string), string 音乐封面连接 = default(string), string 音乐文件直连连接 = default(string), string 曲名 = default(string), string 歌手名 = default(string), string 音乐来源名 = default(string), string 音乐来源图标连接 = default(string))
        {
            this.响应的QQ = 响应的QQ;
            this.收信对象类型 = 收信对象类型;
            this.收信对象所属群讨论组 = 收信对象所属群讨论组;
            this.收信对象QQ = 收信对象QQ;
            this.音乐简介 = 音乐简介;
            this.音乐播放页面连接 = 音乐播放页面连接;
            this.音乐封面连接 = 音乐封面连接;
            this.音乐文件直连连接 = 音乐文件直连连接;
            this.曲名 = 曲名;
            this.歌手名 = 歌手名;
            this.音乐来源名 = 音乐来源名;
            this.音乐来源图标连接 = 音乐来源图标连接;
        }
        
        /// <summary>
        /// Gets or Sets 响应的QQ
        /// </summary>
        [DataMember(Name="响应的QQ", EmitDefaultValue=false)]
        public string 响应的QQ { get; set; }

        /// <summary>
        /// 同Api_SendMsg  1好友 2群 3讨论组 4群临时会话 5讨论组临时会话
        /// </summary>
        /// <value>同Api_SendMsg  1好友 2群 3讨论组 4群临时会话 5讨论组临时会话</value>
        [DataMember(Name="收信对象类型", EmitDefaultValue=false)]
        public int? 收信对象类型 { get; set; }

        /// <summary>
        /// 发群内、临时会话必填 好友可不填
        /// </summary>
        /// <value>发群内、临时会话必填 好友可不填</value>
        [DataMember(Name="收信对象所属群_讨论组", EmitDefaultValue=false)]
        public string 收信对象所属群讨论组 { get; set; }

        /// <summary>
        /// 临时会话、好友必填 发至群内可不填
        /// </summary>
        /// <value>临时会话、好友必填 发至群内可不填</value>
        [DataMember(Name="收信对象QQ", EmitDefaultValue=false)]
        public string 收信对象QQ { get; set; }

        /// <summary>
        /// 留空默认‘QQ音乐 的分享’
        /// </summary>
        /// <value>留空默认‘QQ音乐 的分享’</value>
        [DataMember(Name="音乐简介", EmitDefaultValue=false)]
        public string 音乐简介 { get; set; }

        /// <summary>
        /// 任意直连或短链接均可 留空为空 无法点开
        /// </summary>
        /// <value>任意直连或短链接均可 留空为空 无法点开</value>
        [DataMember(Name="音乐播放页面连接", EmitDefaultValue=false)]
        public string 音乐播放页面连接 { get; set; }

        /// <summary>
        /// 任意直连或短链接均可 可空 例:http://url.cn/cDiJT4
        /// </summary>
        /// <value>任意直连或短链接均可 可空 例:http://url.cn/cDiJT4</value>
        [DataMember(Name="音乐封面连接", EmitDefaultValue=false)]
        public string 音乐封面连接 { get; set; }

        /// <summary>
        /// 任意直连或短链接均可 不可空 例:http://url.cn/djwXjr
        /// </summary>
        /// <value>任意直连或短链接均可 不可空 例:http://url.cn/djwXjr</value>
        [DataMember(Name="音乐文件直连连接", EmitDefaultValue=false)]
        public string 音乐文件直连连接 { get; set; }

        /// <summary>
        /// 可空
        /// </summary>
        /// <value>可空</value>
        [DataMember(Name="曲名", EmitDefaultValue=false)]
        public string 曲名 { get; set; }

        /// <summary>
        /// 可空
        /// </summary>
        /// <value>可空</value>
        [DataMember(Name="歌手名", EmitDefaultValue=false)]
        public string 歌手名 { get; set; }

        /// <summary>
        /// 可空 为空默认QQ音乐
        /// </summary>
        /// <value>可空 为空默认QQ音乐</value>
        [DataMember(Name="音乐来源名", EmitDefaultValue=false)]
        public string 音乐来源名 { get; set; }

        /// <summary>
        /// 可空 为空默认QQ音乐 http://qzonestyle.gtimg.cn/ac/qzone/applogo/64/308/100497308_64.gif
        /// </summary>
        /// <value>可空 为空默认QQ音乐 http://qzonestyle.gtimg.cn/ac/qzone/applogo/64/308/100497308_64.gif</value>
        [DataMember(Name="音乐来源图标连接", EmitDefaultValue=false)]
        public string 音乐来源图标连接 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MpqApiSendMusicHttpInput {\n");
            sb.Append("  响应的QQ: ").Append(响应的QQ).Append("\n");
            sb.Append("  收信对象类型: ").Append(收信对象类型).Append("\n");
            sb.Append("  收信对象所属群讨论组: ").Append(收信对象所属群讨论组).Append("\n");
            sb.Append("  收信对象QQ: ").Append(收信对象QQ).Append("\n");
            sb.Append("  音乐简介: ").Append(音乐简介).Append("\n");
            sb.Append("  音乐播放页面连接: ").Append(音乐播放页面连接).Append("\n");
            sb.Append("  音乐封面连接: ").Append(音乐封面连接).Append("\n");
            sb.Append("  音乐文件直连连接: ").Append(音乐文件直连连接).Append("\n");
            sb.Append("  曲名: ").Append(曲名).Append("\n");
            sb.Append("  歌手名: ").Append(歌手名).Append("\n");
            sb.Append("  音乐来源名: ").Append(音乐来源名).Append("\n");
            sb.Append("  音乐来源图标连接: ").Append(音乐来源图标连接).Append("\n");
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
            return this.Equals(input as MpqApiSendMusicHttpInput);
        }

        /// <summary>
        /// Returns true if MpqApiSendMusicHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of MpqApiSendMusicHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MpqApiSendMusicHttpInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.响应的QQ == input.响应的QQ ||
                    (this.响应的QQ != null &&
                    this.响应的QQ.Equals(input.响应的QQ))
                ) && 
                (
                    this.收信对象类型 == input.收信对象类型 ||
                    (this.收信对象类型 != null &&
                    this.收信对象类型.Equals(input.收信对象类型))
                ) && 
                (
                    this.收信对象所属群讨论组 == input.收信对象所属群讨论组 ||
                    (this.收信对象所属群讨论组 != null &&
                    this.收信对象所属群讨论组.Equals(input.收信对象所属群讨论组))
                ) && 
                (
                    this.收信对象QQ == input.收信对象QQ ||
                    (this.收信对象QQ != null &&
                    this.收信对象QQ.Equals(input.收信对象QQ))
                ) && 
                (
                    this.音乐简介 == input.音乐简介 ||
                    (this.音乐简介 != null &&
                    this.音乐简介.Equals(input.音乐简介))
                ) && 
                (
                    this.音乐播放页面连接 == input.音乐播放页面连接 ||
                    (this.音乐播放页面连接 != null &&
                    this.音乐播放页面连接.Equals(input.音乐播放页面连接))
                ) && 
                (
                    this.音乐封面连接 == input.音乐封面连接 ||
                    (this.音乐封面连接 != null &&
                    this.音乐封面连接.Equals(input.音乐封面连接))
                ) && 
                (
                    this.音乐文件直连连接 == input.音乐文件直连连接 ||
                    (this.音乐文件直连连接 != null &&
                    this.音乐文件直连连接.Equals(input.音乐文件直连连接))
                ) && 
                (
                    this.曲名 == input.曲名 ||
                    (this.曲名 != null &&
                    this.曲名.Equals(input.曲名))
                ) && 
                (
                    this.歌手名 == input.歌手名 ||
                    (this.歌手名 != null &&
                    this.歌手名.Equals(input.歌手名))
                ) && 
                (
                    this.音乐来源名 == input.音乐来源名 ||
                    (this.音乐来源名 != null &&
                    this.音乐来源名.Equals(input.音乐来源名))
                ) && 
                (
                    this.音乐来源图标连接 == input.音乐来源图标连接 ||
                    (this.音乐来源图标连接 != null &&
                    this.音乐来源图标连接.Equals(input.音乐来源图标连接))
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
                if (this.响应的QQ != null)
                    hashCode = hashCode * 59 + this.响应的QQ.GetHashCode();
                if (this.收信对象类型 != null)
                    hashCode = hashCode * 59 + this.收信对象类型.GetHashCode();
                if (this.收信对象所属群讨论组 != null)
                    hashCode = hashCode * 59 + this.收信对象所属群讨论组.GetHashCode();
                if (this.收信对象QQ != null)
                    hashCode = hashCode * 59 + this.收信对象QQ.GetHashCode();
                if (this.音乐简介 != null)
                    hashCode = hashCode * 59 + this.音乐简介.GetHashCode();
                if (this.音乐播放页面连接 != null)
                    hashCode = hashCode * 59 + this.音乐播放页面连接.GetHashCode();
                if (this.音乐封面连接 != null)
                    hashCode = hashCode * 59 + this.音乐封面连接.GetHashCode();
                if (this.音乐文件直连连接 != null)
                    hashCode = hashCode * 59 + this.音乐文件直连连接.GetHashCode();
                if (this.曲名 != null)
                    hashCode = hashCode * 59 + this.曲名.GetHashCode();
                if (this.歌手名 != null)
                    hashCode = hashCode * 59 + this.歌手名.GetHashCode();
                if (this.音乐来源名 != null)
                    hashCode = hashCode * 59 + this.音乐来源名.GetHashCode();
                if (this.音乐来源图标连接 != null)
                    hashCode = hashCode * 59 + this.音乐来源图标连接.GetHashCode();
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
