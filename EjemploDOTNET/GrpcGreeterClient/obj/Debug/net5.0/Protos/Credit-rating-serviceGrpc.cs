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

    /// <summary>Client for CreditRatingCheck</summary>
    public partial class CreditRatingCheckClient : grpc::ClientBase<CreditRatingCheckClient>
    {
      /// <summary>Creates a new client for CreditRatingCheck</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CreditRatingCheckClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CreditRatingCheck that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CreditRatingCheckClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CreditRatingCheckClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CreditRatingCheckClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::CreditRatingService.CreditReply CheckCreditRequest(global::CreditRatingService.CreditRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckCreditRequest(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::CreditRatingService.CreditReply CheckCreditRequest(global::CreditRatingService.CreditRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CheckCreditRequest, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::CreditRatingService.CreditReply> CheckCreditRequestAsync(global::CreditRatingService.CreditRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckCreditRequestAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::CreditRatingService.CreditReply> CheckCreditRequestAsync(global::CreditRatingService.CreditRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CheckCreditRequest, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CreditRatingCheckClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CreditRatingCheckClient(configuration);
      }
    }

  }
}
#endregion
