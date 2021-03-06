﻿using FS.ElasticSearch.Configuration;

// ReSharper disable once CheckNamespace
namespace FS.Configuration
{
    public static class ElasticSearchConfigExtends
    {
        /// <summary>
        /// 获取配置文件
        /// </summary>
        public static ElasticSearchConfig ElasticSearchConfig(this IConfigResolver resolver) => resolver.Get<ElasticSearchConfig>();
    }
}
