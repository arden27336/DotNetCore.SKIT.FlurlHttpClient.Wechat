﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/bot/save 接口的请求。</para>
    /// </summary>
    public class BotSaveRequest : WechatOpenAIThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置机器人中文名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name_ch")]
        [System.Text.Json.Serialization.JsonPropertyName("name_ch")]
        public string ChineseName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置机器人英文名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name_en")]
        [System.Text.Json.Serialization.JsonPropertyName("name_en")]
        public string? EnglishName { get; set; }

        /// <summary>
        /// 获取或设置机器人昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nickname")]
        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
        public string? Nickname { get; set; }
        
        /// <summary>
        /// 获取或设置机器人类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bot_type")]
        [System.Text.Json.Serialization.JsonPropertyName("bot_type")]
        public int? BotType { get; set; }

        /// <summary>
        /// 获取或设置行业 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry")]
        [System.Text.Json.Serialization.JsonPropertyName("industry")]
        public int? IndustryId { get; set; }

        /// <summary>
        /// 获取或设置默认回答开关。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("default_answer_switch")]
        [System.Text.Json.Serialization.JsonPropertyName("default_answer_switch")]
        public bool? DefaultAnswerSwitch { get; set; }

        /// <summary>
        /// 获取或设置默认回答。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("default_answer")]
        [System.Text.Json.Serialization.JsonPropertyName("default_answer")]
        public string? DefaultAnswer { get; set; }

        /// <summary>
        /// 获取或设置相似度阈值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("similarity")]
        [System.Text.Json.Serialization.JsonPropertyName("similarity")]
        public double? Similarity { get; set; }

        /// <summary>
        /// 获取或设置相似度阈值下限。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("similarity_low")]
        [System.Text.Json.Serialization.JsonPropertyName("similarity_low")]
        public double? SimilarityMinimum { get; set; }

        /// <summary>
        /// 获取或设置相似问题推荐数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("similar_question_recommend_num")]
        [System.Text.Json.Serialization.JsonPropertyName("similar_question_recommend_num")]
        public int? SimilarityQuestionRecommendCount { get; set; }

        /// <summary>
        /// 获取或设置收集用户反馈开关。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_feedback")]
        [System.Text.Json.Serialization.JsonPropertyName("user_feedback")]
        public bool? UserFeedbackSwitch { get; set; }
    }
}
