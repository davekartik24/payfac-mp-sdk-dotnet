﻿using PayFacMpSDK.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PayFacMpSDK
{
    class SubMerchantRetrievalRequest
    {
        private static Communication _communication = new Communication();
        private static Configuration _configuration = new Configuration();

        public Configuration Configuration
        {
            get { return _configuration; }
            set { _configuration = value; }
        }

        public Communication Communication
        {
            get { return _communication; }
            set { _communication = value; }
        }

        private const string ServiceRoute = "/legalentity";

        public subMerchantRetrievalResponse  GetSubMerchantResponse(string legalEntityId, string subMerchantId)
        {
            var xmlResponse = PayFacUtils.SendRetrievalRequest(ServiceRoute + "/" + legalEntityId + "/submerchant" + "/" + subMerchantId, _communication, _configuration);
            return PayFacUtils.DeserializeResponse<subMerchantRetrievalResponse >(xmlResponse);
        } 
    }
}
