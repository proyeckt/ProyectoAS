// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/credit-rating-service.proto
// </auto-generated>
// Original file comments:
// Protos/credit-rating-service.proto
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CreditRatingService {
  public static partial class CreditRatingCheck
  {
    static readonly string __ServiceName = "CreditRating.CreditRatingCheck";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::CreditRatingService.CreditRequest> __Marshaller_CreditRating_CreditRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CreditRatingService.CreditRequest.Parser));
    static readonly grpc::Marshaller<global::CreditRatingService.CreditReply> __Marshaller_CreditRating_CreditReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CreditRatingService.CreditReply.Parser));

    static readonly grpc::Method<global::CreditRatingService.CreditRequest, global::CreditRatingService.CreditReply> __Method_CheckCreditRequest = new grpc::Method<global::CreditRatingService.CreditRequest, global::CreditRatingService.CreditReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CheckCreditRequest",
        __Marshaller_CreditRating_CreditRequest,
        __Marshaller_CreditRating_CreditReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CreditRatingService.CreditRatingServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CreditRatingCheck</summary>
    [grpc::BindServiceMethod(typeof(CreditRatingCheck), "BindService")]
    public abstract partial class CreditRatingCheckBase
    {
      public virtual global::System.Threading.Tasks.Task<global::CreditRatingService.CreditReply> CheckCreditRequest(global::CreditRatingService.CreditRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CreditRatingCheckBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CheckCreditRequest, serviceImpl.CheckCreditRequest).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CreditRatingCheckBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CheckCreditRequest, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CreditRatingService.CreditRequest, global::CreditRatingService.CreditReply>(serviceImpl.CheckCreditRequest));
    }

  }
}
#endregion