﻿using System;

namespace AutoCSer.Example.TcpStaticSimpleServer
{
    /// <summary>
    /// 可读属性支持 示例
    /// </summary>
    [AutoCSer.Net.TcpStaticSimpleServer.Server(Name = ServerName.Example1)]
    partial class Property
    {
        /// <summary>
        /// 只读属性支持
        /// </summary>
        [AutoCSer.Net.TcpStaticSimpleServer.Method]
        static int GetProperty { get { return 2; } }
        /// <summary>
        /// 可写属性支持
        /// </summary>
        [AutoCSer.Net.TcpStaticSimpleServer.Method(IsOnlyGetMember = false)]
        static int SetProperty { get; set; }

        /// <summary>
        /// 可读属性支持 测试
        /// </summary>
        /// <returns></returns>
        internal static bool TestCase()
        {
            AutoCSer.Net.TcpServer.ReturnValue<int> value = AutoCSer.Example.TcpStaticSimpleServer.TcpCallSimple.Property.GetProperty;
            if (value.Type != AutoCSer.Net.TcpServer.ReturnType.Success || value.Value != 2)
            {
                return false;
            }

            SetProperty = 0;
            AutoCSer.Example.TcpStaticSimpleServer.TcpCallSimple.Property.SetProperty = 3;
            if (SetProperty != 3)
            {
                return false;
            }

            return true;
        }
    }
}
