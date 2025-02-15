﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/modify_wxa_jump_domain 接口的响应。</para>
    /// </summary>
    public class CgibinComponentModifyWxaJumpDomainResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置目前生效的全网发布版第三方平台小程序业务域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("published_wxa_jump_h5_domain")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringArrayWithSemicolonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("published_wxa_jump_h5_domain")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringArrayWithSemicolonConverter))]
        public string[]? PublishedWxaJumpH5DomainList { get; set; }

        /// <summary>
        /// 获取或设置目前生效的测试版第三方平台小程序业务域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("testing_wxa_jump_h5_domain")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringArrayWithSemicolonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("testing_wxa_jump_h5_domain")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringArrayWithSemicolonConverter))]
        public string[]? TestingWxaJumpH5DomainList { get; set; }

        /// <summary>
        /// 获取或设置未通过验证的第三方平台小程序业务域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_wxa_jump_h5_domain")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringArrayWithSemicolonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_wxa_jump_h5_domain")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringArrayWithSemicolonConverter))]
        public string[]? InvalidWxaJumpH5DomainList { get; set; }
    }
}
