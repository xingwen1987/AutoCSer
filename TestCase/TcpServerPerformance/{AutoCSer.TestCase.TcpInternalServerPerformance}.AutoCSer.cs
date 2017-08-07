//本文件由程序自动生成,请不要自行修改
using System;
using AutoCSer;

#if NoAutoCSer
#else
#pragma warning disable
namespace AutoCSer.TestCase.TcpInternalServerPerformance
{
        public partial class InternalServer
        {
            /// <summary>
            /// TcpInternalServerPerformance TCP服务
            /// </summary>
            public sealed class TcpInternalServer : AutoCSer.Net.TcpInternalServer.Server
            {
                public readonly AutoCSer.TestCase.TcpInternalServerPerformance.InternalServer Value;
                /// <summary>
                /// TcpInternalServerPerformance TCP调用服务端
                /// </summary>
                /// <param name="attribute">TCP 调用服务器端配置信息</param>
                /// <param name="verify">套接字验证委托</param>
                /// <param name="value">TCP 服务目标对象</param>
                /// <param name="log">日志接口</param>
                /// <param name="onCustomData">自定义数据包处理</param>
                public TcpInternalServer(AutoCSer.Net.TcpInternalServer.ServerAttribute attribute = null, Func<System.Net.Sockets.Socket, bool> verify = null, AutoCSer.TestCase.TcpInternalServerPerformance.InternalServer value = null, Action<SubArray<byte>> onCustomData = null, AutoCSer.Log.ILog log = null)
                    : base(attribute ?? (attribute = AutoCSer.Net.TcpInternalServer.ServerAttribute.GetConfig("TcpInternalServerPerformance", typeof(AutoCSer.TestCase.TcpInternalServerPerformance.InternalServer))), verify, onCustomData, log, false)
                {
                    Value = value ?? new AutoCSer.TestCase.TcpInternalServerPerformance.InternalServer();
                    setCommandData(13);
                    setCommand(0);
                    setCommand(1);
                    setCommand(2);
                    setCommand(3);
                    setCommand(4);
                    setCommand(5);
                    setCommand(6);
                    setCommand(7);
                    setCommand(8);
                    setCommand(9);
                    setCommand(10);
                    setCommand(11);
                    setCommand(12);
                    if (attribute.IsAutoServer) Start();
                }
                /// <summary>
                /// 命令处理
                /// </summary>
                /// <param name="index">命令序号</param>
                /// <param name="sender">TCP 内部服务套接字数据发送</param>
                /// <param name="data">命令数据</param>
                public override void DoCommand(int index, AutoCSer.Net.TcpInternalServer.ServerSocketSender sender, ref SubArray<byte> data)
                {
                    AutoCSer.Net.TcpServer.ReturnType returnType;
                    switch (index - 128)
                    {
                        case 0:
                            returnType = AutoCSer.Net.TcpServer.ReturnType.Unknown;
                            try
                            {
                                _p1 inputParameter = new _p1();
                                if (sender.DeSerialize(ref data, ref inputParameter, true))
                                {
                                    _s0/**/.Call(sender, Value, AutoCSer.Net.TcpServer.ServerTaskType.Timeout, ref inputParameter);
                                    return;
                                }
                                returnType = AutoCSer.Net.TcpServer.ReturnType.ServerDeSerializeError;
                            }
                            catch (Exception error)
                            {
                                returnType = AutoCSer.Net.TcpServer.ReturnType.ServerException;
                                sender.Log(error);
                            }
                            sender.Push(returnType);
                            return;
                        case 1:
                            returnType = AutoCSer.Net.TcpServer.ReturnType.Unknown;
                            try
                            {
                                _p3 inputParameter = new _p3();
                                if (sender.DeSerialize(ref data, ref inputParameter, true))
                                {
                                    _p4 outputParameter = new _p4();
                                    
                                    Value.addAsynchronous(inputParameter.p0, inputParameter.p1, sender.GetCallback<_p4, AutoCSer.TestCase.TcpServerPerformance.Add>(_c1, ref outputParameter));
                                    return;
                                }
                                returnType = AutoCSer.Net.TcpServer.ReturnType.ServerDeSerializeError;
                            }
                            catch (Exception error)
                            {
                                returnType = AutoCSer.Net.TcpServer.ReturnType.ServerException;
                                sender.Log(error);
                            }
                            sender.Push(returnType);
                            return;
                        case 2:
                            returnType = AutoCSer.Net.TcpServer.ReturnType.Unknown;
                            try
                            {
                                _p3 inputParameter = new _p3();
                                if (sender.DeSerialize(ref data, ref inputParameter, true))
                                {
                                    _p4 _outputParameter_ = new _p4();
                                    
                                    AutoCSer.TestCase.TcpServerPerformance.Add Return;
                                    
                                    Return = Value.addSynchronous(inputParameter.p0, inputParameter.p1);
                                    _outputParameter_.Return = Return;
                                    sender.Push(_c2, ref _outputParameter_);
                                    return;
                                }
                                returnType = AutoCSer.Net.TcpServer.ReturnType.ServerDeSerializeError;
                            }
                            catch (Exception error)
                            {
                                returnType = AutoCSer.Net.TcpServer.ReturnType.ServerException;
                                sender.Log(error);
                            }
                            sender.Push(returnType);
                            return;
                        case 3:
                            returnType = AutoCSer.Net.TcpServer.ReturnType.Unknown;
                            try
                            {
                                _p3 inputParameter = new _p3();
                                if (sender.DeSerialize(ref data, ref inputParameter, true))
                                {
                                    _s3/**/.Call(sender, Value, AutoCSer.Net.TcpServer.ServerTaskType.TcpQueue, ref inputParameter);
                                    return;
                                }
                                returnType = AutoCSer.Net.TcpServer.ReturnType.ServerDeSerializeError;
                            }
                            catch (Exception error)
                            {
                                returnType = AutoCSer.Net.TcpServer.ReturnType.ServerException;
                                sender.Log(error);
                            }
                            sender.Push(returnType);
                            return;
                        case 4:
                            returnType = AutoCSer.Net.TcpServer.ReturnType.Unknown;
                            try
                            {
                                _p3 inputParameter = new _p3();
                                if (sender.DeSerialize(ref data, ref inputParameter, true))
                                {
                                    _s4/**/.Call(sender, Value, AutoCSer.Net.TcpServer.ServerTaskType.TcpTask, ref inputParameter);
                                    return;
                                }
                                returnType = AutoCSer.Net.TcpServer.ReturnType.ServerDeSerializeError;
                            }
                            catch (Exception error)
                            {
                                returnType = AutoCSer.Net.TcpServer.ReturnType.ServerException;
                                sender.Log(error);
                            }
                            sender.Push(returnType);
                            return;
                        case 5:
                            returnType = AutoCSer.Net.TcpServer.ReturnType.Unknown;
                            try
                            {
                                _p3 inputParameter = new _p3();
                                if (sender.DeSerialize(ref data, ref inputParameter, true))
                                {
                                    _s5/**/.Call(sender, Value, AutoCSer.Net.TcpServer.ServerTaskType.Timeout, ref inputParameter);
                                    return;
                                }
                                returnType = AutoCSer.Net.TcpServer.ReturnType.ServerDeSerializeError;
                            }
                            catch (Exception error)
                            {
                                returnType = AutoCSer.Net.TcpServer.ReturnType.ServerException;
                                sender.Log(error);
                            }
                            sender.Push(returnType);
                            return;
                        case 6:
                            returnType = AutoCSer.Net.TcpServer.ReturnType.Unknown;
                            try
                            {
                                _p3 inputParameter = new _p3();
                                if (sender.DeSerialize(ref data, ref inputParameter, true))
                                {
                                    _s6/**/.Call(sender, Value, AutoCSer.Net.TcpServer.ServerTaskType.ThreadPool, ref inputParameter);
                                    return;
                                }
                                returnType = AutoCSer.Net.TcpServer.ReturnType.ServerDeSerializeError;
                            }
                            catch (Exception error)
                            {
                                returnType = AutoCSer.Net.TcpServer.ReturnType.ServerException;
                                sender.Log(error);
                            }
                            sender.Push(returnType);
                            return;
                        case 7:
                            returnType = AutoCSer.Net.TcpServer.ReturnType.Unknown;
                            try
                            {
                                {
                                    _p4 outputParameter = new _p4();
                                    
                                    Value.addRegister(sender.GetCallback<_p4, AutoCSer.TestCase.TcpServerPerformance.Add>(_c7, ref outputParameter));
                                    return;
                                }
                            }
                            catch (Exception error)
                            {
                                returnType = AutoCSer.Net.TcpServer.ReturnType.ServerException;
                                sender.Log(error);
                            }
                            sender.Push(returnType);
                            return;
                        case 8:
                            try
                            {
                                _p3 inputParameter = new _p3();
                                if (sender.DeSerialize(ref data, ref inputParameter, true))
                                {
                                    
                                    Value.addRegister(inputParameter.p0, inputParameter.p1);
                                    return;
                                }
                            }
                            catch (Exception error)
                            {
                                sender.Log(error);
                            }
                            return;
                        case 9:
                            returnType = AutoCSer.Net.TcpServer.ReturnType.Unknown;
                            try
                            {
                                {
                                    _p5 outputParameter = new _p5();
                                    
                                    Value.addCustomSerialize(sender.GetCallback<_p5, AutoCSer.TestCase.TcpInternalServerPerformance.ServerCustomSerialize>(_c9, ref outputParameter));
                                    return;
                                }
                            }
                            catch (Exception error)
                            {
                                returnType = AutoCSer.Net.TcpServer.ReturnType.ServerException;
                                sender.Log(error);
                            }
                            sender.Push(returnType);
                            return;
                        case 10:
                            try
                            {
                                _p6 inputParameter = new _p6();
                                if (sender.DeSerialize(ref data, ref inputParameter))
                                {
                                    
                                    Value.addCustomSerialize(inputParameter.p0);
                                    return;
                                }
                            }
                            catch (Exception error)
                            {
                                sender.Log(error);
                            }
                            return;
                        case 11:
                            try
                            {
                                {
                                    
                                    Value.addCustomSerializeFinally();
                                    return;
                                }
                            }
                            catch (Exception error)
                            {
                                sender.Log(error);
                            }
                            return;
                        case 12:
                            try
                            {
                                _p6 inputParameter = new _p6();
                                if (sender.DeSerialize(ref data, ref inputParameter))
                                {
                                    
                                    Value.addCustomSerializeRegister(inputParameter.p0);
                                    return;
                                }
                            }
                            catch (Exception error)
                            {
                                sender.Log(error);
                            }
                            return;
                        default: return;
                    }
                }
                sealed class _s0 : AutoCSer.Net.TcpInternalServer.ServerCall<_s0, AutoCSer.TestCase.TcpInternalServerPerformance.InternalServer, _p1>
                {
                    private void get(ref AutoCSer.Net.TcpServer.ReturnValue<_p2> value)
                    {
                        try
                        {
                            
                            int Return;

                            
                            Return = serverValue.add(inputParameter.p0, inputParameter.p1);

                            value.Value.Return = Return;
                            value.Type = AutoCSer.Net.TcpServer.ReturnType.Success;
                        }
                        catch (Exception error)
                        {
                            value.Type = AutoCSer.Net.TcpServer.ReturnType.ServerException;
                            Sender.Log(error);
                        }
                    }
                    public override void Call()
                    {
                        AutoCSer.Net.TcpServer.ReturnValue<_p2> value = new AutoCSer.Net.TcpServer.ReturnValue<_p2>();
                        if (Sender.IsSocket)
                        {
                            get(ref value);
                            Sender.Push(CommandIndex, _c0, ref value);
                        }
                        push(this);
                    }
                }
                private static readonly AutoCSer.Net.TcpServer.OutputInfo _c0 = new AutoCSer.Net.TcpServer.OutputInfo { OutputParameterIndex = 2, IsSimpleSerializeOutputParamter = true };
                private static readonly AutoCSer.Net.TcpServer.OutputInfo _c1 = new AutoCSer.Net.TcpServer.OutputInfo { OutputParameterIndex = 4 };
                private static readonly AutoCSer.Net.TcpServer.OutputInfo _c2 = new AutoCSer.Net.TcpServer.OutputInfo { OutputParameterIndex = 4 };
                sealed class _s3 : AutoCSer.Net.TcpInternalServer.ServerCall<_s3, AutoCSer.TestCase.TcpInternalServerPerformance.InternalServer, _p3>
                {
                    private void get(ref AutoCSer.Net.TcpServer.ReturnValue<_p4> value)
                    {
                        try
                        {
                            
                            AutoCSer.TestCase.TcpServerPerformance.Add Return;

                            
                            Return = serverValue.addQueue(inputParameter.p0, inputParameter.p1);

                            value.Value.Return = Return;
                            value.Type = AutoCSer.Net.TcpServer.ReturnType.Success;
                        }
                        catch (Exception error)
                        {
                            value.Type = AutoCSer.Net.TcpServer.ReturnType.ServerException;
                            Sender.Log(error);
                        }
                    }
                    public override void Call()
                    {
                        AutoCSer.Net.TcpServer.ReturnValue<_p4> value = new AutoCSer.Net.TcpServer.ReturnValue<_p4>();
                        if (Sender.IsSocket)
                        {
                            get(ref value);
                            Sender.Push(CommandIndex, _c3, ref value);
                        }
                        push(this);
                    }
                }
                private static readonly AutoCSer.Net.TcpServer.OutputInfo _c3 = new AutoCSer.Net.TcpServer.OutputInfo { OutputParameterIndex = 4 };
                sealed class _s4 : AutoCSer.Net.TcpInternalServer.ServerCall<_s4, AutoCSer.TestCase.TcpInternalServerPerformance.InternalServer, _p3>
                {
                    private void get(ref AutoCSer.Net.TcpServer.ReturnValue<_p4> value)
                    {
                        try
                        {
                            
                            AutoCSer.TestCase.TcpServerPerformance.Add Return;

                            
                            Return = serverValue.addTcpTask(inputParameter.p0, inputParameter.p1);

                            value.Value.Return = Return;
                            value.Type = AutoCSer.Net.TcpServer.ReturnType.Success;
                        }
                        catch (Exception error)
                        {
                            value.Type = AutoCSer.Net.TcpServer.ReturnType.ServerException;
                            Sender.Log(error);
                        }
                    }
                    public override void Call()
                    {
                        AutoCSer.Net.TcpServer.ReturnValue<_p4> value = new AutoCSer.Net.TcpServer.ReturnValue<_p4>();
                        if (Sender.IsSocket)
                        {
                            get(ref value);
                            Sender.Push(CommandIndex, _c4, ref value);
                        }
                        push(this);
                    }
                }
                private static readonly AutoCSer.Net.TcpServer.OutputInfo _c4 = new AutoCSer.Net.TcpServer.OutputInfo { OutputParameterIndex = 4 };
                sealed class _s5 : AutoCSer.Net.TcpInternalServer.ServerCall<_s5, AutoCSer.TestCase.TcpInternalServerPerformance.InternalServer, _p3>
                {
                    private void get(ref AutoCSer.Net.TcpServer.ReturnValue<_p4> value)
                    {
                        try
                        {
                            
                            AutoCSer.TestCase.TcpServerPerformance.Add Return;

                            
                            Return = serverValue.addTimeoutTask(inputParameter.p0, inputParameter.p1);

                            value.Value.Return = Return;
                            value.Type = AutoCSer.Net.TcpServer.ReturnType.Success;
                        }
                        catch (Exception error)
                        {
                            value.Type = AutoCSer.Net.TcpServer.ReturnType.ServerException;
                            Sender.Log(error);
                        }
                    }
                    public override void Call()
                    {
                        AutoCSer.Net.TcpServer.ReturnValue<_p4> value = new AutoCSer.Net.TcpServer.ReturnValue<_p4>();
                        if (Sender.IsSocket)
                        {
                            get(ref value);
                            Sender.Push(CommandIndex, _c5, ref value);
                        }
                        push(this);
                    }
                }
                private static readonly AutoCSer.Net.TcpServer.OutputInfo _c5 = new AutoCSer.Net.TcpServer.OutputInfo { OutputParameterIndex = 4 };
                sealed class _s6 : AutoCSer.Net.TcpInternalServer.ServerCall<_s6, AutoCSer.TestCase.TcpInternalServerPerformance.InternalServer, _p3>
                {
                    private void get(ref AutoCSer.Net.TcpServer.ReturnValue<_p4> value)
                    {
                        try
                        {
                            
                            AutoCSer.TestCase.TcpServerPerformance.Add Return;

                            
                            Return = serverValue.addThreadPool(inputParameter.p0, inputParameter.p1);

                            value.Value.Return = Return;
                            value.Type = AutoCSer.Net.TcpServer.ReturnType.Success;
                        }
                        catch (Exception error)
                        {
                            value.Type = AutoCSer.Net.TcpServer.ReturnType.ServerException;
                            Sender.Log(error);
                        }
                    }
                    public override void Call()
                    {
                        AutoCSer.Net.TcpServer.ReturnValue<_p4> value = new AutoCSer.Net.TcpServer.ReturnValue<_p4>();
                        if (Sender.IsSocket)
                        {
                            get(ref value);
                            Sender.Push(CommandIndex, _c6, ref value);
                        }
                        push(this);
                    }
                }
                private static readonly AutoCSer.Net.TcpServer.OutputInfo _c6 = new AutoCSer.Net.TcpServer.OutputInfo { OutputParameterIndex = 4 };
                private static readonly AutoCSer.Net.TcpServer.OutputInfo _c7 = new AutoCSer.Net.TcpServer.OutputInfo { OutputParameterIndex = 4, IsKeepCallback = 1 };
                private static readonly AutoCSer.Net.TcpServer.OutputInfo _c8 = new AutoCSer.Net.TcpServer.OutputInfo { OutputParameterIndex = 0, IsClientSendOnly = 1 };
                private static readonly AutoCSer.Net.TcpServer.OutputInfo _c9 = new AutoCSer.Net.TcpServer.OutputInfo { OutputParameterIndex = 5, IsKeepCallback = 1 };
                private static readonly AutoCSer.Net.TcpServer.OutputInfo _c10 = new AutoCSer.Net.TcpServer.OutputInfo { OutputParameterIndex = 0, IsClientSendOnly = 1 };
                private static readonly AutoCSer.Net.TcpServer.OutputInfo _c11 = new AutoCSer.Net.TcpServer.OutputInfo { OutputParameterIndex = 0, IsClientSendOnly = 1 };
                private static readonly AutoCSer.Net.TcpServer.OutputInfo _c12 = new AutoCSer.Net.TcpServer.OutputInfo { OutputParameterIndex = 0, IsClientSendOnly = 1 };

