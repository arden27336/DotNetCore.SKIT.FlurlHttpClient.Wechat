﻿using System;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class WechatTenpayCertificateManagerTests
    {
        [Fact(DisplayName = "序列化与反序列化 `CertificateEntry`")]
        public void CertificateEntrySerializationTest()
        {
            var entry = new Settings.CertificateEntry("merchantId", "SN", "-----BEGIN CERTIFICATE-----END CERTIFICATE-----", DateTimeOffset.Now, DateTimeOffset.Now);

            var serialized1 = Newtonsoft.Json.JsonConvert.SerializeObject(entry);
            var deserialized1 = Newtonsoft.Json.JsonConvert.DeserializeObject<Settings.CertificateEntry>(serialized1);

            Assert.Equal(entry.SerialNumber, deserialized1.SerialNumber);
            Assert.Equal(entry.Certificate, deserialized1.Certificate);
            Assert.Equal(entry.EffectiveTime, deserialized1.EffectiveTime);
            Assert.Equal(entry.ExpireTime, deserialized1.ExpireTime);

            var serialized2 = System.Text.Json.JsonSerializer.Serialize(entry);
            var deserialized2 = System.Text.Json.JsonSerializer.Deserialize<Settings.CertificateEntry>(serialized2);

            Assert.Equal(entry.SerialNumber, deserialized2.SerialNumber);
            Assert.Equal(entry.Certificate, deserialized2.Certificate);
            Assert.Equal(entry.EffectiveTime, deserialized2.EffectiveTime);
            Assert.Equal(entry.ExpireTime, deserialized2.ExpireTime);
        }
    }
}
