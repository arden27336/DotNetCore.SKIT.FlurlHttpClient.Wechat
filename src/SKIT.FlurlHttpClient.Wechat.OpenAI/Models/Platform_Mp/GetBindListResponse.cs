﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.Platform
{
    /// <summary>
    /// <para>表示 [POST] /getbindlist/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class GetBindListResponse : WechatOpenAIPlatformResponse
    {
        /// <summary>
        /// 获取或设置绑定列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bindlist")]
        [System.Text.Json.Serialization.JsonPropertyName("bindlist")]
        public object[] BindList { get; set; } = default!;
    }
}