                [AutoCSer.BinarySerialize.Serialize(IsMemberMap = false)]
                [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto)]
                internal struct _p1
                {
                    public int p0;
                    public int p1;
                }
                [AutoCSer.BinarySerialize.Serialize(IsMemberMap = false)]
                [AutoCSer.Metadata.BoxSerialize]
                [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto)]
                internal struct _p2
#if NOJIT
                     : AutoCSer.Net.IReturnParameter
#else
                     : AutoCSer.Net.IReturnParameter<int>
#endif
                {
                    [AutoCSer.Json.IgnoreMember]
                    public int Ret;
                    [AutoCSer.IOS.Preserve(Conditional = true)]
                    public int Return
                    {
                        get { return Ret; }
                        set { Ret = value; }
                    }
#if NOJIT
                    [AutoCSer.Metadata.Ignore]
                    public object ReturnObject
                    {
                        get { return Ret; }
                        set { Ret = (int)value; }
                    }
#endif
                }
                [AutoCSer.BinarySerialize.Serialize(IsMemberMap = false, IsReferenceMember = false)]
                [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto)]
                internal struct _p3
                {
                    public int p0;
                    public int p1;
                }
                [AutoCSer.BinarySerialize.Serialize(IsMemberMap = false, IsReferenceMember = false)]
                [AutoCSer.Metadata.BoxSerialize]
                [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto)]
                internal struct _p4
