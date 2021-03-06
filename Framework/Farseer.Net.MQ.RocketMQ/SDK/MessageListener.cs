//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace FS.MQ.RocketMQ.SDK
{
    public class MessageListener : IDisposable
    {
        private HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal MessageListener(IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new HandleRef(this, cPtr);
        }

        internal static HandleRef getCPtr(MessageListener obj) { return obj == null ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr; }

        ~MessageListener() { Dispose(); }

        public virtual void Dispose()
        {
            lock (this)
            {
                if (swigCPtr.Handle != IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        ONSClient4CPPPINVOKE.delete_MessageListener(swigCPtr);
                    }
                    swigCPtr = new HandleRef(null, IntPtr.Zero);
                }
                GC.SuppressFinalize(this);
            }
        }

        public MessageListener() : this(ONSClient4CPPPINVOKE.new_MessageListener(), true) { SwigDirectorConnect(); }

        public virtual Action consume(Message message, ConsumeContext context)
        {
            var ret = (Action)ONSClient4CPPPINVOKE.MessageListener_consume(swigCPtr, Message.getCPtr(message), ConsumeContext.getCPtr(context));
            if (ONSClient4CPPPINVOKE.SWIGPendingException.Pending) throw ONSClient4CPPPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private void SwigDirectorConnect()
        {
            if (SwigDerivedClassHasMethod("consume", swigMethodTypes0)) swigDelegate0 = SwigDirectorconsume;
            ONSClient4CPPPINVOKE.MessageListener_director_connect(swigCPtr, swigDelegate0);
        }

        private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
        {
            var methodInfo = GetType().GetMethod(methodName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance, null, methodTypes, null);
            var hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(MessageListener));
            return hasDerivedMethod;
        }

        private int SwigDirectorconsume(IntPtr message, IntPtr context) { return (int)consume(new Message(message, false), new ConsumeContext(context, false)); }

        public delegate int SwigDelegateMessageListener_0(IntPtr message, IntPtr context);

        private SwigDelegateMessageListener_0 swigDelegate0;

        private static readonly Type[] swigMethodTypes0 = {typeof(Message), typeof(ConsumeContext)};
    }
}