﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.transport_cancel_order 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-provider/immediateDelivery.onOrderCancel.html </para>
    /// </summary>
    public class TransportCancelOrderEvent : TransportPreCancelOrderEvent, WechatApiEvent.Serialization.IJsonSerializable
    {
    }
}
