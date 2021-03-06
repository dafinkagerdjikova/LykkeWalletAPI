﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LykkeApi2.Models
{
    public class GetBaseAssetsRespModel
    {
        public ApiAssetModel[] Assets { get; set; }

        public static GetBaseAssetsRespModel Create(ApiAssetModel[] assets)
        {
            return new GetBaseAssetsRespModel
            {
                Assets = assets
            };
        }
    }

    public class GetClientBaseAssetRespModel
    {
        public ApiAssetModel Asset { get; set; }

        public static GetClientBaseAssetRespModel Create(ApiAssetModel asset)
        {
            return new GetClientBaseAssetRespModel
            {
                Asset = asset
            };
        }
    }

    public class AssetAttributesModel
    {
        public IAssetAttributesKeyValue[] Pairs { get; set; }
    }

    public interface IAssetAttributesKeyValue
    {
        string Key { get; set; }
        string Value { get; set; }
    }

    public class KeyValue : IAssetAttributesKeyValue
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class AssetDescriptionsResponseModel
    {
        public IEnumerable<AssetDescriptionModel> Descriptions { get; set; }
    }

    public class GetAssetDescriptionsRequestModel
    {
        public string[] Ids { get; set; }
    }
}