#if NOJIT
                     : AutoCSer.Net.IReturnParameter
#else
                     : AutoCSer.Net.IReturnParameter<AutoCSer.TestCase.TcpServerPerformance.Add>
#endif
                {
                    [AutoCSer.Json.IgnoreMember]
                    public AutoCSer.TestCase.TcpServerPerformance.Add Ret;
                    [AutoCSer.IOS.Preserve(Conditional = true)]
                    public AutoCSer.TestCase.TcpServerPerformance.Add Return
                    {
                        get { return Ret; }
                        set { Ret = value; }
                    }
#if NOJIT
                    [AutoCSer.Metadata.Ignore]
                    public object ReturnObject
                    {
                        get { return Ret; }
                        set { Ret = (AutoCSer.TestCase.TcpServerPerformance.Add)value; }
                    }
#endif
                }
                [AutoCSer.BinarySerialize.Serialize(IsMemberMap = false, IsReferenceMember = false)]
                [AutoCSer.Metadata.BoxSerialize]
                [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto)]
                internal struct _p5
#if NOJIT
                     : AutoCSer.Net.IReturnParameter
#else
                     : AutoCSer.Net.IReturnParameter<AutoCSer.TestCase.TcpInternalServerPerformance.ServerCustomSerialize>
#endif
                {
                    [AutoCSer.Json.IgnoreMember]
                    public AutoCSer.TestCase.TcpInternalServerPerformance.ServerCustomSerialize Ret;
                    [AutoCSer.IOS.Preserve(Conditional = true)]
                    public AutoCSer.TestCase.TcpInternalServerPerformance.ServerCustomSerialize Return
                    {
                        get { return Ret; }
                        set { Ret = value; }
                    }
#if NOJIT
                    [AutoCSer.Metadata.Ignore]
                    public object ReturnObject
                    {
                        get { return Ret; }
                        set { Ret = (AutoCSer.TestCase.TcpInternalServerPerformance.ServerCustomSerialize)value; }
                    }
#endif
                }
                [AutoCSer.BinarySerialize.Serialize(IsMemberMap = false, IsReferenceMember = false)]
                [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto)]
                internal struct _p6
                {
                    public AutoCSer.TestCase.TcpInternalServerPerformance.ClientCustomSerialize p0;
                }
            }
            /// <summary>
            /// TCP客户端
            /// </summary>
            public class TcpInternalClient : AutoCSer.Net.TcpInternalServer.MethodClient<TcpInternalClient>
            {
                /// <summary>
                /// TCP调用客户端
                /// </summary>
                /// <param name="attribute">TCP 调用服务器端配置信息</param>
                /// <param name="onCustomData">自定义数据包处理</param>
                /// <param name="log">日志接口</param>
                public TcpInternalClient(AutoCSer.Net.TcpInternalServer.ServerAttribute attribute = null, Action<SubArray<byte>> onCustomData = null, AutoCSer.Log.ILog log = null)
                {
                    if (attribute == null)
                    {
                        attribute = AutoCSer.Net.TcpInternalServer.ServerAttribute.GetConfig("TcpInternalServerPerformance", typeof(AutoCSer.TestCase.TcpInternalServerPerformance.InternalServer));
                    }
                    _TcpClient_ = new AutoCSer.Net.TcpInternalServer.Client<TcpInternalClient>(this, attribute, onCustomData, log);
                    if (attribute.IsAuto) _TcpClient_.TryCreateSocket();
                }

                private static readonly AutoCSer.Net.TcpServer.CommandInfo _c0 = new AutoCSer.Net.TcpServer.CommandInfo { Command = 0 + 128, InputParameterIndex = 1, IsSendOnly = 0, TaskType = AutoCSer.Net.TcpServer.ClientTaskType.Synchronous, IsSimpleSerializeInputParamter = true, IsSimpleSerializeOutputParamter = true };

                /// <summary>
                /// 客户端同步计算测试
                /// </summary>
                public AutoCSer.Net.TcpServer.ReturnValue<int> add(int left, int right)
                {
                    AutoCSer.Net.TcpServer.AutoWaitReturnValue<TcpInternalServer._p2> _wait_ = AutoCSer.Net.TcpServer.AutoWaitReturnValue<TcpInternalServer._p2>.Pop();
                    int _isWait_ = 0;
                    try
                    {
                        AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = _TcpClient_.Sender;
                        if (_socket_ != null)
                        {
                            TcpInternalServer._p1 _inputParameter_ = new TcpInternalServer._p1
                            {
                                
                                p0 = left,
                                
                                p1 = right,
                            };
                            TcpInternalServer._p2 _outputParameter_ = new TcpInternalServer._p2
                            {
                            };
                            _socket_.Get<TcpInternalServer._p1, TcpInternalServer._p2>(_c0, _wait_, ref _inputParameter_, ref _outputParameter_);
                            _isWait_ = 1;
                            AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p2> _returnOutputParameter_;
                            _wait_.Get(out _returnOutputParameter_);
                            return new AutoCSer.Net.TcpServer.ReturnValue<int> { Type = _returnOutputParameter_.Type, Value = _returnOutputParameter_.Value.Return };
                        }
                    }
                    finally
                    {
                        if (_isWait_ == 0) AutoCSer.Net.TcpServer.AutoWaitReturnValue<TcpInternalServer._p2>.PushNotNull(_wait_);
                    }
                    return new AutoCSer.Net.TcpServer.ReturnValue<int> { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };
                }
#if DOTNET2
#else
#if DOTNET4
#else
                /// <summary>
                /// 客户端同步计算测试
                /// </summary>
                public async System.Threading.Tasks.Task<AutoCSer.Net.TcpServer.ReturnValue<int>> addAsync(int left, int right)
                {
                    AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = _TcpClient_.Sender;
                    if (_socket_ != null)
                    {
                        AutoCSer.Net.TcpServer.TaskAsyncReturnValue<TcpInternalServer._p2> _wait_ = new AutoCSer.Net.TcpServer.TaskAsyncReturnValue<TcpInternalServer._p2>();
                        TcpInternalServer._p1 _inputParameter_ = new TcpInternalServer._p1
                        {
                            
                            p0 = left,
                            
                            p1 = right,
                        };
                        TcpInternalServer._p2 _outputParameter_ = new TcpInternalServer._p2
                        {
                        };
                        _socket_.Get<TcpInternalServer._p1, TcpInternalServer._p2>(_c0, _wait_, ref _inputParameter_, ref _outputParameter_);
                        AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p2> _returnOutputParameter_ = await _wait_;
                        return new AutoCSer.Net.TcpServer.ReturnValue<int> { Type = _returnOutputParameter_.Type, Value = _returnOutputParameter_.Value.Return };
                    }
                    return new AutoCSer.Net.TcpServer.ReturnValue<int> { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };
                }
#endif
#endif


                private static readonly AutoCSer.Net.TcpServer.CommandInfo _ac1 = new AutoCSer.Net.TcpServer.CommandInfo { Command = 1 + 128, InputParameterIndex = 3, TaskType = AutoCSer.Net.TcpServer.ClientTaskType.Synchronous, IsSimpleSerializeInputParamter = true };
                /// <summary>
                /// 异步计算测试
                /// </summary>
                public void addAsynchronous(int left, int right, Action<AutoCSer.Net.TcpServer.ReturnValue<AutoCSer.TestCase.TcpServerPerformance.Add>> _onReturn_)
                {
                    AutoCSer.Net.Callback<AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p4>> _onOutput_ = _TcpClient_.GetCallback<AutoCSer.TestCase.TcpServerPerformance.Add, TcpInternalServer._p4>(_onReturn_);
                    int _isWait_ = 0;
                    try
                    {
                        AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = _TcpClient_.Sender;
                        if (_socket_ != null)
                        {
                            TcpInternalServer._p3 _inputParameter_ = new TcpInternalServer._p3
                            {
                                
                                p0 = left,
                                
                                p1 = right,
                            };
                            _socket_.Get<TcpInternalServer._p3, TcpInternalServer._p4>(_ac1, _onOutput_, ref _inputParameter_);
                            _isWait_ = 1;
                        }
                    }
                    finally
                    {
                        if (_isWait_ == 0)
                        {
                            AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p4> _outputParameter_ = new AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p4> { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };
                            _onOutput_.Call(ref _outputParameter_);
                        }
                    }
                }


                private static readonly AutoCSer.Net.TcpServer.CommandInfo _ac2 = new AutoCSer.Net.TcpServer.CommandInfo { Command = 2 + 128, InputParameterIndex = 3, TaskType = AutoCSer.Net.TcpServer.ClientTaskType.Synchronous, IsSimpleSerializeInputParamter = true };
                /// <summary>
                /// 简单计算测试
                /// </summary>
                public void addSynchronous(int left, int right, Action<AutoCSer.Net.TcpServer.ReturnValue<AutoCSer.TestCase.TcpServerPerformance.Add>> _onReturn_)
                {
                    AutoCSer.Net.Callback<AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p4>> _onOutput_ = _TcpClient_.GetCallback<AutoCSer.TestCase.TcpServerPerformance.Add, TcpInternalServer._p4>(_onReturn_);
                    int _isWait_ = 0;
                    try
                    {
                        AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = _TcpClient_.Sender;
                        if (_socket_ != null)
                        {
                            TcpInternalServer._p3 _inputParameter_ = new TcpInternalServer._p3
                            {
                                
                                p0 = left,
                                
                                p1 = right,
                            };
                            _socket_.Get<TcpInternalServer._p3, TcpInternalServer._p4>(_ac2, _onOutput_, ref _inputParameter_);
                            _isWait_ = 1;
                        }
                    }
                    finally
                    {
                        if (_isWait_ == 0)
                        {
                            AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p4> _outputParameter_ = new AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p4> { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };
                            _onOutput_.Call(ref _outputParameter_);
                        }
                    }
                }


                private static readonly AutoCSer.Net.TcpServer.CommandInfo _ac3 = new AutoCSer.Net.TcpServer.CommandInfo { Command = 3 + 128, InputParameterIndex = 3, TaskType = AutoCSer.Net.TcpServer.ClientTaskType.Synchronous, IsSimpleSerializeInputParamter = true };
                /// <summary>
                /// 计算队列测试
                /// </summary>
                public void addQueue(int left, int right, Action<AutoCSer.Net.TcpServer.ReturnValue<AutoCSer.TestCase.TcpServerPerformance.Add>> _onReturn_)
                {
                    AutoCSer.Net.Callback<AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p4>> _onOutput_ = _TcpClient_.GetCallback<AutoCSer.TestCase.TcpServerPerformance.Add, TcpInternalServer._p4>(_onReturn_);
                    int _isWait_ = 0;
                    try
                    {
                        AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = _TcpClient_.Sender;
                        if (_socket_ != null)
                        {
                            TcpInternalServer._p3 _inputParameter_ = new TcpInternalServer._p3
                            {
                                
                                p0 = left,
                                
                                p1 = right,
                            };
                            _socket_.Get<TcpInternalServer._p3, TcpInternalServer._p4>(_ac3, _onOutput_, ref _inputParameter_);
                            _isWait_ = 1;
                        }
                    }
                    finally
                    {
                        if (_isWait_ == 0)
                        {
                            AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p4> _outputParameter_ = new AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p4> { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };
                            _onOutput_.Call(ref _outputParameter_);
                        }
                    }
                }


                private static readonly AutoCSer.Net.TcpServer.CommandInfo _ac4 = new AutoCSer.Net.TcpServer.CommandInfo { Command = 4 + 128, InputParameterIndex = 3, TaskType = AutoCSer.Net.TcpServer.ClientTaskType.Synchronous, IsSimpleSerializeInputParamter = true };
                /// <summary>
                /// 计算任务测试
                /// </summary>
                public void addTcpTask(int left, int right, Action<AutoCSer.Net.TcpServer.ReturnValue<AutoCSer.TestCase.TcpServerPerformance.Add>> _onReturn_)
                {
                    AutoCSer.Net.Callback<AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p4>> _onOutput_ = _TcpClient_.GetCallback<AutoCSer.TestCase.TcpServerPerformance.Add, TcpInternalServer._p4>(_onReturn_);
                    int _isWait_ = 0;
                    try
                    {
                        AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = _TcpClient_.Sender;
                        if (_socket_ != null)
                        {
                            TcpInternalServer._p3 _inputParameter_ = new TcpInternalServer._p3
                            {
                                
                                p0 = left,
                                
                                p1 = right,
                            };
                            _socket_.Get<TcpInternalServer._p3, TcpInternalServer._p4>(_ac4, _onOutput_, ref _inputParameter_);
                            _isWait_ = 1;
                        }
                    }
                    finally
                    {
                        if (_isWait_ == 0)
                        {
                            AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p4> _outputParameter_ = new AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p4> { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };
                            _onOutput_.Call(ref _outputParameter_);
                        }
                    }
                }


                private static readonly AutoCSer.Net.TcpServer.CommandInfo _ac5 = new AutoCSer.Net.TcpServer.CommandInfo { Command = 5 + 128, InputParameterIndex = 3, TaskType = AutoCSer.Net.TcpServer.ClientTaskType.Synchronous, IsSimpleSerializeInputParamter = true };
                /// <summary>
                /// 计算任务测试
                /// </summary>
                public void addTimeoutTask(int left, int right, Action<AutoCSer.Net.TcpServer.ReturnValue<AutoCSer.TestCase.TcpServerPerformance.Add>> _onReturn_)
                {
                    AutoCSer.Net.Callback<AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p4>> _onOutput_ = _TcpClient_.GetCallback<AutoCSer.TestCase.TcpServerPerformance.Add, TcpInternalServer._p4>(_onReturn_);
                    int _isWait_ = 0;
                    try
                    {
                        AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = _TcpClient_.Sender;
                        if (_socket_ != null)
                        {
                            TcpInternalServer._p3 _inputParameter_ = new TcpInternalServer._p3
                            {
                                
                                p0 = left,
                                
                                p1 = right,
                            };
                            _socket_.Get<TcpInternalServer._p3, TcpInternalServer._p4>(_ac5, _onOutput_, ref _inputParameter_);
                            _isWait_ = 1;
                        }
                    }
                    finally
                    {
                        if (_isWait_ == 0)
                        {
                            AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p4> _outputParameter_ = new AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p4> { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };
                            _onOutput_.Call(ref _outputParameter_);
                        }
                    }
                }


                private static readonly AutoCSer.Net.TcpServer.CommandInfo _ac6 = new AutoCSer.Net.TcpServer.CommandInfo { Command = 6 + 128, InputParameterIndex = 3, TaskType = AutoCSer.Net.TcpServer.ClientTaskType.Synchronous, IsSimpleSerializeInputParamter = true };
                /// <summary>
                /// 计算任务测试
                /// </summary>
                public void addThreadPool(int left, int right, Action<AutoCSer.Net.TcpServer.ReturnValue<AutoCSer.TestCase.TcpServerPerformance.Add>> _onReturn_)
                {
                    AutoCSer.Net.Callback<AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p4>> _onOutput_ = _TcpClient_.GetCallback<AutoCSer.TestCase.TcpServerPerformance.Add, TcpInternalServer._p4>(_onReturn_);
                    int _isWait_ = 0;
                    try
                    {
                        AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = _TcpClient_.Sender;
                        if (_socket_ != null)
                        {
                            TcpInternalServer._p3 _inputParameter_ = new TcpInternalServer._p3
                            {
                                
                                p0 = left,
                                
                                p1 = right,
                            };
                            _socket_.Get<TcpInternalServer._p3, TcpInternalServer._p4>(_ac6, _onOutput_, ref _inputParameter_);
                            _isWait_ = 1;
                        }
                    }
                    finally
                    {
                        if (_isWait_ == 0)
                        {
                            AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p4> _outputParameter_ = new AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p4> { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };
                            _onOutput_.Call(ref _outputParameter_);
                        }
                    }
                }


                private static readonly AutoCSer.Net.TcpServer.CommandInfo _ac7 = new AutoCSer.Net.TcpServer.CommandInfo { Command = 7 + 128, InputParameterIndex = 0, TaskType = AutoCSer.Net.TcpServer.ClientTaskType.Synchronous, IsKeepCallback = 1 };
                /// <summary>
                /// 计算回调测试
                /// </summary>
                /// <returns>保持异步回调</returns>
                public AutoCSer.Net.TcpServer.KeepCallback addRegister(Action<AutoCSer.Net.TcpServer.ReturnValue<AutoCSer.TestCase.TcpServerPerformance.Add>> _onReturn_)
                {
                    AutoCSer.Net.Callback<AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p4>> _onOutput_ = _TcpClient_.GetCallback<AutoCSer.TestCase.TcpServerPerformance.Add, TcpInternalServer._p4>(_onReturn_);
                    int _isWait_ = 0;
                    try
                    {
                        AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = _TcpClient_.Sender;
                        if (_socket_ != null)
                        {
                            AutoCSer.Net.TcpServer.KeepCallback _keepCallback_ = _socket_.Get<TcpInternalServer._p4>(_ac7, _onOutput_);
                            _isWait_ = 1;
                            return _keepCallback_;
                        }
                    }
                    finally
                    {
                        if (_isWait_ == 0)
                        {
                            AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p4> _outputParameter_ = new AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p4> { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };
                            _onOutput_.Call(ref _outputParameter_);
                        }
                    }
                    return null;
                }

                private static readonly AutoCSer.Net.TcpServer.CommandInfo _c8 = new AutoCSer.Net.TcpServer.CommandInfo { Command = 8 + 128, InputParameterIndex = 3, IsSendOnly = 1, TaskType = AutoCSer.Net.TcpServer.ClientTaskType.Synchronous, IsSimpleSerializeInputParamter = true };

                /// <summary>
                /// 计算回调测试
                /// </summary>
                [System.Runtime.CompilerServices.MethodImpl(AutoCSer.MethodImpl.AggressiveInlining)]
                public void addRegister(int left, int right)
                {
                    TcpInternalServer._p3 _inputParameter_ = new TcpInternalServer._p3
                    {
                        
                        p0 = left,
                        
                        p1 = right,
                    };
                    _TcpClient_.Sender.CallOnly(_c8, ref _inputParameter_);
                }


                private static readonly AutoCSer.Net.TcpServer.CommandInfo _ac9 = new AutoCSer.Net.TcpServer.CommandInfo { Command = 9 + 128, InputParameterIndex = 0, TaskType = AutoCSer.Net.TcpServer.ClientTaskType.Synchronous, IsKeepCallback = 1 };
                /// <summary>
                /// 计算回调测试
                /// </summary>
                /// <returns>保持异步回调</returns>
                public AutoCSer.Net.TcpServer.KeepCallback addCustomSerialize(Action<AutoCSer.Net.TcpServer.ReturnValue<AutoCSer.TestCase.TcpInternalServerPerformance.ServerCustomSerialize>> _onReturn_)
                {
                    AutoCSer.Net.Callback<AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p5>> _onOutput_ = _TcpClient_.GetCallback<AutoCSer.TestCase.TcpInternalServerPerformance.ServerCustomSerialize, TcpInternalServer._p5>(_onReturn_);
                    int _isWait_ = 0;
                    try
                    {
                        AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = _TcpClient_.Sender;
                        if (_socket_ != null)
                        {
                            AutoCSer.Net.TcpServer.KeepCallback _keepCallback_ = _socket_.Get<TcpInternalServer._p5>(_ac9, _onOutput_);
                            _isWait_ = 1;
                            return _keepCallback_;
                        }
                    }
                    finally
                    {
                        if (_isWait_ == 0)
                        {
                            AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p5> _outputParameter_ = new AutoCSer.Net.TcpServer.ReturnValue<TcpInternalServer._p5> { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };
                            _onOutput_.Call(ref _outputParameter_);
                        }
                    }
                    return null;
                }

                private static readonly AutoCSer.Net.TcpServer.CommandInfo _c10 = new AutoCSer.Net.TcpServer.CommandInfo { Command = 10 + 128, InputParameterIndex = 6, IsSendOnly = 1, TaskType = AutoCSer.Net.TcpServer.ClientTaskType.Synchronous };

                /// <summary>
                /// 计算回调测试
                /// </summary>
                [System.Runtime.CompilerServices.MethodImpl(AutoCSer.MethodImpl.AggressiveInlining)]
                public void addCustomSerialize(AutoCSer.TestCase.TcpInternalServerPerformance.ClientCustomSerialize value)
                {
                    TcpInternalServer._p6 _inputParameter_ = new TcpInternalServer._p6
                    {
                        
                        p0 = value,
                    };
                    _TcpClient_.Sender.CallOnly(_c10, ref _inputParameter_);
                }

                private static readonly AutoCSer.Net.TcpServer.CommandInfo _c11 = new AutoCSer.Net.TcpServer.CommandInfo { Command = 11 + 128, InputParameterIndex = 0, IsSendOnly = 1, TaskType = AutoCSer.Net.TcpServer.ClientTaskType.Synchronous };

                /// <summary>
                /// 计算测试结束
                /// </summary>
                [System.Runtime.CompilerServices.MethodImpl(AutoCSer.MethodImpl.AggressiveInlining)]
                public void addCustomSerializeFinally()
                {
                    _TcpClient_.Sender.CallOnly(_c11);
                }

                private static readonly AutoCSer.Net.TcpServer.CommandInfo _c12 = new AutoCSer.Net.TcpServer.CommandInfo { Command = 12 + 128, InputParameterIndex = 6, IsSendOnly = 1, TaskType = AutoCSer.Net.TcpServer.ClientTaskType.Synchronous };

                /// <summary>
                /// 计算回调测试
                /// </summary>
                [System.Runtime.CompilerServices.MethodImpl(AutoCSer.MethodImpl.AggressiveInlining)]
                public void addCustomSerializeRegister(AutoCSer.TestCase.TcpInternalServerPerformance.ClientCustomSerialize value)
                {
                    TcpInternalServer._p6 _inputParameter_ = new TcpInternalServer._p6
                    {
                        
                        p0 = value,
                    };
                    _TcpClient_.Sender.CallOnly(_c12, ref _inputParameter_);
                }

            }
        }
}
#endif