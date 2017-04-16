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

namespace CatLib.API
{
    /// <summary>
    /// 运行时异常
    /// </summary>
    public class RuntimeException : System.Exception
    {
        /// <summary>
        /// 运行时异常
        /// </summary>
        /// <param name="message"></param>
        public RuntimeException(string message) : base(message) { }
    }
}