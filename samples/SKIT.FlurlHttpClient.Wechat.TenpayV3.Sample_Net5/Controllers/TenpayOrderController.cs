﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SKIT.FlurlHttpClient.Wechat.TenpayV3;
using SKIT.FlurlHttpClient.Wechat.TenpayV3.Models;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample_Net5.Controllers
{
    [ApiController]
    [Route("order")]
    public class TenpayOrderController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly Options.TenpayOptions _tenpayOptions;
        private readonly Services.HttpClients.IWechatTenpayHttpClientFactory _tenpayHttpClientFactory;

        public TenpayOrderController(
            ILoggerFactory loggerFactory,
            IOptions<Options.TenpayOptions> tenpayOptions,
            Services.HttpClients.IWechatTenpayHttpClientFactory tenpayHttpClientFactory)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _tenpayOptions = tenpayOptions.Value;
            _tenpayHttpClientFactory = tenpayHttpClientFactory;
        }

        [HttpPost]
        [Route("jsapi")]
        public async Task<IActionResult> CreateOrderByJsapi([FromBody] Models.CreateOrderByJsapiRequest requestModel)
        {
            // JSAPI 下单
            // 文档：https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_1.shtml

            var client = _tenpayHttpClientFactory.Create(requestModel.MerchantId);
            var request = new CreatePayTransactionJsapiRequest()
            {
                OutTradeNumber = "SAMPLE_OTN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                AppId = requestModel.AppId,
                Description = "演示订单",
                NotifyUrl = _tenpayOptions.NotifyUrl,
                Amount = new CreatePayTransactionJsapiRequest.Types.Amount() { Total = requestModel.Amount },
                Payer = new CreatePayTransactionJsapiRequest.Types.Payer() { OpenId = requestModel.OpenId }
            };
            var response = await client.ExecuteCreatePayTransactionJsapiAsync(request, cancellationToken: HttpContext.RequestAborted);
            if (!response.IsSuccessful())
            {
                _logger.LogWarning(
                    "JSAPI 下单失败（状态码：{0}，错误代码：{1}，错误描述：{2}）。",
                    response.RawStatus, response.ErrorCode, response.ErrorMessage
                );
            }

            return new JsonResult(response);
        }
    }
}
