﻿/*
 * This file is part of the CatLib package.
 *
 * (c) Yu Bin <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: http://catlib.io/
 */

using System;
using CatLib.Debugger.WebConsole;
using System.Collections.Generic;
using CatLib.API.Debugger;

namespace CatLib.Debugger.WebMonitor.Protocol
{
    /// <summary>
    /// 获取监控信息
    /// </summary>
    internal sealed class GetMonitors : IWebConsoleResponse
    {
        /// <summary>
        /// 响应
        /// </summary>
        public object Response
        {
            get { return outputs; }
        }

        /// <summary>
        /// 输出
        /// </summary>
        private readonly IList<IDictionary<string, object>> outputs;

        /// <summary>
        /// 获取分组API
        /// </summary>
        public GetMonitors()
        {
            outputs = new List<IDictionary<string, object>>();
        }

        /// <summary>
        /// 写入一条监控信息
        /// </summary>
        /// <param name="handler">处理器</param>
        public void WriteLine(IMonitorHandler handler)
        {
            try
            {
                outputs.Add(new Dictionary<string, object>
                {
                    { "name" , handler.Name },
                    { "value" , handler.Value },
                    { "unit" , handler.Unit },
                    { "tags" , handler.Tags },
                });
            }
            catch (TypeLoadException)
            {
            }
        }
    }
}
