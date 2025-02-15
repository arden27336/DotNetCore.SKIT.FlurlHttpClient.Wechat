﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/media/get/jssdk 接口的请求。</para>
    /// </summary>
    public class CgibinMediaGetJssdkRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置媒体文件标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string MediaId { get; set; } = string.Empty;
    }
}
